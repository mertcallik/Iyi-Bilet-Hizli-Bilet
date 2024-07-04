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

namespace Mert9.hafta.Areas.Admin
{
    public partial class AdminForm : KryptonForm
    {
        private int _AdminId;
        DataContext _context = new DataContext();
        AppRepository _app = new AppRepository();
        public AdminForm(int AdminId)
        {
            InitializeComponent();
            _AdminId = AdminId;
            var Admin = FindCurrenAdmin(_AdminId);
            Adminlbl1.Text = "Aktif:" + Admin.Email;
            dgAdmin.DataSource = _app.GetAll<Musteri>().ToList();
            turDtpicker.Format = DateTimePickerFormat.Custom;
            turDtpicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";


        }
        private Entities.Admin FindCurrenAdmin(int Id)
        {
            return _context.Adminler.FirstOrDefault(x => x.Id == Id);
        }

        private void btnBiletler_Click(object sender, EventArgs e)
        {
            GenericLister(_context.Biletler);
            tbxSearchBilet.Visible = true;
            tbxSearchMusteri.Visible = false;
            tbxSearchPersonel.Visible = false;
            tbxSearchTasit.Visible = false;
            tbxSearchTur.Visible = false;
            turaddgbx.Visible = false;
            personeladdbox.Visible = false;
            tasitgbx.Visible = false;
        }

        private void GenericLister<T>(IEnumerable<T> entity) where T : class
        {
            dgAdmin.DataSource = _app.GetAll<T>().ToList();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            GenericLister(_context.Personeller);
            tbxSearchPersonel.Visible = true;
            tbxSearchBilet.Visible = false;
            tbxSearchMusteri.Visible = false;
            tbxSearchTasit.Visible = false;
            tbxSearchTur.Visible = false;
            turaddgbx.Visible = false;
            personeladdbox.Visible = true;
            tasitgbx.Visible = true;


        }
        private void btnTasitlar_Click(object sender, EventArgs e)
        {
            GenericLister(_context.Tasitlar);
            tbxSearchTasit.Visible = true;
            tbxSearchBilet.Visible = false;
            tbxSearchMusteri.Visible = false;
            tbxSearchPersonel.Visible = false;
            tbxSearchTur.Visible = false;
            turaddgbx.Visible = false;
            personeladdbox.Visible = false;
            tasitgbx.Visible = true;


        }
        private void btnTurlar_Click(object sender, EventArgs e)
        {
            GenericLister(_context.Turlar);
            tbxSearchTur.Visible = true;
            tbxSearchBilet.Visible = false;
            tbxSearchMusteri.Visible = false;
            tbxSearchPersonel.Visible = false;
            tbxSearchTasit.Visible = false;
            turaddgbx.Visible = true;
            personeladdbox.Visible = false;
            tasitgbx.Visible = false;

        }

        private void btncikisyap_Click(object sender, EventArgs e)
        {
            var okDialogResult = MessageBox.Show("Çıkış Yapmak İstediginize Emin Misiniz?", "Onayla", MessageBoxButtons.OKCancel);
            if (okDialogResult == DialogResult.OK)
            {
                Form frm = Application.OpenForms["Form1"];
                frm.Show();
                this.Close();
            }

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            GenericLister(_context.Musteriler);
            tbxSearchMusteri.Visible = true;
            tbxSearchBilet.Visible = false;
            tbxSearchPersonel.Visible = false;
            tbxSearchTasit.Visible = false;
            tbxSearchTur.Visible = false;
            turaddgbx.Visible = false;
            personeladdbox.Visible = false;
            tasitgbx.Visible = false;



        }

        private void tbxSearchTur_TextChanged(object sender, EventArgs e)
        {
            dgAdmin.DataSource = _app.GetAll<Tur>().FindAll(x => x.TurId.ToString().Contains(tbxSearchTur.Text));
        }

        private void tbxSearchMusteri_TextChanged_1(object sender, EventArgs e)
        {
            dgAdmin.DataSource = _app.GetAll<Musteri>().FindAll(x => x.MusteriName.ToLower().Contains(tbxSearchMusteri.Text.ToLower()));

        }

