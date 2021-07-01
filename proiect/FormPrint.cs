using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class FormPrint : Form
    {
        public Form1 parinte;
        public Carte carte;
        public FormPrint()
        {
            InitializeComponent();
        }
        public void Actualizeaza(object sender, EventArgs e)
        {
            TreeView t = (TreeView)sender;
            TreeNode t1 = t.SelectedNode;
            carte = null;
            if (t1.IsSelected)
                carte = (Carte)t1.Tag;
            if (carte != null)
            {
                textBoxID.Text = carte.Id.ToString();
                textBoxTitlu.Text = carte.Titlu;
                textBoxAutor.Text = carte.Autor;
                textBoxCategorie.Text = carte.Categorie;
                textBoxDescriere.Text = carte.Descriere;
                textBoxStoc.Text = carte.Stoc.ToString();
            }
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            
        }
        Bitmap bmp;
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(bmp);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
