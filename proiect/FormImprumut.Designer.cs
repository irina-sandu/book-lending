
namespace proiect
{
    partial class FormImprumut
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
            this.labelCititor = new System.Windows.Forms.Label();
            this.labelCarte = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxCititor = new System.Windows.Forms.TextBox();
            this.textBoxCarte = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAddImprumut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCititor
            // 
            this.labelCititor.AutoSize = true;
            this.labelCititor.Location = new System.Drawing.Point(35, 47);
            this.labelCititor.Name = "labelCititor";
            this.labelCititor.Size = new System.Drawing.Size(80, 16);
            this.labelCititor.TabIndex = 0;
            this.labelCititor.Text = "Nume Cititor";
            // 
            // labelCarte
            // 
            this.labelCarte.AutoSize = true;
            this.labelCarte.Location = new System.Drawing.Point(35, 112);
            this.labelCarte.Name = "labelCarte";
            this.labelCarte.Size = new System.Drawing.Size(68, 16);
            this.labelCarte.TabIndex = 1;
            this.labelCarte.Text = "Titlu Carte";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(35, 177);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(40, 16);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data ";
            // 
            // textBoxCititor
            // 
            this.textBoxCititor.Location = new System.Drawing.Point(172, 44);
            this.textBoxCititor.Name = "textBoxCititor";
            this.textBoxCititor.Size = new System.Drawing.Size(194, 22);
            this.textBoxCititor.TabIndex = 3;
            // 
            // textBoxCarte
            // 
            this.textBoxCarte.Location = new System.Drawing.Point(172, 111);
            this.textBoxCarte.Name = "textBoxCarte";
            this.textBoxCarte.Size = new System.Drawing.Size(194, 22);
            this.textBoxCarte.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(172, 178);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(194, 22);
            this.dateTimePicker.TabIndex = 5;
            // 
            // buttonAddImprumut
            // 
            this.buttonAddImprumut.Location = new System.Drawing.Point(145, 236);
            this.buttonAddImprumut.Name = "buttonAddImprumut";
            this.buttonAddImprumut.Size = new System.Drawing.Size(126, 45);
            this.buttonAddImprumut.TabIndex = 6;
            this.buttonAddImprumut.Text = "&Adauga";
            this.buttonAddImprumut.UseVisualStyleBackColor = true;
            this.buttonAddImprumut.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormImprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 304);
            this.Controls.Add(this.buttonAddImprumut);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxCarte);
            this.Controls.Add(this.textBoxCititor);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelCarte);
            this.Controls.Add(this.labelCititor);
            this.Name = "FormImprumut";
            this.Text = "FormImprumut";
            this.Load += new System.EventHandler(this.FormImprumut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCititor;
        private System.Windows.Forms.Label labelCarte;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxCititor;
        private System.Windows.Forms.TextBox textBoxCarte;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonAddImprumut;
    }
}