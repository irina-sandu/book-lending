
namespace proiect
{
    partial class FormCititor
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
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.b_add_cititor = new System.Windows.Forms.Button();
            this.buttonModifCit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userControl11 = new proiect.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(35, 95);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(44, 16);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(35, 157);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(62, 16);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(35, 219);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(54, 16);
            this.labelTelefon.TabIndex = 2;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(35, 281);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 16);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(35, 33);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 16);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(154, 27);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(93, 22);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(154, 89);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(193, 22);
            this.textBoxNume.TabIndex = 6;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(154, 151);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(193, 22);
            this.textBoxPrenume.TabIndex = 7;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(154, 213);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(193, 22);
            this.textBoxTelefon.TabIndex = 8;
            this.textBoxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelefon_Validating);
            this.textBoxTelefon.Validated += new System.EventHandler(this.textBoxTelefon_Validated);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(154, 275);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(193, 22);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
            // 
            // b_add_cititor
            // 
            this.b_add_cititor.Location = new System.Drawing.Point(154, 386);
            this.b_add_cititor.Name = "b_add_cititor";
            this.b_add_cititor.Size = new System.Drawing.Size(107, 46);
            this.b_add_cititor.TabIndex = 10;
            this.b_add_cititor.Text = "Adauga";
            this.b_add_cititor.UseVisualStyleBackColor = true;
            this.b_add_cititor.Click += new System.EventHandler(this.b_add_cititor_Click);
            // 
            // buttonModifCit
            // 
            this.buttonModifCit.Location = new System.Drawing.Point(282, 386);
            this.buttonModifCit.Name = "buttonModifCit";
            this.buttonModifCit.Size = new System.Drawing.Size(103, 46);
            this.buttonModifCit.TabIndex = 11;
            this.buttonModifCit.Text = "Actualizeaza";
            this.buttonModifCit.UseVisualStyleBackColor = true;
            this.buttonModifCit.Click += new System.EventHandler(this.buttonModifCit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(1, 304);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(395, 76);
            this.userControl11.TabIndex = 12;
            // 
            // FormCititor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 478);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonModifCit);
            this.Controls.Add(this.b_add_cititor);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "FormCititor";
            this.Text = "FormCititor";
            this.Load += new System.EventHandler(this.FormCititor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button b_add_cititor;
        private System.Windows.Forms.Button buttonModifCit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private UserControl1 userControl11;
    }
}