        private void tbxSearchPersonel_TextChanged_1(object sender, EventArgs e)
        {
            dgAdmin.DataSource = _app.GetAll<Personel>().FindAll(x => x.PersonelName.ToLower().Contains(tbxSearchPersonel.Text.ToLower()));
        }

        private void tbxSearchTasit_TextChanged_1(object sender, EventArgs e)
        {
            dgAdmin.DataSource = _app.GetAll<Tasit>().FindAll(x => x.TasitPlate.ToLower().Contains(tbxSearchTasit.Text.ToLower()));
        }

        private void tbxSearchBilet_TextChanged_1(object sender, EventArgs e)
        {
            dgAdmin.DataSource = _app.GetAll<Bilet>().FindAll(x => x.Id.ToString().Contains((tbxSearchBilet.Text)));
        }


        private void btnaddturbyadmin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yeni tur eklemek mi yoksa mevcut turu güncellemek mi istiyorsunuz?", "İşlem Seçimi", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _app.Add(new Tur { HaraktetTime = turDtpicker.Value, DeparturePoint = tbxTurKalkisNoktasi.Text, Destination = tbxTurHedefNoktasi.Text });
                MessageBox.Show("Yeni Tur Başarıyla Eklendi");
            }
            else if (dialogResult == DialogResult.No)
            {
                int selectedTurId;

                bool parseResult = int.TryParse(dgAdmin.CurrentRow.Cells["TurId"].Value.ToString(), out selectedTurId);

                if (parseResult)
                {
                    _app.Update(new Tur
                    {
                        TurId = selectedTurId,
                        HaraktetTime = turDtpicker.Value,
                        DeparturePoint = tbxTurKalkisNoktasi.Text,
                        Destination = tbxTurHedefNoktasi.Text
                    });

                    MessageBox.Show("Tur Başarıyla Güncellendi");
                }
                else
                {
                    MessageBox.Show("Tur güncelleme işlemi için geçerli bir tur seçilmemiş.");
                }
            }

