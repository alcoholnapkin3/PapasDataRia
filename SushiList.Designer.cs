namespace PapasDataRia
{
    partial class SushiList
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
            this.sushiRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.sushiRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.SushiRecipiesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sushiRecipiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sushiRecipiesBindingSource
            // 
            this.sushiRecipiesBindingSource.DataMember = "SushiRecipies";
            this.sushiRecipiesBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sushiRecipiesTableAdapter
            // 
            this.sushiRecipiesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // SushiList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 437);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SushiList";
            this.Text = "SushiList";
            this.Load += new System.EventHandler(this.SushiList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sushiRecipiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource sushiRecipiesBindingSource;
        private PapasDatabaseDataSetTableAdapters.SushiRecipiesTableAdapter sushiRecipiesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}