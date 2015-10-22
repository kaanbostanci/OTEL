using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OtelResepsiyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
     

       

        OtelModelDataContextDataContext db = new OtelModelDataContextDataContext();

        private void fiyatButton_Click(object sender, EventArgs e)
        {
            this.Hesapla(girisPicker.Value, cikisPicker.Value,tipComboBox.Text,paketComboBox.Text);
            MessageBox.Show("Hesaplama Yapıldı");

            
        }

        private void Hesapla(DateTime girisTarih, DateTime cikisTarih, string tip, string paket)
        {
            Oda oda =new Oda();
            double ucret;

            System.TimeSpan zaman;
            zaman = cikisTarih.Subtract(girisTarih);
            int toplamgun = Convert.ToInt32(zaman.TotalDays);

            double toplam;

            if (tip== "Tek Kişilik" && paket == "hersey dahil")
            {
                  ucret=250;
                  toplam = toplamgun * ucret;
                  fiyat.Text = Convert.ToString(toplam);
                  fiyat.Visible = true;

            }
            if (tip == "Tek Kişilik" && paket == "tam pansiyon")
            {
                 ucret = 150;
                 toplam = toplamgun* ucret;
                 fiyat.Text = Convert.ToString(toplam);
                 fiyat.Visible= true;

            }
            if (tip== "Çift Kişilik" && paket == "hersey dahil")
            {
                ucret = 400;
                toplam =toplamgun* ucret;
                fiyat.Text = Convert.ToString(toplam);
                fiyat.Visible = true;

            }
            if (tip == "Çift Kişilik" && paket == "tam pansiyon")
            {
                 ucret = 250;
                 toplam = toplamgun * ucret;
                 fiyat.Text = Convert.ToString(toplam);
                 fiyat.Visible = true;

            }
            if (tip == "Kral Dairesi" && paket == "hersey dahil")
            {
                 ucret = 900;
                 toplam = toplamgun * ucret;
                 fiyat.Visible = true;
                 fiyat.Text = Convert.ToString(toplam);
            }
            else
            {
                MessageBox.Show("Yanlış Seçim");
            }



            
           


           
        }



        private void rezervButton_Click(object sender, EventArgs e)
        {
            this.RezervasyonYap(adTextBox.Text, soyadTextBox.Text,Convert.ToInt32(telefonTextBox.Text),girisPicker.Value,cikisPicker.Value,tipComboBox.Text,paketComboBox.Text);
            MessageBox.Show("Rezervasyonunuz Alınmıştır");
           
         
            adTextBox.Clear();
            soyadTextBox.Clear();
            telefonTextBox.Clear();
        }

        private bool RezervasyonYap(string ad, string soyad ,int tel , DateTime girisTarih, DateTime cikisTarih,string tip , string paket)
        {
            Rezervasyon rezerv = new Rezervasyon();
            Musteri musteri = new Musteri();
            Oda oda = new Oda();

            musteri.Ad = ad;
            musteri.Soyad = soyad;
            musteri.telefon = tel;
            rezerv.girisTarih = girisTarih;
            rezerv.cikisTarih = cikisTarih;
            
            rezerv.RezervasyonTarih = DateTime.Today;
            
            db.Musteris.InsertOnSubmit(musteri);
            rezerv.Musteri = musteri;
            db.Rezervasyons.InsertOnSubmit(rezerv);
            db.SubmitChanges();
            

            return true;
        }




        private void Form3_Load(object sender, EventArgs e) {
            var properties = (from t in db.Odas  //combobox a oda tiplerini eklemek icin
                             select t.odaTip).Distinct().ToList();
           
           tipComboBox.Items.Add(properties[0]);
           tipComboBox.Items.Add(properties[1]);
           tipComboBox.Items.Add(properties[2]);

           var pakets = (from t in db.Odas select t.Paket.paketOzellik).Distinct().ToList(); //combobox a paket özelliklerini ekler

           paketComboBox.Items.Add(pakets[0]);
           paketComboBox.Items.Add(pakets[1]);
          

            }
           
           
        }
      

      

       
    }

