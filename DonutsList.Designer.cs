namespace PapasDataRia
{
    partial class DonutsList
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
            this.donutsRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.donutsRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.DonutsRecipiesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.donutsRecipiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // donutsRecipiesBindingSource
            // 
            this.donutsRecipiesBindingSource.DataMember = "DonutsRecipies";
            this.donutsRecipiesBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donutsRecipiesTableAdapter
            // 
            this.donutsRecipiesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // DonutsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 385);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DonutsList";
            this.Text = "DonutsList";
            this.Load += new System.EventHandler(this.DonutsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donutsRecipiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource donutsRecipiesBindingSource;
        private PapasDatabaseDataSetTableAdapters.DonutsRecipiesTableAdapter donutsRecipiesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}