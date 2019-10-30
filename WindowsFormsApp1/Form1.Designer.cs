namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etlapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzazoDataSet = new WindowsFormsApp1.PizzazoDataSet();
            this.etlapTableAdapter = new WindowsFormsApp1.PizzazoDataSetTableAdapters.EtlapTableAdapter();
            this.pizzaneveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaleirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etlapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzazoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pizzaneveDataGridViewTextBoxColumn,
            this.pizzaleirasDataGridViewTextBoxColumn,
            this.pizzaarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etlapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 140);
            this.dataGridView1.TabIndex = 2;
            // 
            // etlapBindingSource
            // 
            this.etlapBindingSource.DataMember = "Etlap";
            this.etlapBindingSource.DataSource = this.pizzazoDataSet;
            // 
            // pizzazoDataSet
            // 
            this.pizzazoDataSet.DataSetName = "PizzazoDataSet";
            this.pizzazoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etlapTableAdapter
            // 
            this.etlapTableAdapter.ClearBeforeFill = true;
            // 
            // pizzaneveDataGridViewTextBoxColumn
            // 
            this.pizzaneveDataGridViewTextBoxColumn.DataPropertyName = "Pizza_neve";
            this.pizzaneveDataGridViewTextBoxColumn.HeaderText = "Pizza_neve";
            this.pizzaneveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pizzaneveDataGridViewTextBoxColumn.Name = "pizzaneveDataGridViewTextBoxColumn";
            this.pizzaneveDataGridViewTextBoxColumn.Width = 125;
            // 
            // pizzaleirasDataGridViewTextBoxColumn
            // 
            this.pizzaleirasDataGridViewTextBoxColumn.DataPropertyName = "Pizza_leiras";
            this.pizzaleirasDataGridViewTextBoxColumn.HeaderText = "Pizza_leiras";
            this.pizzaleirasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pizzaleirasDataGridViewTextBoxColumn.Name = "pizzaleirasDataGridViewTextBoxColumn";
            this.pizzaleirasDataGridViewTextBoxColumn.Width = 125;
            // 
            // pizzaarDataGridViewTextBoxColumn
            // 
            this.pizzaarDataGridViewTextBoxColumn.DataPropertyName = "Pizza_ar";
            this.pizzaarDataGridViewTextBoxColumn.HeaderText = "Pizza_ar";
            this.pizzaarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pizzaarDataGridViewTextBoxColumn.Name = "pizzaarDataGridViewTextBoxColumn";
            this.pizzaarDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Étlap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Normal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etlapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzazoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzazoDataSet pizzazoDataSet;
        private System.Windows.Forms.BindingSource etlapBindingSource;
        private PizzazoDataSetTableAdapters.EtlapTableAdapter etlapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaneveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaleirasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

