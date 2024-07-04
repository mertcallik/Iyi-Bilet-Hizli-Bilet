using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Mert9.hafta.Areas.Müsteri
{
    public partial class CustomMessageBox : KryptonForm
    {
        public int SelectedPrice { get; private set; }
        public string SelectedType { get; private set; }
        public CustomMessageBox()
        {
            InitializeComponent();
        }



        private void btnindirimli_Click(object sender, EventArgs e)
        {
            SelectedPrice = 2000;
            SelectedType = "İndirimli";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnstandart_Click(object sender, EventArgs e)
        {
            SelectedPrice = 3000;
            SelectedType = "Standart";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çok Yakında sizlerle", "Çok yakında");
        }
    }
}
