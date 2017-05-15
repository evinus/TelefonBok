using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonBok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mängd<Person> personLista = new Mängd<Person>();

        private void läggTillPerson_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            int nummer = int.Parse(tbxNummer.Text);
            Person person = new Person(namn, nummer);
            personLista.LäggTill(person);
            uppdatera();
        }

        private void btntabortNa_Click(object sender, EventArgs e)
        {
            for(int i =0;i<personLista.Antal;i++)
            {
                if (personLista[i].Namn == tbxNamn.Text) personLista.TaBort(i);       
            }
            uppdatera();
        }

        private void btnTabortNr_Click(object sender, EventArgs e)
        {

        }
        void uppdatera()
        {
            tbxLista.Clear();
            for(int i=0;i<personLista.Antal;i++)
            {
                tbxLista.AppendText(personLista[i].Namn + ": " + personLista[i].TelefonNummer.ToString() + "\n");
            }
        }

        private void btnSökNamn_Click(object sender, EventArgs e)
        {
            tbxLista.Clear();
            for (int i = 0; i < personLista.Antal; i++)
            {
                if (personLista[i].Namn.Contains(tbxNamn.Text))
                {
                    tbxLista.AppendText(personLista[i].Namn + ": " + personLista[i].TelefonNummer.ToString() + "\n");
                }
            }
        }

        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            uppdatera();
        }

        private void btnSökNr_Click(object sender, EventArgs e)
        {
            tbxLista.Clear();
            for (int i = 0; i < personLista.Antal; i++)
            {
                if (personLista[i].TelefonNummer.ToString().Contains(tbxNummer.Text))
                {
                    tbxLista.AppendText(personLista[i].Namn + ": " + personLista[i].TelefonNummer.ToString() + "\n");
                }
            }
        }
    }
}
