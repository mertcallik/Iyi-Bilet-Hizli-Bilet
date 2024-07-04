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
using Mert9.hafta.Data;
using Mert9.hafta.Entities;
using Mert9.hafta.Models;

namespace Mert9.hafta
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        AppRepository _app = new AppRepository();
        DataContext _context = new DataContext();
        private void btnkayitol_Click(object sender, EventArgs e)
        {

            if ((tbxkayitad.Text == null || tbxkayitsoyad.Text == null || tbxkayitemail.Text == null || tbxkayitsifre.Text == null || cbxuyruk.SelectedItem == null))
            {
                MessageBox.Show("Lütfen tüm Alanları eksiksiz şekilde doldurduğunuzdan emin olun", "Boş Geçilemez");
            }
            else
            {
                if (CheckUnique(tbxkayitemail.Text))
                {
                    MessageBox.Show("Böyle bir kullanıcı zaten mevcut", "Kullanici Mevcut");
                    tbxkayitemail.Focus();

                }
                else
                {
                    _app.Add(new Entities.Musteri { MusteriName = tbxkayitad.Text, MusteriSurName = tbxkayitsoyad.Text, MusteriNation = cbxuyruk.SelectedItem.ToString(), Pass = tbxkayitsifre.Text, Email = tbxkayitemail.Text });

                    var dialogresult = MessageBox.Show("Aramıza Hoş Geldiniz 1 saniye içinde Giriş Ekranina Yönlendiriliyorsunuz", "Hoş Geldiniz", MessageBoxButtons.OKCancel);
                    if (dialogresult == DialogResult.OK)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Form frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }



            }

        }


        public static bool CheckUnique(string email)
        {
            using (DataContext context = new DataContext())
            {
              var result=context.Musteriler.Any(m => m.Email == email);
              return result;
            }
        }

        private void btngirisekrani_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Form1"];
            frm.Show();
            this.Hide();
        }
    }
}
