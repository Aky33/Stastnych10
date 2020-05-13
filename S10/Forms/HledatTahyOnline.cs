using S10.ServiceLayer.Interfaces;
using System;
using System.Windows.Forms;

namespace S10.Forms
{
    public partial class HledatTahyOnline : Form
    {
        private ITahService tahService;

        public HledatTahyOnline(ITahService tahService)
        {
            InitializeComponent();

            this.tahService = tahService;
        }

        private void HledatButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            tahService.HledejTahyOnlineAUlozJe(DateTime.Value);

            Cursor = Cursors.Default;
            this.Close();
        }
    }
}
