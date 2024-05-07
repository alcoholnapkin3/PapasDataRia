namespace PapasDataRia
{
    partial class SandwichesList
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
            this.sandwichRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.sandwichRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.SandwichRecipiesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sandwichRecipiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sandwichRecipiesBindingSource
            // 
            this.sandwichRecipiesBindingSource.DataMember = "SandwichRecipies";
            this.sandwichRecipiesBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sandwichRecipiesTableAdapter
            // 
            this.sandwichRecipiesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // SandwichesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 458);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SandwichesList";
            this.Text = "SandwichesList";
            this.Load += new System.EventHandler(this.SandwichesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sandwichRecipiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource sandwichRecipiesBindingSource;
        private PapasDatabaseDataSetTableAdapters.SandwichRecipiesTableAdapter sandwichRecipiesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}