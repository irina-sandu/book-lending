
namespace proiect
{
    partial class FormData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazadateDataSet = new proiect.bazadateDataSet();
            this.cartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartiTableAdapter = new proiect.bazadateDataSetTableAdapters.CartiTableAdapter();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titluDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.stocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // bazadateDataSet
            // 
            this.bazadateDataSet.DataSetName = "bazadateDataSet";
            this.bazadateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartiBindingSource
            // 
            this.cartiBindingSource.DataMember = "Carti";
            this.cartiBindingSource.DataSource = this.bazadateDataSet;
            // 
            // cartiTableAdapter
            // 
            this.cartiTableAdapter.ClearBeforeFill = true;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.Width = 130;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 130;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.Width = 130;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.Width = 130;
            // 
            // stocDataGridViewTextBoxColumn
            // 
            this.stocDataGridViewTextBoxColumn.DataPropertyName = "Stoc";
            this.stocDataGridViewTextBoxColumn.HeaderText = "Stoc";
            this.stocDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.stocDataGridViewTextBoxColumn.Name = "stocDataGridViewTextBoxColumn";
            this.stocDataGridViewTextBoxColumn.Width = 130;
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.Location = new System.Drawing.Point(334, 363);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(152, 43);
            this.buttonSalveaza.TabIndex = 1;
            this.buttonSalveaza.Text = "Salveaza";
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormData";
            this.Text = "FormData";
            this.Load += new System.EventHandler(this.FormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bazadateDataSet bazadateDataSet;
        private System.Windows.Forms.BindingSource cartiBindingSource;
        private bazadateDataSetTableAdapters.CartiTableAdapter cartiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSalveaza;
    }
}