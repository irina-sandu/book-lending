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
    
    public partial class FormImprumut : Form
    {
        public Form1 parinte;
        public Imprumut imprumut;
        public FormImprumut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(new string[] { textBoxCititor.Text, textBoxCarte.Text, dateTimePicker.Text });
            this.parinte.AddImprumut(lv);
        }

        private void FormImprumut_Load(object sender, EventArgs e)
        {
      
            
        }

        private void buttonModifImpr_Click(object sender, EventArgs e)
        { 
        }

    }
}
