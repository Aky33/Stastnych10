using S10.DomainModel.Models;
using S10.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10.ServiceLayer.Implementations
{
    public class VypocetService : IVypocetService
    {
        private ITahService tahService;

        private int len = 80 +1;

        public VypocetService(ITahService tahService)
        {
            this.tahService = tahService;
        }

        public int[] DejVyherniCisla(int pocet)
        {
            int[] vyherniCisla = new int[pocet];

            int[] cisla = DejSpoctenaCisla();
            for (int i = 0; i < pocet; i++)
            {
                int max = 0;
                int index = 0;

                for (int j = 1; j < len; j++)
                {
                    if (cisla[j] > max)
                    {
                        max = cisla[j];
                        index = j;
                    }
                }

                vyherniCisla[i] = index;
                cisla[index] = 0;
            }

            return vyherniCisla;

        }

        private int[] DejSpoctenaCisla()
        {
            int[] cisla = new int[len];

            for (int i = 0; i < len; i++)
            {
                cisla[i] = 0;
            }

            IList<Tah> tahy = tahService.DejVsechny();

            foreach (Tah tah in tahy)
            {
                foreach (int? cislo in tah.ToArray())
                {
                    if (cislo != null)
                    {
                        cisla[(int)cislo]++;
                    }
                }
            }

            return cisla;
        }
    }
}
