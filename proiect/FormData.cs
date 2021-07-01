using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class FormData : Form
    {
        public Form1 parinte;
        public FormData()
        {
            InitializeComponent();
        }

        private void FormData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazadateDataSet.Carti' table. You can move, or remove it, as needed.
            this.cartiTableAdapter.Fill(this.bazadateDataSet.Carti);

        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cartiBindingSource.EndEdit();
                this.cartiTableAdapter.Update(this.bazadateDataSet.Carti);
                MessageBox.Show("Salvare cu succes in baza de date!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ceva nu a mers bine:\n" + ex.Message);
            }
        }
    }
}
