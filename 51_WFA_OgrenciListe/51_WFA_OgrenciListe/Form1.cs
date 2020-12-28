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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Adding properties to the class and creating a list
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
        //Creating random number
        Random rng = new Random();
        int i;

        //EVENTS
        int timer;
        private void Form1_Load(object sender, EventArgs e)
        {
            ListeyeOgrenciEkle();
        }
        private void button1_Click(object sender, EventArgs e)
        {          
            OgrenciSec();                      
        }
        //METHODS
        void ListeyeOgrenciEkle()
        {
            foreach (Ogrenci ogrenci in ogrenciListe)
            {
                lbOgrenciListesi.Items.Add(ogrenci.Ad + " " + ogrenci.Soyad);
            }


        }        
        void OgrenciSec()
        {
            timer = 1;
            i = rng.Next(0, lbOgrenciListesi.Items.Count);

            if (timer == 1)
            {
                if (lbOgrenciListesi.Items.Count > 0)
                {
                    DialogResult result = MessageBox.Show(lbOgrenciListesi.Items[i].ToString(), "Seçilen Öğrenci", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        timer1.Start();

                    }
                }
                else if (lbOgrenciListesi.Items.Count == 0)
                {
                    MessageBox.Show("Ögrenci kalmadı. Bilemeyenlere bir daha soralım");

                    foreach (string og in lbBilemeyenler.Items)
                    {
                        lbOgrenciListesi.Items.Add(og);
                    }

                    lbBilemeyenler.Items.Clear();
                }
            }
            



        }
        void CevapVer()
        {
            //Creating a listview
            ListViewItem lvi = new ListViewItem();
            DialogResult result1 = MessageBox.Show("Öğrenci soruyu bildimi?", lbOgrenciListesi.Items[i].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (result1 == DialogResult.Yes)
             {
                lbBilenler.Items.Add(lbOgrenciListesi.Items[i]);
                
                timer = 1;
                lbTimer.Text = timer.ToString();

                ogrenciListe[i].Puan += 5;

                lvi.Text = ogrenciListe[i].Ad;
                lvi.SubItems.Add(ogrenciListe[i].Soyad);
                lvi.SubItems.Add(ogrenciListe[i].Puan.ToString());
                listView1.Items.Add(lvi);

                lbOgrenciListesi.Items.Remove(lbOgrenciListesi.Items[i]);
                ogrenciListe.Remove(ogrenciListe[i]);



             }
             else 
             {
                lbBilemeyenler.Items.Add(lbOgrenciListesi.Items[i]);
                
                timer = 1;
                lbTimer.Text = timer.ToString();

                ogrenciListe[i].Puan -= 5;

                lvi.Text = ogrenciListe[i].Ad;
                lvi.SubItems.Add(ogrenciListe[i].Soyad);
                lvi.SubItems.Add(ogrenciListe[i].Puan.ToString());
                listView1.Items.Add(lvi);

                lbOgrenciListesi.Items.Remove(lbOgrenciListesi.Items[i]);
                ogrenciListe.Remove(ogrenciListe[i]);
            }
           
        }
     


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer--;
            lbTimer.Text = timer.ToString();

            if(timer == 0)
            {
                timer1.Stop();
                CevapVer();
            }
        }
    }
}


//Eger bir class'ın icersindeki property'leri loop ile doldurmaya calisiyorsak, listemiz class'in icersinde tanımlanamaz. Cunku loop icersinde class'i her cagirdigimizda icindeki listede yeniden olusacak

//Ozet: listeyi nereye koydugunuza dikkat edin