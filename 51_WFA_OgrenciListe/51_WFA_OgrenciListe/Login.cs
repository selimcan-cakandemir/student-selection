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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.ToLower();
            string sifre = txtSifre.Text.ToLower();
            string mesaj = "";

            switch (kullaniciAdi)
            {
                case "selimcan":
                    switch (sifre)
                    {
                        case "1234":
                            mesaj = "Giriş yapılıyor";
                            this.Hide();
                            Select select = new Select();
                            select.Show();
                            break;
                        default:
                            mesaj = "Kullanıcı adı doğru ama şifre yanlış";
                            break;
                    }
                    break;
                default:
                    mesaj = "Kullanıcı adı yanlış";
                    break;

            }
            MessageBox.Show(mesaj);
        }


    }
}
