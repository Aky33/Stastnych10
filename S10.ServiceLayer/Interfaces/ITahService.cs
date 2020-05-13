using S10.DomainModel.Models;
using System;
using System.Collections.Generic;

namespace S10.ServiceLayer.Interfaces
{
    public interface ITahService
    {
        void VytvorTabulku();

        void UlozList(IList<Tah> tahy);

        IList<Tah> DejVsechny();

        void HledejTahyOnlineAUlozJe(DateTime dateTime);
    }
}
