using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolejkaMikolaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataTextBox.Text = DateTime.Now.Date.ToShortDateString();
            godzinaTextBox.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void dodawaniePacjentaText_Click(object sender, EventArgs e)
        {

        }

        private void osobaPrzedText_Click(object sender, EventArgs e)
        {

        }

        private void osobaTerazText_Click(object sender, EventArgs e)
        {

        }

        private void osobaPoText_Click(object sender, EventArgs e)
        {

        }

        private void dodawaniaPacjentaImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaPrzedImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaTerazImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaPoImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodawaniaPacjentaNazwaBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaPrzedNazwaBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaTerazNazwaBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaPoNazwaBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodawaniaPacjentaDataBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaPrzedDataBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaTerazDataBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void osobaPoDataBadania_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void godzinaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            godzinaTextBox.Text = DateTime.Now.ToString("hh:mm:ss");


        }
    }
}
