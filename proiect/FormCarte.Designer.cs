
namespace proiect
{
    partial class FormCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarte));
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.labelStoc = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxCategorie = new System.Windows.Forms.TextBox();
            this.textBoxDescriere = new System.Windows.Forms.TextBox();
            this.textBoxStoc = new System.Windows.Forms.TextBox();
            this.buttonAddCarte = new System.Windows.Forms.Button();
            this.buttonModifCarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(47, 27);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(47, 80);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(33, 16);
            this.labelTitlu.TabIndex = 1;
            this.labelTitlu.Text = "Titlu";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(47, 133);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(39, 16);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Autor";
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Location = new System.Drawing.Point(47, 186);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(67, 16);
            this.labelCategorie.TabIndex = 3;
            this.labelCategorie.Text = "Categorie";
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Location = new System.Drawing.Point(47, 239);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(67, 16);
            this.labelDescriere.TabIndex = 4;
            this.labelDescriere.Text = "Descriere";
            // 
            // labelStoc
            // 
            this.labelStoc.AutoSize = true;
            this.labelStoc.Location = new System.Drawing.Point(47, 339);
            this.labelStoc.Name = "labelStoc";
            this.labelStoc.Size = new System.Drawing.Size(35, 16);
            this.labelStoc.TabIndex = 5;
            this.labelStoc.Text = "Stoc";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(144, 21);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(81, 22);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(144, 74);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(262, 22);
            this.textBoxTitlu.TabIndex = 7;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(144, 127);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(262, 22);
            this.textBoxAutor.TabIndex = 8;
            // 
            // textBoxCategorie
            // 
            this.textBoxCategorie.Location = new System.Drawing.Point(144, 180);
            this.textBoxCategorie.Name = "textBoxCategorie";
            this.textBoxCategorie.Size = new System.Drawing.Size(262, 22);
            this.textBoxCategorie.TabIndex = 9;
            // 
            // textBoxDescriere
            // 
            this.textBoxDescriere.Location = new System.Drawing.Point(144, 233);
            this.textBoxDescriere.Multiline = true;
            this.textBoxDescriere.Name = "textBoxDescriere";
            this.textBoxDescriere.Size = new System.Drawing.Size(262, 86);
            this.textBoxDescriere.TabIndex = 10;
            // 
            // textBoxStoc
            // 
            this.textBoxStoc.Location = new System.Drawing.Point(144, 339);
            this.textBoxStoc.Name = "textBoxStoc";
            this.textBoxStoc.Size = new System.Drawing.Size(81, 22);
            this.textBoxStoc.TabIndex = 11;
            // 
            // buttonAddCarte
            // 
            this.buttonAddCarte.Location = new System.Drawing.Point(144, 383);
            this.buttonAddCarte.Name = "buttonAddCarte";
            this.buttonAddCarte.Size = new System.Drawing.Size(109, 38);
            this.buttonAddCarte.TabIndex = 12;
            this.buttonAddCarte.Text = "Adauga";
            this.buttonAddCarte.UseVisualStyleBackColor = true;
            this.buttonAddCarte.Click += new System.EventHandler(this.buttonAddCarte_Click);
            // 
            // buttonModifCarte
            // 
            this.buttonModifCarte.Location = new System.Drawing.Point(298, 383);
            this.buttonModifCarte.Name = "buttonModifCarte";
            this.buttonModifCarte.Size = new System.Drawing.Size(108, 38);
            this.buttonModifCarte.TabIndex = 13;
            this.buttonModifCarte.Text = "Actualizeaza";
            this.buttonModifCarte.UseVisualStyleBackColor = true;
            this.buttonModifCarte.Click += new System.EventHandler(this.buttonModifCarte_Click);
            // 
            // FormCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 444);
            this.Controls.Add(this.buttonModifCarte);
            this.Controls.Add(this.buttonAddCarte);
            this.Controls.Add(this.textBoxStoc);
            this.Controls.Add(this.textBoxDescriere);
            this.Controls.Add(this.textBoxCategorie);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitlu);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelStoc);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.labelId);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            this.Load += new System.EventHandler(this.FormCarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelDescriere;
        private System.Windows.Forms.Label labelStoc;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxCategorie;
        private System.Windows.Forms.TextBox textBoxDescriere;
        private System.Windows.Forms.TextBox textBoxStoc;
        private System.Windows.Forms.Button buttonAddCarte;
        private System.Windows.Forms.Button buttonModifCarte;
    }
}