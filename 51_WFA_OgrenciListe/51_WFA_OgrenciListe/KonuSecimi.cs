using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51_WFA_OgrenciListe
{
    public partial class KonuSecimi : Form
    {
        public KonuSecimi()
        {
            InitializeComponent();
        }

        List<Ogrenci> ogrenciListe = new List<Ogrenci>()
        {
            new Ogrenci{Ad = "Adem", Soyad = "Kınataş" , Puan = 0},
            new Ogrenci{Ad = "Anıl", Soyad = "Adar" , Puan = 0},
            new Ogrenci{Ad = "Adnan", Soyad = "Cansız" , Puan = 0},
            new Ogrenci{Ad = "Mustafa Can", Soyad = "Telli" , Puan = 0},
            new Ogrenci{Ad = "Selimcan", Soyad = "Çakandemir" , Puan = 0},
            new Ogrenci{Ad = "Ozan", Soyad = "Kurt" , Puan = 0},
            new Ogrenci{Ad = "Dilara", Soyad = "Dönmez" , Puan = 0},
            new Ogrenci{Ad = "Rifka", Soyad = "Razon" , Puan = 0},
            new Ogrenci{Ad = "Berkay", Soyad = "Yıldız" , Puan = 0},
            new Ogrenci{Ad = "Abdullah", Soyad = "Nazırlı" , Puan = 0},
            new Ogrenci{Ad = "Buğra", Soyad = "Yüksel" , Puan = 0},
            new Ogrenci{Ad = "Merve", Soyad = "Sofoğlu" , Puan = 0},
            new Ogrenci{Ad = "Ecem", Soyad = "Naz" , Puan = 0},
            new Ogrenci{Ad = "Harun Reşit", Soyad = "Balcı" , Puan = 0},
            new Ogrenci{Ad = "Deniz", Soyad = "Genç" , Puan = 0}
        };
        List<Konu> konuListesi = new List<Konu>()
        {
            new Konu{KonuIsmi = "Variables"},
            new Konu{KonuIsmi = "Operators"},
            new Konu{KonuIsmi = "Console Applications"},
            new Konu{KonuIsmi = "Windows Form Applications"},
            new Konu{KonuIsmi = "Data Type Converstion"},
            new Konu{KonuIsmi = "Local and Global Areas"},
            new Konu{KonuIsmi = "Error Management"},
            new Konu{KonuIsmi = "Decision Structures"},
            new Konu{KonuIsmi = "Instancing"},
            new Konu{KonuIsmi = "Loops"},
            new Konu{KonuIsmi = "Arrays"},
            new Konu{KonuIsmi = "Loop Keywords"},
            new Konu{KonuIsmi = "Methods"},
            new Konu{KonuIsmi = "Object-Oriented Programming"},
            new Konu{KonuIsmi = "Constructor"},
        };
        Random rng = new Random();
        int i;
        //EVENTS
        private void KonuSecimi_Load(object sender, EventArgs e)
        {
            ListeyeOgrenciEkle();
            ListeyeKonuEkle();            
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            if (lblTarih.Text == "-")
            {
                MessageBox.Show("Önce bir tarih seçiniz");

            }
            else
            {
                OgrenciSec();
                KonuSec();
            }                       
        }
        private void mcTarih_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblTarih.Text = mcTarih.SelectionEnd.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lblKonuIsmi.Text = "";
            lblOgrenciIsmi.Text = "";
            lblTarih.Text = "";
            ListeyeOgrenciEkle();
            ListeyeKonuEkle();

        }
        //METHODS
        void ListeyeOgrenciEkle()
        {
            foreach (Ogrenci ogrenci in ogrenciListe)
            {
                lbOgrenciListesi.Items.Add(ogrenci.Ad + " " + ogrenci.Soyad);
            }

        }
        void ListeyeKonuEkle()
        {
            foreach (Konu konu in konuListesi)
            {
                lbKonuListesi.Items.Add(konu.KonuIsmi);
            }
        }     
        void OgrenciSec()
        {
            i = rng.Next(0, lbOgrenciListesi.Items.Count);            
            if (lbOgrenciListesi.Items.Count > 0)
            {
                lblOgrenciIsmi.Text = lbOgrenciListesi.Items[i].ToString();
                lbOgrenciListesi.Items.Remove(lbOgrenciListesi.Items[i]);
            }            
            else
            {
                MessageBox.Show("Listeleri resetleyin");
            }
        }
        void KonuSec()
        {
            i = rng.Next(0, lbKonuListesi.Items.Count);
            if (lbKonuListesi.Items.Count > 0)
            {
                lblKonuIsmi.Text = lbKonuListesi.Items[i].ToString();
                lbKonuListesi.Items.Remove(lbKonuListesi.Items[i]);
            }
            
        }


    }

}
