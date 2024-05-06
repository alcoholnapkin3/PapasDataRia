namespace PapasDataRia
{
    partial class CustomersForm
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
            this.regularCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.papasDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regularCustomersTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter();
            this.regularCustomersTableAdapter1 = new PapasDataRia.PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.regularCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // regularCustomersBindingSource
            // 
            this.regularCustomersBindingSource.DataMember = "RegularCustomers";
            this.regularCustomersBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // papasDatabaseDataSetBindingSource
            // 
            this.papasDatabaseDataSetBindingSource.DataSource = this.papasDatabaseDataSet;
            this.papasDatabaseDataSetBindingSource.Position = 0;
            // 
            // regularCustomersTableAdapter
            // 
            this.regularCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // regularCustomersTableAdapter1
            // 
            this.regularCustomersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1036, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 406);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regularCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource papasDatabaseDataSetBindingSource;
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource regularCustomersBindingSource;
        private PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter regularCustomersTableAdapter;
        private PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter regularCustomersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}