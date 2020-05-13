using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace S10.DomainModel.Models
{
    [Serializable]
    public class Tah
    {
        public long? Id { get; set; }

        public string Datum { get; set; }

        public int? Cislo1 { get; set; }

        public int? Cislo2 { get; set; }

        public int? Cislo3 { get; set; }

        public int? Cislo4 { get; set; }

        public int? Cislo5 { get; set; }

        public int? Cislo6 { get; set; }

        public int? Cislo7 { get; set; }

        public int? Cislo8 { get; set; }

        public int? Cislo9 { get; set; }

        public int? Cislo10 { get; set; }

        public int? Cislo11 { get; set; }

        public int? Cislo12 { get; set; }

        public int? Cislo13 { get; set; }

        public int? Cislo14 { get; set; }

        public int? Cislo15 { get; set; }

        public int? Cislo16 { get; set; }

        public int? Cislo17 { get; set; }

        public int? Cislo18 { get; set; }

        public int? Cislo19 { get; set; }

        public int? Cislo20 { get; set; }

        public Tah()
        {

        }

        public Tah(string datum, int[] cisla)
        {
            this.Datum = datum;
            Cislo1 = cisla[0];
            Cislo2 = cisla[1];
            Cislo3 = cisla[2];
            Cislo4 = cisla[3];
            Cislo5 = cisla[4];
            Cislo6 = cisla[5];
            Cislo7 = cisla[6];
            Cislo8 = cisla[7];
            Cislo9 = cisla[8];
            Cislo10 = cisla[9];
            Cislo11 = cisla[10];
            Cislo12 = cisla[11];
            Cislo13 = cisla[12];
            Cislo14 = cisla[13];
            Cislo15 = cisla[14];
            Cislo16 = cisla[15];
            Cislo17 = cisla[16];
            Cislo18 = cisla[17];
            Cislo19 = cisla[18];
            Cislo20 = cisla[19];
        }

        public override bool Equals(object obj)
        {
            return obj is Tah tah &&
                   Id == tah.Id &&
                   Datum == tah.Datum &&
                   Cislo1 == tah.Cislo1 &&
                   Cislo2 == tah.Cislo2 &&
                   Cislo3 == tah.Cislo3 &&
                   Cislo4 == tah.Cislo4 &&
                   Cislo5 == tah.Cislo5 &&
                   Cislo6 == tah.Cislo6 &&
                   Cislo7 == tah.Cislo7 &&
                   Cislo8 == tah.Cislo8 &&
                   Cislo9 == tah.Cislo9 &&
                   Cislo10 == tah.Cislo10 &&
                   Cislo11 == tah.Cislo11 &&
                   Cislo12 == tah.Cislo12 &&
                   Cislo13 == tah.Cislo13 &&
                   Cislo14 == tah.Cislo14 &&
                   Cislo15 == tah.Cislo15 &&
                   Cislo16 == tah.Cislo16 &&
                   Cislo17 == tah.Cislo17 &&
                   Cislo18 == tah.Cislo18 &&
                   Cislo19 == tah.Cislo19 &&
                   Cislo20 == tah.Cislo20;
        }

        public override int GetHashCode()
        {
            var hashCode = 436689410;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Datum);
            hashCode = hashCode * -1521134295 + Cislo1.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo2.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo3.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo4.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo5.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo6.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo7.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo8.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo9.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo10.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo11.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo12.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo13.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo14.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo15.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo16.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo17.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo18.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo19.GetHashCode();
            hashCode = hashCode * -1521134295 + Cislo20.GetHashCode();
            return hashCode;
        }

        public int?[] ToArray()
        {
            int?[] cisla = new int?[20];

            cisla[0] = Cislo1;
            cisla[1] = Cislo2;
            cisla[2] = Cislo3;
            cisla[3] = Cislo4;
            cisla[4] = Cislo5;
            cisla[5] = Cislo6;
            cisla[6] = Cislo7;
            cisla[7] = Cislo8;
            cisla[8] = Cislo9;
            cisla[9] = Cislo10;
            cisla[10] = Cislo11;
            cisla[11] = Cislo12;
            cisla[12] = Cislo13;
            cisla[13] = Cislo14;
            cisla[14] = Cislo15;
            cisla[15] = Cislo16;
            cisla[16] = Cislo17;
            cisla[17] = Cislo18;
            cisla[18] = Cislo19;
            cisla[19] = Cislo20;

            return cisla;
        }
    }
}
