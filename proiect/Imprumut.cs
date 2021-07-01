using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{   [Serializable]
    public class Imprumut
    {
        public Cititor cititor;
        public Carte carte;
        public DateTime data;
        public bool intarziat;
        public void c_intarziat()
        {
            System.TimeSpan diff = DateTime.Now.Subtract(data);
            if (diff.Days > 30) intarziat = true;
            else intarziat = false;
        }
        public Imprumut()
        {

        }
        public Imprumut(Cititor _cititor, Carte _carte, DateTime _data)
        {
            cititor = _cititor;
            carte = _carte;
            data = _data;
            c_intarziat();
        }
        public Cititor Cititor
        {
            get { return cititor; }
            set { cititor = value; }
        }
        public Carte Carte
        {
            get { return carte; }
            set { carte = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public bool Intarziat
        {
            get { return intarziat; }
            set { intarziat = value; }
        }
    }
}
