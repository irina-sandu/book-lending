using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{   [Serializable]
    public class Carte
    {
        public int id;
        public string titlu;
        public string autor;
        public string categorie;
        public string descriere;
        public int stoc;
        public Image img;
        public Carte()
        {

        }
        public Carte(int _id,string _titlu, string _autor,string _categorie, string _descriere, int _stoc)
        {
            id = _id;
            titlu = _titlu;
            autor = _autor;
            categorie = _categorie;
            descriere = _descriere;
            stoc = _stoc;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public string Descriere
        {
            get { return descriere; }
            set { descriere = value; }
        }
        public int Stoc
        {
            get { return stoc; }
            set { stoc = value; }
        }
    }
}
