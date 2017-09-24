using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Państwa_miasta
{
    public partial class Panstwamiasta : Form
    {
        public Panstwamiasta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rules = new rules();
            rules.Show();
           
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dariusz Ghaemi 2017");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            literka_label.Text = "X";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "WERTUIOPASDFGHJKLZCVBNM".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 1; i++)
            { 
                randomString += letters[r.Next(0, 23)].ToString();
            }
            string a;
            a = literka_label.Text;
            literka_label.Text = randomString;
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label2.Text = "Czas gry:" + i.ToString() + " s";
        }
    }
}
