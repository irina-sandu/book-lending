using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    [Serializable]
    public class Cititor
    {
        public int id;
        public string nume;
        public string prenume;
        public string telefon;
        public string email;
        public Cititor()
        {

        }
        public Cititor(int _id, string _nume, string _prenume, string _telefon, string _email)
        {
            id = _id;
            nume = _nume;
            prenume = _prenume;
            telefon = _telefon;
            email = _email;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public string Telefon
        {
            get { return telefon; }
            set { if(value.Length==10) telefon = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
