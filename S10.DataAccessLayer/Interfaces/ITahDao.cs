using S10.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10.DataAccessLayer.Interfaces
{
    public interface ITahDao
    {
        void VytvorTabulku();

        /// <summary>
        /// Uloží 20 čísel tahu, snaží se použít update, pokud nenajde používá insert
        /// </summary>
        void Uloz(Tah tah);

        Tah DejPodleId(long idTahu);

        /// <summary>
        /// Navrátí všechny tahy
        /// </summary>
        IList<Tah> DejVsechny();

        int SmazPodleId(long idTahu);
    }
}
