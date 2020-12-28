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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void btnOgrenciSecimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnKonuSecimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonuSecimi konu = new KonuSecimi();
            konu.Show();
        }
    }
}
