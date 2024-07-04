using ComponentFactory.Krypton.Toolkit;
using System;
using System.Linq;
using System.Windows.Forms;
using Mert9.hafta.Data;
using Mert9.hafta.Entities;
using Mert9.hafta.Models;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Mert9.hafta.Areas.Müsteri
{
    public partial class TourDetails : KryptonForm
    {
        public TourDetails(Tur tur, int userId, int status)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.SizableToolWindow; // Başlık çubuğunu gizler
            title.Text = "Tur Details";
            detail1.Text = "Varis Yeri: " + tur.Destination;
            detail2.Text = "Kalkis Yeri: " + tur.DeparturePoint;
            detail3.Text = "Tarih: " + tur.HaraktetTime.Date.ToString();

            using (DataContext context = new DataContext())
            {
                if (status == 0)
                {
                    var user = context.Musteriler.FirstOrDefault(m => m.MusteriId == userId);
                    detail4.Text = "Sn." + user.MusteriName;
                    detail5.Text = user.Email;

                    // Kullanıcının bilet bilgilerini alın
                    var bilet = context.Biletler.FirstOrDefault(b => b.TurId == tur.TurId && b.MusteriId == userId);
                    if (bilet != null)
                    {
                        detail6.Text = "Bilet Türü: " + bilet.BiletType;
                        detail7.Text = "Bilet Fiyati: " + bilet.BiletPrice + " TL";
                    }
                    else
                    {
                        detail6.Text = "Bilet Türü: Bilinmiyor";
                        detail7.Text = "Bilet Fiyatı: Bilinmiyor";
                    }
                }
                else
                {
                    detail4.Visible = false;
                    detail5.Visible = false;
                    detail6.Visible = false;
                    detail7.Visible = false;
                    kryptonHeader4.Visible = false;
                }
            }
        }

        private void saveAsPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyaları|*.pdf";
            saveFileDialog.Title = "PDF olarak kaydet";
            saveFileDialog.FileName = "TurDetayları.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Belge düzenlenme tarihi
                    Font dateFont = FontFactory.GetFont(FontFactory.HELVETICA, 10f, BaseColor.GRAY);
                    Paragraph date = new Paragraph("Belge Düzenlenme Tarihi: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), dateFont);
                    date.Alignment = Element.ALIGN_RIGHT;
                    pdfDoc.Add(date);

                    // Başlık
                    Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f, BaseColor.BLACK);
                    Paragraph title = new Paragraph("Iyi Bilet Hizli Bilet", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    pdfDoc.Add(new Paragraph(" "));

                    // Tur detayları
                    Font detailFont = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.BLACK);
                    pdfDoc.Add(new Paragraph("Tur Detaylari", titleFont));
                    pdfDoc.Add(new Paragraph(detail1.Text, detailFont));
                    pdfDoc.Add(new Paragraph(detail2.Text, detailFont));
                    pdfDoc.Add(new Paragraph(detail3.Text, detailFont));

                    pdfDoc.Add(new Paragraph(" "));

                    // Bilet detayları 
                    pdfDoc.Add(new Paragraph("Bilet Detaylari", titleFont));
                    pdfDoc.Add(new Paragraph(detail4.Text + " Adina Kesilen Biletin Detayları", detailFont));
                    pdfDoc.Add(new Paragraph("Mail Adresi: " + detail5.Text, detailFont));
                    pdfDoc.Add(new Paragraph(detail6.Text, detailFont));
                    pdfDoc.Add(new Paragraph(detail7.Text, detailFont));

                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Close();
                    writer.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF başarıyla kaydedildi!");
            }
        }
    }
}