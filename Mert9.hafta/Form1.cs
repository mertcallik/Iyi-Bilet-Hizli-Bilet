using Mert9.hafta.Entities;
using Mert9.hafta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Mert9.hafta.Areas.Admin;
using Mert9.hafta.Areas.Müsteri;
using static System.Net.Mime.MediaTypeNames;

namespace Mert9.hafta
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var u = IsitAnUser(tbxgirisemail.Text, tbxgirissifre.Text);
            var a = IsitAnAdmin(tbxgirisemail.Text, tbxgirissifre.Text);

            if (a != null)
            {
                MessageBox.Show("Admin sayfasina yönlendiriliyorsunuz 1 saniye içinde");
                System.Threading.Thread.Sleep(1000);

                AdminForm frm = new AdminForm(a.Id);
                frm.Show();
                this.Hide();
            }
            else if (u != null)
            {
                MessageBox.Show("Başarıyla giriş yaptınız 1 saniye yönlendiriliyorsunuz içinde");
                System.Threading.Thread.Sleep(1000);
                MusteriForm frm = new MusteriForm(u.MusteriId);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı");

            }

        }
        public Musteri IsitAnUser(string tbxgirisemail, string tbxgirissifre)
        {
            using (DataContext context = new DataContext())
            {
                var result = context.Musteriler.FirstOrDefault(m => m.Email == tbxgirisemail && m.Pass == tbxgirissifre);
                if (result!=null)
                {
                    return result;
                }
            }
            return null;
        }
        public Admin IsitAnAdmin(string tbxgirisemail, string tbxgirissifre)
        {
            using (DataContext context = new DataContext())
            {
                var result = context.Adminler.FirstOrDefault(a => a.Email == tbxgirisemail && a.Pass == tbxgirissifre);
                if (result != null)
                {
                    return result;
                }
            }
            return null;

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }


    }
}
