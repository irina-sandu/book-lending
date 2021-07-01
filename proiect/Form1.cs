using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //lista de cititori

            Cititor c1 = new Cititor(1, "Popescu", "George", "0769648326", "popescuG@stud.ase.ro"), c2 = new Cititor(2, "Cozma", "Mihaela", "0746315248", "cozmaM@stud.ase.ro"),
                    c3 = new Cititor(3, "Munteanu", "Andreea", "0759431625", "munteanuA@stud.ase.ro"), c4 = new Cititor(4, "Stan", "Mihai", "0768431547", "stanM@stud.ase.ro"),
                    c5 = new Cititor(5, "Georgescu", "Elena", "0741238469", "georgescuE@stud.ase.ro"), c6 = new Cititor(6, "Iftodi", "Marian", "0747898469", "idtodiM@stud.ase.ro");

            ListViewItem l_cit1 = new ListViewItem(new string[] { c1.Id.ToString(), c1.Nume, c1.Prenume, c1.Telefon, c1.Email });
            l_cit1.Tag = c1;

            ListViewItem l_cit2 = new ListViewItem(new string[] { c2.Id.ToString(), c2.Nume, c2.Prenume, c2.Telefon, c2.Email });
            l_cit2.Tag = c2;

            ListViewItem l_cit3 = new ListViewItem(new string[] { c3.Id.ToString(), c3.Nume, c3.Prenume, c3.Telefon, c3.Email });
            l_cit3.Tag = c3;

            ListViewItem l_cit4 = new ListViewItem(new string[] { c4.Id.ToString(), c4.Nume, c4.Prenume, c4.Telefon, c4.Email });
            l_cit4.Tag = c4;

            ListViewItem l_cit5 = new ListViewItem(new string[] { c5.Id.ToString(), c5.Nume, c5.Prenume, c5.Telefon, c5.Email });
            l_cit5.Tag = c5;

            ListViewItem l_cit6 = new ListViewItem(new string[] { c6.Id.ToString(), c6.Nume, c6.Prenume, c6.Telefon, c6.Email });
            l_cit6.Tag = c6;

            l_cit.Items.Add(l_cit1); l_cit.Items.Add(l_cit2);
            l_cit.Items.Add(l_cit3); l_cit.Items.Add(l_cit4);
            l_cit.Items.Add(l_cit5); l_cit.Items.Add(l_cit6);

            //treeview pt carti
            Carte b1 = new Carte(1, "Eseu despre orbire", "Jose Saramago", "Fictiune", "Eseu despre orbire este un roman cutremurator, o marturie a neincrederii autorului in societatea contemporana, incapabila sa-si gestioneze si sa-si rezolve crizele.\n Intr-un oras anonim, populat de personaje fara nume, izbucneste o boala ingrozitoare ce provoaca orbirea.\n Fara o cauza aparenta, in afara de cea morala, oamenii isi pierd, unul cate unul, vederea si barbaria se dezlantuie.\n Unica reactie a politicienilor este represiunea, urmata in curand de aparitia lagarelor.\n Din motive necunoscute, o singura persoana scapa de flagel - sotia unui medic, cea care ii va conduce pe oameni spre lumina.", 2), b2 = new Carte(2, "Kafka pe malul marii", "Haruki Murakami", " Fictiune", "Romanul, publicat in 2002 si intrat imediat pe lista bestsellerurilor, este relatarea plina de fantezie a aventurilor unui adolescent care pleaca de acasa in cautarea mamei si a surorii disparute cu mult timp in urma \nsi a sirului de coincidente care-l leaga de un vagabond pe nume Nakata, ce sufera de pe urma unei traume din timpul razboiului. \nAtractia irezistibila dintre aceste doua personaje care par sa nu aiba nimic in comun nu este singurul detaliu inexplicabil din cuprinsul romanului: in universul construit de Murakami pisicile vorbesc, pestii cad din cer, iar spiritele isi parasesc trupul, minate de nevoia de dragoste sau de sange.\n Descrisa de Kirkus Review ca o „capodopera demna de un Nobel“, cartea confirma pe deplin reputatia de povestitor neintrecut a scriitorului japonez.", 1),
                  b3 = new Carte(3, "O mie noua sute optzeci si patru", "George Orwell", "Fictiune", "Winston Smith este un personaj obisnuit: el uraste, iubeste si munceste ca oricare alt om.\n Ceea ce-l face deosebit este faptul ca traieste intr-o lume infernala, in care a uri, a iubi sau a munci sint ginduri venite dintr-un efort supraomenesc al fiecarei clipe.\nRomanul O mie noua sute optzeci si patru descrie tabloul apocaliptic al unei Londre din era postatomica, locul de nastere al unui regim totalitar in care orice logica pare sa fi fost abolita.\nExecutiile fara rost, disparitiile peste noapte au devenit firesti.\nTrecutul este rescris mereu pentru a legitima crimele prezentului, iar instrumentul propagandei este odioasa „neolimba”, o limba robotizata, ce completeaza imaginea de lume ordonata „stiintific” dupa vointa Fratelui cel Mare, care spune ca „razboiul este pace, libertatea este sclavie, ignoranta este putere”.", 0), b4 = new Carte(4, "Arhitectura lumii. Capodoperele", "Will Pryce", "Ce contribuie la maretia unei cladiri? Iata o intrebare care i-a preocupat de secole in egala masura pe arhitecti, critici si calatori.\n Raspunsurile se regasesc in cartea lui Will Pryce, Arhitectura lumii. \nCapodoperele, un studiu complet ilustrat, cu fotografii inedite, realizate de autor, si detalii speciale, care pun in valoare unicitatea fiecarei cladiri.\nO exceptionala enciclopedie de arhitectura, aceasta carte - cadou dezvaluie o lume a frumusetii si a ingeniozitatii.Peste 350 de fotografii il insotesc pe cititor intr - o calatorie grandioasa printre capodoperele arhitecturale apartinand a peste doua milenii de civilizatie: Hagia Sofia, catedralele gotice si renascentiste ale Europei, capodoperele islamice din Iran, Fortul Agra si Taj Mahal, Palatul Westminster din Londra, capela lui Le Corbusier construita pentru Catedrala Notre Dame du Haut din Ronchamp si celebrul Muzeu Guggenheim din Bilbao proiectat de Gehry.", "Arta, arhitectura si fotografie", 1),
                  b5 = new Carte(5, "Bohemian Rhapsody - Adevarata biografie a lui Freddie Mercury", "Lesley Ann Jones", "Biografii si memorii", "Aceasta este biografia uneia dintre cele mai faimoase si iubite stele din istoria muzicii moderne: Freddie Mercury, scrisa de o jurnalista de muzica rock premiata si apropiata de formatia Queen.Cu o cercetare meticuloasa, empatica si fara alunecari spre senzational, cartea se bazeaza pe marturiile celor mai apropiati oameni din viata starului rock, din copilarie si pana la moarte, cu accent pe perioada anilor 1980, cand formatia incepuse sa se destrame, inainte de spectacolul de la Live Aid care i - a repus pe picioare.", 2), b6 = new Carte(6, "O autobiografie", "Agatha Christie", "Biografii si memorii", "Publicata in 1977, la un an dupa moartea autoarei, O autobiografie te tine cu sufletul la gura asemenea romanelor ei. Scrise cu verva, umorul si nonsalanta bine-cunoscute, franturile de amintiri pe care Agatha Christie alege sa le dezvaluie cititorului - sugerand chiar din titlu ca aceasta este o naratiune foarte personala, nu Autobiografia cu majuscula - sunt deopotriva semnificative pentru memoria afectiva a scriitoarei, cat si pentru epoca pe care a trait-o, o perioada framantata din istoria lumii, de la sfarsitul epocii victoriene, cand lumea parea sa aiba rabdare, la cele doua razboaie mondiale si apoi la deplina maturitate si implinire ca scriitoare din anii postbelici.", 0),
                  b7 = new Carte(7, "Istoria Evului Mediu", "Georges Minois", " Istorie", "O sinteza istorica de referinta care deconstruieste imaginea colectiva despre Evul Mediu. De ce o noua istorie a Evului Mediu? Pentru ca e o perioada care fascineaza si intriga, pentru ca acolo sunt radacinile aspiratiilor si dramelor noastre actuale, de la obscurantismul religios la aspiratiile spirituale, de la violenta colectiva pana la cautarea unui sens inalt al vietii, de la frica de viitor pana la visul reintoarcerii la natura.", 1), b8 = new Carte(8, "Limba germana. Simplu si eficient", "Orlando Balas", " Limbi straine", "Destinata deopotriva elevilor, studentilor si autodidactilor, Limba germana. Simplu si eficient prezinta intr-un limbaj accesibil si intr-o succesiune logica principalele elemente de gramatica germana, pe care le ilustreaza cu numeroase exemple din vorbirea de zi cu zi si cu exercitii utile pentru fixarea notiunilor invatate.", 2), b9 = new Carte(9, "Limba chineza. Simplu si eficient", "Claude Renucci, Li Xiaohan", "Limbi straine", "Dialoguri: 20 de texte care va familiarizeza cu limba vorbita moderna si cultura chineza, rubrici speciale de vocabular care va ajuta sa memorati cuvintele si expresiile din texte, 60 de activitati orale pentru a invata pronuntia sunetelor si cadenta frazelor. Gramatica:explicatii simple ilustrate cu exemple,exercitii pe care le puteti rezolva direct pe carte", 0);
            List<Carte> carti = new List<Carte>();
            carti.Add(b1); carti.Add(b2); carti.Add(b3); carti.Add(b4); carti.Add(b5); carti.Add(b6); carti.Add(b7); carti.Add(b8); carti.Add(b9);

            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\dot.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\saramago.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\murakami.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\orwell.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\arhitectura.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\freddie.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\agatha.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\evul.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\germana.jpg"));
            imagini.Images.Add(Image.FromFile("C:\\Users\\irina\\Desktop\\images\\chineza.jpg"));
            
            t_carti.ImageList = imagini;
           

            int i = 1;
            foreach (Carte b in carti)
            {
                TreeNode t1 = t_carti.Nodes.Add(b.Titlu);
                t1.ImageIndex = i;
                t1.SelectedImageIndex = i;
                t1.Nodes.Add("Autor: " + b.Autor);
                t1.Nodes.Add("Categorie: " + b.Categorie);
                t1.Nodes.Add("Descriere:\n" + b.descriere);
                t1.Nodes.Add("Stoc: " + b.stoc);
                i++;
                t1.Tag = b;
            }
        }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void t_carti_MouseDown(object sender, MouseEventArgs e)
        {
            if(t_carti.SelectedNode != null)
            {
                t_carti.DoDragDrop(t_carti.SelectedNode, DragDropEffects.Copy);

            }
        }

        private void l_cit_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void l_cit_DragDrop(object sender, DragEventArgs e)
        {
            Point px = new Point(l_cit.PointToClient(new Point(e.X, e.Y)).X, l_cit.PointToClient(new Point(e.X, e.Y)).Y);
            ListViewItem lv = l_cit.GetItemAt(px.X,px.Y);
            Carte c = (Carte)((TreeNode)e.Data.GetData(typeof(TreeNode))).Tag;
            if(lv!=null)
            {
                Imprumut impr = new Imprumut((Cititor)lv.Tag, c, DateTime.Now);
                ListViewItem l_impr = new ListViewItem(new string[] { impr.Cititor.Nume + " " + impr.Cititor.Prenume, impr.Carte.Titlu, impr.Data.ToString(), impr.Intarziat.ToString() });
                l_imprumut.Items.Add(l_impr);
                l_impr.Tag = impr;
                c.Stoc--;
                UpdateCarti();
                //UpdateImprumut();
            }
        }

        private void b_add_imp_Click(object sender, EventArgs e)
        {
            FormImprumut fm = new FormImprumut();
            fm.parinte = this;
            fm.Show();
        }
        
        public void AddImprumut(ListViewItem lv)
        {
            l_imprumut.Items.Add(lv);
            l_imprumut.Tag = lv;
        }
        
        private void b_add_carte_Click(object sender, EventArgs e)
        {
            FormCarte fm = new FormCarte();
            fm.parinte = this;
            fm.Show();
        }
        public void AddCarte(Carte b)
        {
            TreeNode t1 = t_carti.Nodes.Add(b.Titlu);
            t1.Nodes.Add("Autor: " + b.Autor);
            t1.Nodes.Add("Categorie: " + b.Categorie);
            t1.Nodes.Add("Descriere:\n" + b.descriere);
            t1.Nodes.Add("Stoc: " + b.stoc);
            t1.Tag = b;
        }

        private void b_add_cititor_Click(object sender, EventArgs e)
        {
            FormCititor fm = new FormCititor();
            fm.parinte = this;
            fm.Show();
        }
        public void AddCititor(ListViewItem lv,Cititor c)
        { 
            l_cit.Items.Add(lv);
            lv.Tag = c;
            UpdateCititori();
        }

        private void toolStripMenuItemModifCit_Click(object sender, EventArgs e)
        {
            FormCititor fm = new FormCititor();
            fm.parinte = this;
            l_cit.SelectedIndexChanged += new EventHandler(fm.Actualizeaza);
            fm.Actualizeaza(this.l_cit, e);
            fm.Show();
        }
        public void UpdateCititori()
        {
            foreach (ListViewItem lvi in l_cit.Items)
            {
                Cititor c = (Cititor) lvi.Tag;
                lvi.Text = c.Id.ToString();
                lvi.SubItems[1].Text = c.Nume;
                lvi.SubItems[2].Text = c.Prenume;
                lvi.SubItems[3].Text = c.Telefon;
                lvi.SubItems[4].Text = c.Email;
            }
        }
        public void UpdateImprumut()
        {
            foreach (ListViewItem lvi in l_imprumut.Items)
            {
                Imprumut i = (Imprumut)lvi.Tag;
                lvi.Text = i.Cititor.Nume +" "+ i.Cititor.Prenume;
                lvi.SubItems[1].Text = i.Carte.Titlu;
                lvi.SubItems[2].Text = i.Data.ToString();
                lvi.SubItems[3].Text = i.Intarziat.ToString();
            }
        }
        public void UpdateCarti()
        {
            foreach (TreeNode t in t_carti.Nodes)
            {
                Carte c = (Carte)t.Tag;
                t.Text = c.Titlu;
                t.Nodes[0].Text = c.Autor;
                t.Nodes[1].Text = c.Categorie;
                t.Nodes[2].Text = c.Descriere;
                t.Nodes[3].Text = c.Stoc.ToString();

            }
        }
        private void toolStripMenuItemAddCititor_Click(object sender, EventArgs e)
        {
            FormCititor fm = new FormCititor();
            fm.parinte = this;
            fm.Show();
        }

        private void toolStripMenuItemAddCarte_Click(object sender, EventArgs e)
        {
            FormCarte fm = new FormCarte();
            fm.parinte = this;
            fm.Show();
        }

        private void toolStripMenuItemAddImpr_Click(object sender, EventArgs e)
        {
            FormImprumut fm = new FormImprumut();
            fm.parinte = this;
            fm.Show();
        }

        private void toolStripMenuItemModifCarte_Click(object sender, EventArgs e)
        {
            FormCarte fm = new FormCarte();
            fm.parinte = this;
            fm.Actualizeaza(this.t_carti, e);
            fm.Show();
        }

        private void toolStripMenuItemModifImpr_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2StergeCit_Click(object sender, EventArgs e)
        {
            if (l_cit.SelectedItems.Count > 0)
            {
                Cititor c = (Cititor)l_cit.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea cititorului " + c.Nume + " ?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rezultat == DialogResult.Yes) l_cit.SelectedItems[0].Remove();
            }
        }

        private void toolStripMenuItemStergeCarte_Click(object sender, EventArgs e)
        {
            if(t_carti.SelectedNode!= null)
            {
                Carte c = (Carte)t_carti.SelectedNode.Tag;
                DialogResult rezultat= MessageBox.Show("Sunteti sigur ca doriti stergerea cartii " + c.Titlu + " ?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rezultat == DialogResult.Yes) t_carti.SelectedNode.Remove();
            }
        }

        private void toolStripMenuItemStergeImpr_Click(object sender, EventArgs e)
        {
            if (l_imprumut.SelectedItems.Count > 0)
            {
                Imprumut impr = (Imprumut)l_imprumut.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea imrpumutului?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rezultat == DialogResult.Yes) l_imprumut.SelectedItems[0].Remove();
            }
        }

        private void toolStripMenuItemAddCit_Click(object sender, EventArgs e)
        {
            toolStripMenuItemAddCititor_Click(sender, e);
        }

        private void toolStripMenuItemModCit_Click(object sender, EventArgs e)
        {
            toolStripMenuItemModifCit_Click(sender, e);
        }

        private void toolStripMenuItemStergeCit_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2StergeCit_Click(sender, e);
        }

        private void toolStripMenuItemAddCarte2_Click(object sender, EventArgs e)
        {
            toolStripMenuItemAddCarte_Click(sender, e);
        }

        private void toolStripMenuItemModifCarte2_Click(object sender, EventArgs e)
        {
            toolStripMenuItemModifCarte_Click(sender, e);
        }

        private void toolStripMenuItemStergeCarte2_Click(object sender, EventArgs e)
        {
            toolStripMenuItemStergeCarte_Click(sender, e);
        }

        private void toolStripMenuItemImprumuturi_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemAddImpr2_Click(object sender, EventArgs e)
        {
            toolStripMenuItemAddImpr_Click(sender, e);
        }

        private void toolStripMenuItemStergeImpr2_Click(object sender, EventArgs e)
        {
            toolStripMenuItemStergeImpr_Click(sender, e);
        }

        private void contextMenuStripCititori_Opening(object sender, CancelEventArgs e)
        {
            if (l_cit.SelectedItems.Count > 0)
            {
                toolStripMenuItemModCit.Enabled = true;
                toolStripMenuItemStergeCit.Enabled = true;
            }
            else
            {
                toolStripMenuItemModCit.Enabled = false;
                toolStripMenuItemStergeCit.Enabled = false;
            }
        }

        private void contextMenuStripCarte_Opening(object sender, CancelEventArgs e)
        {
            if(t_carti.SelectedNode!=null)
            {
                toolStripMenuItemModifCarte2.Enabled = true;
                toolStripMenuItemStergeCarte2.Enabled = true;
            }
            else
            {
                toolStripMenuItemModifCarte2.Enabled = false;
                toolStripMenuItemStergeCarte2.Enabled = false;
            }
        }

        private void contextMenuStripImprumuturi_Opening(object sender, CancelEventArgs e)
        {
            if (l_cit.SelectedItems.Count > 0)
            {
                toolStripMenuItemStergeImpr2.Enabled = true;
            }
            else
            {
                toolStripMenuItemStergeImpr2.Enabled = false;
            }
        }

        private void toolStripMenuItemSalveaza_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare imprumuturi (*.imprumuturi)|*.imprumuturi";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Imprumut> lista = l_imprumut.Items.Cast<ListViewItem>().Select(item => (Imprumut)item.Tag).ToList();
                serializator.Serialize(fb, lista);
                fb.Close();
            }
        }

        private void toolStripMenuItemRestaureaza_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare imprumuturi (*.imprumuturi)|*.imprumuturi";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.OpenRead(fd.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                List<Imprumut> lista = (List<Imprumut>)deserializator.Deserialize(fb);
                l_imprumut.Items.Clear();
                foreach (Imprumut m in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
                    lvi.Tag = m;
                    l_imprumut.Items.Add(lvi);
                }
                fb.Close();
            }
            UpdateImprumut();
        }

        private void toolStripMenuItemGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic fm = new FormGrafic();
            fm.parinte = this;
            fm.Show();
        }

        private void toolStripMenuItemBazaDate_Click(object sender, EventArgs e)
        {
            FormData fm = new FormData();
            fm.parinte = this;
            fm.Show();
        }

        private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            FormPrint fm = new FormPrint();
            fm.parinte = this;
            fm.Actualizeaza(this.t_carti, e);
            fm.Show();
        }
    }
}
