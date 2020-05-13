using S10.DomainModel.Models;
using S10.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace S10.Forms
{
    public partial class Tahy : Form
    {
        private ITahService tahService;
        IList<Tah> tahy;

        bool zmena = false;

        //TODO nastavit popisovač události DataError, pokud se pokusí vložit něco jiného než int do gridu
        //TODO možná přidat tlačítka? Uložit, Konec atd.
        public Tahy(ITahService tahService)
        {
            this.tahService = tahService;

            InitializeComponent();
        }

        private void Tahy_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (zmena)  //pokud je neuložená změna při hledání online, je potřeba ji prvně uložit
            {
                tahService.UlozList(tahy);
            }

            tahy = tahService.DejVsechny();

            var source = new BindingSource();
            source.DataSource = tahy;

            CislaGrid.DataSource = source;
            CislaGrid.Columns[0].Visible = false;   //skryje Id
            CislaGrid.Columns[1].Width = 400;

            for (int i = 2; i < CislaGrid.Columns.Count; i++)    //Upraví názvy sloupců aby se vešly
            {
                CislaGrid.Columns[i].HeaderText = CislaGrid.Columns[i].HeaderText.Replace("Cislo", "C");
            }

            Cursor = Cursors.Default;
        }

        private void CislaGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;

            //Validace od třetího sloupce dále
            if (e.ColumnIndex > 1)
            {
                var cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && ((int)cell.Value < 1 || (int)cell.Value > 80))
                {
                    cell.Value = null;

                    MessageBox.Show("Zadaná hodnota musí být mezi 1 - 80!");
                }
            }

            zmena = true;
        }

        private void CislaGrid_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            zmena = true;
        }

        private void HledatTahyOnlineButton_Click(object sender, EventArgs e)
        {
            new HledatTahyOnline(tahService).ShowDialog();
            MessageBox.Show("Nalezené tahy byly přidány do seznamu.");

            zmena = false;
            Tahy_Load(this, null);
        }

        private void Tahy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (zmena)
            {
                Cursor = Cursors.WaitCursor;
                tahService.UlozList(tahy);
                Cursor = Cursors.Default;
            }
        }
    }
}
