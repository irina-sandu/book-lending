using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace proiect
{
    public partial class FormCititor : Form
    {
        public Form1 parinte;
        public Cititor cititor;
        public FormCititor()
        {
            InitializeComponent();
        }

        private void b_add_cititor_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(new string[] { textBoxId.Text,textBoxNume.Text,textBoxPrenume.Text,textBoxTelefon.Text,textBoxEmail.Text});
            Cititor c = new Cititor();
            c.Id =Convert.ToInt32(textBoxId.Text);
            c.Nume = textBoxNume.Text;
            c.Prenume = textBoxPrenume.Text;
            c.Telefon = textBoxTelefon.Text;
            c.Email = textBoxEmail.Text;
            this.parinte.AddCititor(lv,c);
        }
        public void Actualizeaza(object sender, EventArgs e)
        {
            ListView lista1 = (ListView)sender;
            cititor = null;
            if (lista1.SelectedItems.Count > 0)
                cititor = (Cititor)lista1.SelectedItems[0].Tag;
            if (cititor != null)
            {
                textBoxId.Text = cititor.Id.ToString();
                textBoxNume.Text = cititor.Nume;
                textBoxPrenume.Text = cititor.Prenume;
                textBoxTelefon.Text = cititor.Telefon;
                textBoxEmail.Text = cititor.Email;
            }
        }
        private void FormCititor_Load(object sender, EventArgs e)
        {

        }

        private void buttonModifCit_Click(object sender, EventArgs e)
        {
            if (cititor != null)
            {
                cititor.Id = Convert.ToInt32(textBoxId.Text);
                cititor.Nume=textBoxNume.Text;
                cititor.Prenume=textBoxPrenume.Text;
                cititor.Telefon=textBoxTelefon.Text;
                cititor.Email=textBoxEmail.Text;
            }
            this.parinte.UpdateCititori();
        }

        private void textBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTelefon.Text.Length !=10)
            {
                errorProvider1.SetError(textBoxTelefon, "Nr. de telefon nu este corect");
                e.Cancel = true;
            }
        }

        private void textBoxTelefon_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxTelefon,"");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex mRegxExpression;
            if (textBoxEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBoxEmail.Text.Trim()))
                {
                    errorProvider1.SetError(textBoxEmail, "Email nevalid");
                    e.Cancel = true;
                }
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(textBoxEmail, "");
        }
    }
}
