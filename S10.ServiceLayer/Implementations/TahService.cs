using S10.DataAccessLayer.Interfaces;
using S10.DomainModel.Models;
using S10.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;

namespace S10.ServiceLayer.Implementations
{
    public class TahService : ITahService
    {
        private readonly ITahDao tahDao;

        public TahService(ITahDao tahDao)
        {
            this.tahDao = tahDao;
        }

        public void VytvorTabulku()
        {
            tahDao.VytvorTabulku();
        }

        public IList<Tah> DejVsechny()
        {
            return tahDao.DejVsechny();
        }

        public void UlozList(IList<Tah> tahy)
        {
            foreach (Tah tah in tahy)
            {
                tahDao.Uloz(tah);
            }

            var tahyNaSmazani = tahDao.DejVsechny().Except(tahy).ToList();
            foreach (Tah tah in tahyNaSmazani)
            {
                tahDao.SmazPodleId(tah.Id.Value);
            }
        }

        public void HledejTahyOnlineAUlozJe(DateTime dateTime)  //TODO vylepšit hledání tahů? Chvilku to zabere
        {
            IList<Tah> tahy;

            int hledanyRok = dateTime.Year;
            int hledanyTyden = TydenVRoce(dateTime);

            using (WebClient wc = new WebClient())
            {
                int tentoRok = DateTime.Now.Year;
                for (int i = hledanyRok; i <= tentoRok; i++)
                {
                    int tyden = 1;

                    if (i == tentoRok)
                    {
                        tyden = TydenVRoce(DateTime.Now);
                    }
                    else
                    {
                        DateTime date = new DateTime(i, 12, 31 -6);
                        tyden = TydenVRoce(date);
                    }

                    for (int j = hledanyTyden; j <= tyden; j++)
                    {
                        byte[] raw = wc.DownloadData("https://www.sazka.cz/system/vyherka?year=" + i + "&week=" + j + "&game=s10");
                        string webData = System.Text.Encoding.UTF8.GetString(raw);

                        tahy = HledejTahyOnline(webData);

                        foreach (Tah tah in tahy)
                        {
                            tahDao.Uloz(tah);
                        }
                    }

                    hledanyTyden = 1;
                }
            }
        }

        /// <summary>
        /// https://stackoverflow.com/questions/11154673/get-the-correct-week-number-of-a-given-date
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private int TydenVRoce(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private IList<Tah> HledejTahyOnline(string webData)
        {
            string oznaceniDatumu = "<td class=\"s10\" colspan=\"5\">";
            int index = -1;

            IList<Tah> tahy = new List<Tah>();
            while ((index = webData.IndexOf(oznaceniDatumu)) != -1) //najde datum
            {
                webData = webData.Substring(index + oznaceniDatumu.Length);
                string datum = webData.Substring(0, webData.IndexOf('<'));

                int[] cisla = new int[20];
                string oznaceniCisla = "<td class=\"s10 b2a\">";
                for (int i = 0; i < cisla.Length; i++)
                {
                    index = webData.IndexOf(oznaceniCisla);
                    webData = webData.Substring(index + oznaceniCisla.Length);
                    string cislo = webData.Substring(0, webData.IndexOf('<'));

                    cisla[i] = Int32.Parse(cislo);
                }

                tahy.Add(new Tah(datum, cisla));
            }

            return tahy;
        }
    }
}
