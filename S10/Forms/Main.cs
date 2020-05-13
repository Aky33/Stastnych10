using S10.DomainModel.Models;
using S10.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace S10.Forms
{
    public partial class Main : Form
    {
        private IVypocetService vypocetService;
        private ITahService tahService;

        public Main(IVypocetService vypocetService, ITahService tahService)
        {
            this.vypocetService = vypocetService;
            this.tahService = tahService;

            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int[] vyherniCisla = vypocetService.DejVyherniCisla(10);

            string vyhraString = " ";
            foreach (int cislo in vyherniCisla)
            {
                vyhraString += cislo + " ";
            }

            VysledekBox.Text = vyhraString;
        }

        private void TahyButton_Click(object sender, EventArgs e)
        {
            new Tahy(tahService).ShowDialog();
            Main_Load(this, null);
        }

        private void NastaveniButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();    //TODO implementovat nastavení
        }

        private void KonecButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
