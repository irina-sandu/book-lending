
namespace proiect
{
    partial class FormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            this.textBoxStoc = new System.Windows.Forms.TextBox();
            this.textBoxDescriere = new System.Windows.Forms.TextBox();
            this.textBoxCategorie = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelStoc = new System.Windows.Forms.Label();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // textBoxStoc
            // 
            this.textBoxStoc.Location = new System.Drawing.Point(141, 422);
            this.textBoxStoc.Name = "textBoxStoc";
            this.textBoxStoc.Size = new System.Drawing.Size(81, 22);
            this.textBoxStoc.TabIndex = 23;
            // 
            // textBoxDescriere
            // 
            this.textBoxDescriere.Location = new System.Drawing.Point(141, 243);
            this.textBoxDescriere.Multiline = true;
            this.textBoxDescriere.Name = "textBoxDescriere";
            this.textBoxDescriere.Size = new System.Drawing.Size(513, 149);
            this.textBoxDescriere.TabIndex = 22;
            // 
            // textBoxCategorie
            // 
            this.textBoxCategorie.Location = new System.Drawing.Point(141, 190);
            this.textBoxCategorie.Name = "textBoxCategorie";
            this.textBoxCategorie.Size = new System.Drawing.Size(262, 22);
            this.textBoxCategorie.TabIndex = 21;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(141, 137);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(262, 22);
            this.textBoxAutor.TabIndex = 20;
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(141, 84);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(262, 22);
            this.textBoxTitlu.TabIndex = 19;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(141, 31);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(81, 22);
            this.textBoxID.TabIndex = 18;
            // 
            // labelStoc
            // 
            this.labelStoc.AutoSize = true;
            this.labelStoc.Location = new System.Drawing.Point(44, 422);
            this.labelStoc.Name = "labelStoc";
            this.labelStoc.Size = new System.Drawing.Size(35, 16);
            this.labelStoc.TabIndex = 17;
            this.labelStoc.Text = "Stoc";
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Location = new System.Drawing.Point(44, 249);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(67, 16);
            this.labelDescriere.TabIndex = 16;
            this.labelDescriere.Text = "Descriere";
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Location = new System.Drawing.Point(44, 196);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(67, 16);
            this.labelCategorie.TabIndex = 15;
            this.labelCategorie.Text = "Categorie";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(44, 143);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(39, 16);
            this.labelAutor.TabIndex = 14;
            this.labelAutor.Text = "Autor";
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(44, 90);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(33, 16);
            this.labelTitlu.TabIndex = 13;
            this.labelTitlu.Text = "Titlu";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(44, 37);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 16);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "Id";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(269, 508);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(134, 49);
            this.buttonPrint.TabIndex = 24;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 594);
            this.Controls.Add(this.buttonPrint);
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
            this.MaximizeBox = false;
            this.Name = "FormPrint";
            this.Text = "Print Form";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStoc;
        private System.Windows.Forms.TextBox textBoxDescriere;
        private System.Windows.Forms.TextBox textBoxCategorie;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelStoc;
        private System.Windows.Forms.Label labelDescriere;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}