            Refresher(_context.Turlar);

        }


        private void Refresher<T>(IEnumerable<T> entity) where T : class
        {
            dgAdmin.DataSource = _app.GetAll<T>().ToList();
        }

        private void btnaddpersonelbyadmin_Click(object sender, EventArgs e)
        {

            int salary;
            var result = int.TryParse(tbxpersonelsalary.Text, out salary);

            if (result)
            {
                DialogResult dialogResult = MessageBox.Show("Yeni personel eklemek mi yoksa mevcut personeli güncellemek mi istiyorsunuz?", "İşlem Seçimi", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Yeni Personel Başarıyla Eklendi");
                    _app.Add(new Personel { PersonelName = tbxPersonelAdi.Text, PersonelSurname = tbxPersonelSoyadi.Text, PersonelSalary = salary, PersonelBirthDate = dtptbxpersonebirthdate.Value });
                }
                else if (dialogResult == DialogResult.No)
                {
                    int selectedPersonelId;

                    bool parseResult = int.TryParse(dgAdmin.CurrentRow.Cells[0].Value.ToString(), out selectedPersonelId);

                    if (parseResult)
                    {
                        _app.Update(new Personel
                        {
                            PersonelName = tbxPersonelAdi.Text,
                            PersonelSalary = salary,
                            PersonelSurname = tbxPersonelSoyadi.Text,
                            PersonelBirthDate = dtptbxpersonebirthdate.Value,
                            PersonelId = selectedPersonelId
                        });

                        MessageBox.Show("Personel Başarıyla Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Personel güncelleme işlemi için geçerli bir personel seçilmemiş.");
                    }
                }
            }
            else
            {
                tbxpersonelsalary.ForeColor = Color.Red;
            }
            Refresher(_context.Personeller);

        }

        private void btnaddtasitbyadmin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yeni taşıt eklemek mi yoksa mevcut taşıtı güncellemek mi istiyorsunuz?", "İşlem Seçimi", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _app.Add(new Tasit { TasitPlate = tbxtasitplate.Text, TasitType = tbxtasittype.Text });
                MessageBox.Show("Yeni Taşıt Başarıyla Eklendi");
            }
            else if (dialogResult == DialogResult.No)
            {
                int selectedTasitId;

                bool parseResult = int.TryParse(dgAdmin.CurrentRow.Cells["TasitId"].Value.ToString(), out selectedTasitId);

                if (parseResult)
                {
                    _app.Update(new Tasit
                    {
                        TasitId = selectedTasitId,
                        TasitPlate = tbxtasitplate.Text,
                        TasitType = tbxtasittype.Text
                    });

                    MessageBox.Show("Taşıt Başarıyla Güncellendi");
                }
                else
                {
                    MessageBox.Show("Taşıt güncelleme işlemi için geçerli bir taşıt seçilmemiş.");
                }
            }

            Refresher(_context.Tasitlar);
        }


        private void dgAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgAdmin.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dgAdmin.Columns.Count)
            {
                if (dgAdmin.DataSource is List<Personel>)
                {
                    tbxPersonelAdi.Text = dgAdmin.CurrentRow.Cells["PersonelName"].Value.ToString();
                    tbxPersonelSoyadi.Text = dgAdmin.CurrentRow.Cells["PersonelSurname"].Value.ToString();
                    tbxpersonelsalary.Text = dgAdmin.CurrentRow.Cells["PersonelSalary"].Value.ToString();
                    dtptbxpersonebirthdate.Value = (DateTime)dgAdmin.CurrentRow.Cells["PersonelBirthDate"].Value;
                }
                else if (dgAdmin.DataSource is List<Tasit>)
                {
                    tbxtasitplate.Text = dgAdmin.CurrentRow.Cells["TasitPlate"].Value.ToString();
                    tbxtasittype.Text = dgAdmin.CurrentRow.Cells["TasitType"].Value.ToString();
                }
                else if (dgAdmin.DataSource is List<Tur>)
                {
                    turDtpicker.Value = (DateTime)dgAdmin.CurrentRow.Cells["HaraktetTime"].Value;
                    tbxTurKalkisNoktasi.Text = dgAdmin.CurrentRow.Cells["DeparturePoint"].Value.ToString();
                    tbxTurHedefNoktasi.Text = dgAdmin.CurrentRow.Cells["Destination"].Value.ToString();
                }
            }
            else
            {
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dgAdmin.SelectedCells.Count > 0)
            {
                if (dgAdmin.DataSource is List<Tur>)
                {
                    int selectedTurId = (int)dgAdmin.CurrentRow.Cells["TurId"].Value;
                    _app.Delete(new Tur { TurId = selectedTurId });
                    Refresher(_context.Turlar);
                }
                else if (dgAdmin.DataSource is List<Personel>)
                {
                    int selectedPersonelId = (int)dgAdmin.CurrentRow.Cells["PersonelId"].Value;
                    _app.Delete(new Personel { PersonelId = selectedPersonelId });
                    Refresher(_context.Personeller);
                }
                else if (dgAdmin.DataSource is List<Tasit>)
                {
                    int selectedTasitId = (int)dgAdmin.CurrentRow.Cells["TasitId"].Value;
                    _app.Delete(new Tasit { TasitId = selectedTasitId });
                    Refresher(_context.Tasitlar);
                }
                else if (dgAdmin.DataSource is List<Bilet>)
                {
                    int selectedBiletId = (int)dgAdmin.CurrentRow.Cells["Id"].Value;
                    _app.Delete(new Bilet { Id = selectedBiletId });
                    Refresher(_context.Biletler);
                }
                else if (dgAdmin.DataSource is List<Musteri>)
                {
                    int selectedMusteriId = (int)dgAdmin.CurrentRow.Cells["MusteriId"].Value;
                    _app.Delete(new Musteri { MusteriId = selectedMusteriId });
                    Refresher(_context.Musteriler);
                }
                else
                {
                    MessageBox.Show("Silmek için uygun bir veri kaynağı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir satır seçmelisiniz.");
            }
        }

    }
}

