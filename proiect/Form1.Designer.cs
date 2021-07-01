
namespace proiect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_cit = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripCititori = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddCit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModCit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergeCit = new System.Windows.Forms.ToolStripMenuItem();
            this.t_carti = new System.Windows.Forms.TreeView();
            this.contextMenuStripCarte = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddCarte2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModifCarte2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergeCarte2 = new System.Windows.Forms.ToolStripMenuItem();
            this.imagini = new System.Windows.Forms.ImageList(this.components);
            this.l_imprumut = new System.Windows.Forms.ListView();
            this.columnHeaderCititor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCarte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIntarziat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripImprumuturi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddImpr2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergeImpr2 = new System.Windows.Forms.ToolStripMenuItem();
            this.b_add_imp = new System.Windows.Forms.Button();
            this.b_add_carte = new System.Windows.Forms.Button();
            this.b_add_cititor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFisiere = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSalveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRestaureaza = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCititori = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddCititor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModifCit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2StergeCit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCarti = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddCarte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModifCarte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergeCarte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImprumuturi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddImpr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergeImpr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGrafic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBazaDate = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCititori.SuspendLayout();
            this.contextMenuStripCarte.SuspendLayout();
            this.contextMenuStripImprumuturi.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_cit
            // 
            this.l_cit.AllowDrop = true;
            this.l_cit.BackColor = System.Drawing.Color.Goldenrod;
            this.l_cit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderTelefon,
            this.columnHeaderEmail});
            this.l_cit.ContextMenuStrip = this.contextMenuStripCititori;
            this.l_cit.FullRowSelect = true;
            this.l_cit.GridLines = true;
            this.l_cit.HideSelection = false;
            this.l_cit.Location = new System.Drawing.Point(543, 34);
            this.l_cit.Name = "l_cit";
            this.l_cit.Size = new System.Drawing.Size(505, 269);
            this.l_cit.TabIndex = 0;
            this.l_cit.UseCompatibleStateImageBehavior = false;
            this.l_cit.View = System.Windows.Forms.View.Details;
            this.l_cit.DragDrop += new System.Windows.Forms.DragEventHandler(this.l_cit_DragDrop);
            this.l_cit.DragEnter += new System.Windows.Forms.DragEventHandler(this.l_cit_DragEnter);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 40;
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 80;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            this.columnHeaderPrenume.Width = 80;
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            this.columnHeaderTelefon.Width = 80;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 140;
            // 
            // contextMenuStripCititori
            // 
            this.contextMenuStripCititori.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.contextMenuStripCititori.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddCit,
            this.toolStripMenuItemModCit,
            this.toolStripMenuItemStergeCit});
            this.contextMenuStripCititori.Name = "contextMenuStripCititori";
            this.contextMenuStripCititori.Size = new System.Drawing.Size(141, 82);
            this.contextMenuStripCititori.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCititori_Opening);
            // 
            // toolStripMenuItemAddCit
            // 
            this.toolStripMenuItemAddCit.Name = "toolStripMenuItemAddCit";
            this.toolStripMenuItemAddCit.Size = new System.Drawing.Size(140, 26);
            this.toolStripMenuItemAddCit.Text = "Adauga";
            this.toolStripMenuItemAddCit.Click += new System.EventHandler(this.toolStripMenuItemAddCit_Click);
            // 
            // toolStripMenuItemModCit
            // 
            this.toolStripMenuItemModCit.Name = "toolStripMenuItemModCit";
            this.toolStripMenuItemModCit.Size = new System.Drawing.Size(140, 26);
            this.toolStripMenuItemModCit.Text = "Modifica";
            this.toolStripMenuItemModCit.Click += new System.EventHandler(this.toolStripMenuItemModCit_Click);
            // 
            // toolStripMenuItemStergeCit
            // 
            this.toolStripMenuItemStergeCit.Name = "toolStripMenuItemStergeCit";
            this.toolStripMenuItemStergeCit.Size = new System.Drawing.Size(140, 26);
            this.toolStripMenuItemStergeCit.Text = "Sterge";
            this.toolStripMenuItemStergeCit.Click += new System.EventHandler(this.toolStripMenuItemStergeCit_Click);
            // 
            // t_carti
            // 
            this.t_carti.BackColor = System.Drawing.Color.Khaki;
            this.t_carti.ContextMenuStrip = this.contextMenuStripCarte;
            this.t_carti.ImageIndex = 0;
            this.t_carti.ImageList = this.imagini;
            this.t_carti.Location = new System.Drawing.Point(12, 34);
            this.t_carti.Name = "t_carti";
            this.t_carti.SelectedImageIndex = 0;
            this.t_carti.Size = new System.Drawing.Size(485, 506);
            this.t_carti.TabIndex = 2;
            this.t_carti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.t_carti_MouseDown);
            // 
            // contextMenuStripCarte
            // 
            this.contextMenuStripCarte.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.contextMenuStripCarte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddCarte2,
            this.toolStripMenuItemModifCarte2,
            this.toolStripMenuItemStergeCarte2});
            this.contextMenuStripCarte.Name = "contextMenuStripCarte";
            this.contextMenuStripCarte.Size = new System.Drawing.Size(166, 82);
            this.contextMenuStripCarte.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCarte_Opening);
            // 
            // toolStripMenuItemAddCarte2
            // 
            this.toolStripMenuItemAddCarte2.Name = "toolStripMenuItemAddCarte2";
            this.toolStripMenuItemAddCarte2.Size = new System.Drawing.Size(165, 26);
            this.toolStripMenuItemAddCarte2.Text = "Adauga";
            this.toolStripMenuItemAddCarte2.Click += new System.EventHandler(this.toolStripMenuItemAddCarte2_Click);
            // 
            // toolStripMenuItemModifCarte2
            // 
            this.toolStripMenuItemModifCarte2.Name = "toolStripMenuItemModifCarte2";
            this.toolStripMenuItemModifCarte2.Size = new System.Drawing.Size(165, 26);
            this.toolStripMenuItemModifCarte2.Text = "Actualizeaza";
            this.toolStripMenuItemModifCarte2.Click += new System.EventHandler(this.toolStripMenuItemModifCarte2_Click);
            // 
            // toolStripMenuItemStergeCarte2
            // 
            this.toolStripMenuItemStergeCarte2.Name = "toolStripMenuItemStergeCarte2";
            this.toolStripMenuItemStergeCarte2.Size = new System.Drawing.Size(165, 26);
            this.toolStripMenuItemStergeCarte2.Text = "Sterge";
            this.toolStripMenuItemStergeCarte2.Click += new System.EventHandler(this.toolStripMenuItemStergeCarte2_Click);
            // 
            // imagini
            // 
            this.imagini.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagini.ImageSize = new System.Drawing.Size(50, 80);
            this.imagini.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // l_imprumut
            // 
            this.l_imprumut.BackColor = System.Drawing.Color.YellowGreen;
            this.l_imprumut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCititor,
            this.columnHeaderCarte,
            this.columnHeaderData,
            this.columnHeaderIntarziat});
            this.l_imprumut.ContextMenuStrip = this.contextMenuStripImprumuturi;
            this.l_imprumut.FullRowSelect = true;
            this.l_imprumut.HideSelection = false;
            this.l_imprumut.Location = new System.Drawing.Point(543, 322);
            this.l_imprumut.Name = "l_imprumut";
            this.l_imprumut.Size = new System.Drawing.Size(505, 153);
            this.l_imprumut.TabIndex = 2;
            this.l_imprumut.UseCompatibleStateImageBehavior = false;
            this.l_imprumut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCititor
            // 
            this.columnHeaderCititor.Text = "Cititor";
            this.columnHeaderCititor.Width = 110;
            // 
            // columnHeaderCarte
            // 
            this.columnHeaderCarte.Text = "Carte";
            this.columnHeaderCarte.Width = 120;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 120;
            // 
            // columnHeaderIntarziat
            // 
            this.columnHeaderIntarziat.Text = "Intarziat";
            // 
            // contextMenuStripImprumuturi
            // 
            this.contextMenuStripImprumuturi.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.contextMenuStripImprumuturi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddImpr2,
            this.toolStripMenuItemStergeImpr2});
            this.contextMenuStripImprumuturi.Name = "contextMenuStripImprumuturi";
            this.contextMenuStripImprumuturi.Size = new System.Drawing.Size(134, 56);
            this.contextMenuStripImprumuturi.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripImprumuturi_Opening);
            // 
            // toolStripMenuItemAddImpr2
            // 
            this.toolStripMenuItemAddImpr2.Name = "toolStripMenuItemAddImpr2";
            this.toolStripMenuItemAddImpr2.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItemAddImpr2.Text = "Adauga";
            this.toolStripMenuItemAddImpr2.Click += new System.EventHandler(this.toolStripMenuItemAddImpr2_Click);
            // 
            // toolStripMenuItemStergeImpr2
            // 
            this.toolStripMenuItemStergeImpr2.Name = "toolStripMenuItemStergeImpr2";
            this.toolStripMenuItemStergeImpr2.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItemStergeImpr2.Text = "Sterge";
            this.toolStripMenuItemStergeImpr2.Click += new System.EventHandler(this.toolStripMenuItemStergeImpr2_Click);
            // 
            // b_add_imp
            // 
            this.b_add_imp.Location = new System.Drawing.Point(719, 495);
            this.b_add_imp.Name = "b_add_imp";
            this.b_add_imp.Size = new System.Drawing.Size(155, 45);
            this.b_add_imp.TabIndex = 3;
            this.b_add_imp.Text = "Adauga &Imprumut";
            this.b_add_imp.UseVisualStyleBackColor = true;
            this.b_add_imp.Click += new System.EventHandler(this.b_add_imp_Click);
            // 
            // b_add_carte
            // 
            this.b_add_carte.Location = new System.Drawing.Point(558, 495);
            this.b_add_carte.Name = "b_add_carte";
            this.b_add_carte.Size = new System.Drawing.Size(128, 45);
            this.b_add_carte.TabIndex = 4;
            this.b_add_carte.Text = "Adauga Carte";
            this.b_add_carte.UseVisualStyleBackColor = true;
            this.b_add_carte.Click += new System.EventHandler(this.b_add_carte_Click);
            // 
            // b_add_cititor
            // 
            this.b_add_cititor.Location = new System.Drawing.Point(902, 495);
            this.b_add_cititor.Name = "b_add_cititor";
            this.b_add_cititor.Size = new System.Drawing.Size(123, 45);
            this.b_add_cititor.TabIndex = 5;
            this.b_add_cititor.Text = "Adauga Cititor";
            this.b_add_cititor.UseVisualStyleBackColor = true;
            this.b_add_cititor.Click += new System.EventHandler(this.b_add_cititor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFisiere,
            this.toolStripMenuItemCititori,
            this.toolStripMenuItemCarti,
            this.toolStripMenuItemImprumuturi,
            this.toolStripMenuItemBazaDate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 29);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFisiere
            // 
            this.toolStripMenuItemFisiere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSalveaza,
            this.toolStripMenuItemRestaureaza,
            this.toolStripMenuItemPrint});
            this.toolStripMenuItemFisiere.Name = "toolStripMenuItemFisiere";
            this.toolStripMenuItemFisiere.Size = new System.Drawing.Size(69, 25);
            this.toolStripMenuItemFisiere.Text = "&Fisiere";
            // 
            // toolStripMenuItemSalveaza
            // 
            this.toolStripMenuItemSalveaza.Name = "toolStripMenuItemSalveaza";
            this.toolStripMenuItemSalveaza.Size = new System.Drawing.Size(310, 30);
            this.toolStripMenuItemSalveaza.Text = "Salveaza Lista Imprumuturi";
            this.toolStripMenuItemSalveaza.Click += new System.EventHandler(this.toolStripMenuItemSalveaza_Click);
            // 
            // toolStripMenuItemRestaureaza
            // 
            this.toolStripMenuItemRestaureaza.Name = "toolStripMenuItemRestaureaza";
            this.toolStripMenuItemRestaureaza.Size = new System.Drawing.Size(310, 30);
            this.toolStripMenuItemRestaureaza.Text = "Restaureaza Lista Imprumuturi";
            this.toolStripMenuItemRestaureaza.Click += new System.EventHandler(this.toolStripMenuItemRestaureaza_Click);
            // 
            // toolStripMenuItemPrint
            // 
            this.toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
            this.toolStripMenuItemPrint.Size = new System.Drawing.Size(310, 30);
            this.toolStripMenuItemPrint.Text = "Print Carte";
            this.toolStripMenuItemPrint.Click += new System.EventHandler(this.toolStripMenuItemPrint_Click);
            // 
            // toolStripMenuItemCititori
            // 
            this.toolStripMenuItemCititori.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddCititor,
            this.toolStripMenuItemModifCit,
            this.toolStripMenuItem2StergeCit});
            this.toolStripMenuItemCititori.Name = "toolStripMenuItemCititori";
            this.toolStripMenuItemCititori.Size = new System.Drawing.Size(71, 25);
            this.toolStripMenuItemCititori.Text = "Cititori";
            // 
            // toolStripMenuItemAddCititor
            // 
            this.toolStripMenuItemAddCititor.Name = "toolStripMenuItemAddCititor";
            this.toolStripMenuItemAddCititor.Size = new System.Drawing.Size(204, 30);
            this.toolStripMenuItemAddCititor.Text = "Adauga Cititor";
            this.toolStripMenuItemAddCititor.Click += new System.EventHandler(this.toolStripMenuItemAddCititor_Click);
            // 
            // toolStripMenuItemModifCit
            // 
            this.toolStripMenuItemModifCit.Name = "toolStripMenuItemModifCit";
            this.toolStripMenuItemModifCit.Size = new System.Drawing.Size(204, 30);
            this.toolStripMenuItemModifCit.Text = "Modifica Cititor";
            this.toolStripMenuItemModifCit.Click += new System.EventHandler(this.toolStripMenuItemModifCit_Click);
            // 
            // toolStripMenuItem2StergeCit
            // 
            this.toolStripMenuItem2StergeCit.Name = "toolStripMenuItem2StergeCit";
            this.toolStripMenuItem2StergeCit.Size = new System.Drawing.Size(204, 30);
            this.toolStripMenuItem2StergeCit.Text = "Sterge Cititor";
            this.toolStripMenuItem2StergeCit.Click += new System.EventHandler(this.toolStripMenuItem2StergeCit_Click);
            // 
            // toolStripMenuItemCarti
            // 
            this.toolStripMenuItemCarti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddCarte,
            this.toolStripMenuItemModifCarte,
            this.toolStripMenuItemStergeCarte});
            this.toolStripMenuItemCarti.Name = "toolStripMenuItemCarti";
            this.toolStripMenuItemCarti.Size = new System.Drawing.Size(57, 25);
            this.toolStripMenuItemCarti.Text = "Carti";
            // 
            // toolStripMenuItemAddCarte
            // 
            this.toolStripMenuItemAddCarte.Name = "toolStripMenuItemAddCarte";
            this.toolStripMenuItemAddCarte.Size = new System.Drawing.Size(198, 30);
            this.toolStripMenuItemAddCarte.Text = "Adauga Carte";
            this.toolStripMenuItemAddCarte.Click += new System.EventHandler(this.toolStripMenuItemAddCarte_Click);
            // 
            // toolStripMenuItemModifCarte
            // 
            this.toolStripMenuItemModifCarte.Name = "toolStripMenuItemModifCarte";
            this.toolStripMenuItemModifCarte.Size = new System.Drawing.Size(198, 30);
            this.toolStripMenuItemModifCarte.Text = "Modifica Carte";
            this.toolStripMenuItemModifCarte.Click += new System.EventHandler(this.toolStripMenuItemModifCarte_Click);
            // 
            // toolStripMenuItemStergeCarte
            // 
            this.toolStripMenuItemStergeCarte.Name = "toolStripMenuItemStergeCarte";
            this.toolStripMenuItemStergeCarte.Size = new System.Drawing.Size(198, 30);
            this.toolStripMenuItemStergeCarte.Text = "Sterge Carte";
            this.toolStripMenuItemStergeCarte.Click += new System.EventHandler(this.toolStripMenuItemStergeCarte_Click);
            // 
            // toolStripMenuItemImprumuturi
            // 
            this.toolStripMenuItemImprumuturi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddImpr,
            this.toolStripMenuItemStergeImpr,
            this.toolStripMenuItemGrafic});
            this.toolStripMenuItemImprumuturi.Name = "toolStripMenuItemImprumuturi";
            this.toolStripMenuItemImprumuturi.Size = new System.Drawing.Size(113, 25);
            this.toolStripMenuItemImprumuturi.Text = "Imprumuturi";
            this.toolStripMenuItemImprumuturi.Click += new System.EventHandler(this.toolStripMenuItemImprumuturi_Click);
            // 
            // toolStripMenuItemAddImpr
            // 
            this.toolStripMenuItemAddImpr.Name = "toolStripMenuItemAddImpr";
            this.toolStripMenuItemAddImpr.Size = new System.Drawing.Size(224, 30);
            this.toolStripMenuItemAddImpr.Text = "Adauga Imprumut";
            this.toolStripMenuItemAddImpr.Click += new System.EventHandler(this.toolStripMenuItemAddImpr_Click);
            // 
            // toolStripMenuItemStergeImpr
            // 
            this.toolStripMenuItemStergeImpr.Name = "toolStripMenuItemStergeImpr";
            this.toolStripMenuItemStergeImpr.Size = new System.Drawing.Size(224, 30);
            this.toolStripMenuItemStergeImpr.Text = "Sterge Imprumut";
            this.toolStripMenuItemStergeImpr.Click += new System.EventHandler(this.toolStripMenuItemStergeImpr_Click);
            // 
            // toolStripMenuItemGrafic
            // 
            this.toolStripMenuItemGrafic.Name = "toolStripMenuItemGrafic";
            this.toolStripMenuItemGrafic.Size = new System.Drawing.Size(224, 30);
            this.toolStripMenuItemGrafic.Text = "Afiseaza grafic";
            this.toolStripMenuItemGrafic.Click += new System.EventHandler(this.toolStripMenuItemGrafic_Click);
            // 
            // toolStripMenuItemBazaDate
            // 
            this.toolStripMenuItemBazaDate.Name = "toolStripMenuItemBazaDate";
            this.toolStripMenuItemBazaDate.Size = new System.Drawing.Size(111, 25);
            this.toolStripMenuItemBazaDate.Text = "Baza de date";
            this.toolStripMenuItemBazaDate.Click += new System.EventHandler(this.toolStripMenuItemBazaDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 587);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.b_add_cititor);
            this.Controls.Add(this.b_add_carte);
            this.Controls.Add(this.b_add_imp);
            this.Controls.Add(this.l_imprumut);
            this.Controls.Add(this.t_carti);
            this.Controls.Add(this.l_cit);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripCititori.ResumeLayout(false);
            this.contextMenuStripCarte.ResumeLayout(false);
            this.contextMenuStripImprumuturi.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView l_cit;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.TreeView t_carti;
        private System.Windows.Forms.ImageList imagini;
        private System.Windows.Forms.ListView l_imprumut;
        private System.Windows.Forms.ColumnHeader columnHeaderCititor;
        private System.Windows.Forms.ColumnHeader columnHeaderCarte;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderIntarziat;
        private System.Windows.Forms.Button b_add_imp;
        private System.Windows.Forms.Button b_add_carte;
        private System.Windows.Forms.Button b_add_cititor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCititori;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModCit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeCit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFisiere;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCititori;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCititor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModifCit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2StergeCit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCarti;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCarte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModifCarte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeCarte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImprumuturi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddImpr;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeImpr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCarte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCarte2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModifCarte2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeCarte2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImprumuturi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddImpr2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeImpr2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSalveaza;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRestaureaza;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGrafic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBazaDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrint;
    }
}

