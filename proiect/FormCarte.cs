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
    public partial class FormCarte : Form
    {
        public Form1 parinte;
        public Carte carte;
        public FormCarte()
        {
            InitializeComponent();
        }

        private void buttonAddCarte_Click(object sender, EventArgs e)
        {
            Carte c = new Carte();
            c.id = Convert.ToInt32(textBoxID.Text);
            c.titlu = textBoxTitlu.Text;
            c.autor = textBoxAutor.Text;
            c.descriere = textBoxDescriere.Text;
            c.categorie = textBoxCategorie.Text;
            c.stoc = Convert.ToInt32(textBoxStoc.Text);
            this.parinte.AddCarte(c);
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
        private void FormCarte_Load(object sender, EventArgs e)
        {

        }

        private void buttonModifCarte_Click(object sender, EventArgs e)
        {
            if (carte != null)
            {
                carte.Id=Convert.ToInt32(textBoxID.Text);
                carte.Titlu=textBoxTitlu.Text;
                carte.Autor=textBoxAutor.Text;
                carte.Categorie=textBoxCategorie.Text;
                carte.Descriere=textBoxDescriere.Text;
                carte.Stoc=Convert.ToInt32(textBoxStoc.Text);
            }
            this.parinte.UpdateCarti();
        }
    }
}
