namespace PapasDataRia
{
    partial class PizzasList
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
            this.pizzaRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.pizzaRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.PizzaRecipiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaRecipiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1006, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // pizzaRecipiesBindingSource
            // 
            this.pizzaRecipiesBindingSource.DataMember = "PizzaRecipies";
            this.pizzaRecipiesBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzaRecipiesTableAdapter
            // 
            this.pizzaRecipiesTableAdapter.ClearBeforeFill = true;
            // 
            // PizzasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 448);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PizzasList";
            this.Text = "PizzasList";
            this.Load += new System.EventHandler(this.PizzasList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaRecipiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource pizzaRecipiesBindingSource;
        private PapasDatabaseDataSetTableAdapters.PizzaRecipiesTableAdapter pizzaRecipiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}