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
using Mert9.hafta.Areas.Admin;
using Mert9.hafta.Data;
using Mert9.hafta.Entities;
using Mert9.hafta.Models;

namespace Mert9.hafta.Areas.Müsteri
{
    public partial class MusteriForm : KryptonForm
    {
        int _userId;
        DataContext _context = new DataContext();
        AppRepository _app = new AppRepository();
        
        public MusteriForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            var user = FindCurrentUser(userId);
            Musterilbl1.Text = $"Hoş Geldin {user.Email}";
            lbxmusteri.DataSource = _app.GetAll<Tur>();
            lbxmusteri.DisplayMember = "Destination,DeparturePoint,HaraktetTime";
            lbxmusteribilet.Visible = false;
            lbxmusteri.SelectedIndex = 0;
            lbxmusteribilet.SelectedItem = 0;
            btnavailabletours.Visible = false;

        }

        private Musteri FindCurrentUser(int userId)
        {
            return _context.Musteriler.FirstOrDefault(m => m.MusteriId == userId);
        }

        private void btnjointour_Click(object sender, EventArgs e)
        {
            Tur selectedTur = lbxmusteri.SelectedItem as Tur;

            if (selectedTur != null)
            {
                // CustomMessageBox formunu aç
                using (CustomMessageBox customMessageBox = new CustomMessageBox())
                {
                    if (customMessageBox.ShowDialog() == DialogResult.OK)
                    {
                        int biletFiyati = customMessageBox.SelectedPrice;
                        string biletTuru = customMessageBox.SelectedType;

                        // Seçilen bilet fiyatı ve türü üzerinden bilet oluştur
                        _app.Add(new Bilet
                        {
                            BiletType = biletTuru, // Seçilen bilet türü atanır
                            BiletPrice = biletFiyati, // Seçilen bilet fiyatı atanır
                            TurId = selectedTur.TurId, // TurId özelliğini kullanarak turun kimliğini alın
                            MusteriId = _userId,
                            TasitId = 1 // Varsayılan bir taşıt belirleyebilirsiniz
                        });

                        MessageBox.Show("Bilet başarıyla kesildi!");
                        ShowTours();
                    }
                    else
                    {
                        MessageBox.Show("Bilet seçimi iptal edildi!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir tur seçin!");
            }
        }



        private void btnshowtours_Click(object sender, EventArgs e)
        {
            ShowTours();
        }

        private void ShowTours()
        {
            lbxmusteri.Visible = false;
            lbxmusteribilet.Visible = true;
            var TurIds = _app.GetAll<Bilet>().Where(b => b.MusteriId == _userId).ToList();
            var result = _app.GetAll<Tur>().Where(t => TurIds.Any(tur => tur.TurId == t.TurId)).ToList();
            lbxmusteribilet.DataSource = result;
            lbxmusteribilet.DisplayMember = "Destination,DeparturePoint,HaraktetTime";
            btnjointour.Visible = false;
            btncancelltour.Visible = true;
            btnshowtours.Visible = false;
            btnavailabletours.Visible = true;
            label2.Text = "Kayıtlı Turlarım";
        }


        private void btncancelltour_Click(object sender, EventArgs e)
        {

            Tur selectedTur = lbxmusteribilet.SelectedItem as Tur;
            if (selectedTur != null)
            {
                var bilet = _app.GetAll<Bilet>().FirstOrDefault(b => b.TurId == selectedTur.TurId && b.MusteriId == _userId);
                if (bilet != null)
                {
                    _app.Delete(bilet);
                    MessageBox.Show("Bilet Başarıyla İptal Edildi!");
                    Showavailable();
                }
                else
                {
                    MessageBox.Show("Bilet bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir tur seçin!");
            }
            

        }

        private void btnmusterioturumkapat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Oturum Kapatmak istediğinizden emin misiniz?", "Oturum Kapat", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //kullanıcı çıkış yapmak istiyorsa giriş formuna yönlendir.
                Form frm = Application.OpenForms["Form1"];
                frm.Show();
                this.Hide();
            }
        }

        private void btnavailabletours_Click(object sender, EventArgs e)
        {

            Showavailable();

        }

        private void Showavailable()
        {
            lbxmusteri.Visible = true;
            lbxmusteribilet.Visible = false;
            lbxmusteri.DataSource = _app.GetAll<Tur>();
            lbxmusteri.DisplayMember = "Destination,DeparturePoint,HaraktetTime";
            lbxmusteri.SelectedItem = 0;
            btnjointour.Visible = true;
            btncancelltour.Visible = false;
            btnshowtours.Visible = true;
            btnavailabletours.Visible = false;
        }

        private void lbxcmustericlick(object sender, MouseEventArgs e)
        {
            ShowTourDetails(lbxmusteribilet.SelectedItem as Tur,0);
        }

        private void lbx2mustericlick(object sender, MouseEventArgs e)
        {
            ShowTourDetails(lbxmusteribilet.SelectedItem as Tur,1);
        }

       public void ShowTourDetails(Tur tur,int status)
        {

            if (tur != null)
            {
                var frm = new TourDetails(tur,_userId,status);
                frm.Show();
                
            }
        }
    }
}
