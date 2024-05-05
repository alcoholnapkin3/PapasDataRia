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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.sushiRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sushiRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.SushiRecipiesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flippedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filling1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filling2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filling3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shakerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sauceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sushiRecipiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.riceDataGridViewTextBoxColumn,
            this.wrapDataGridViewTextBoxColumn,
            this.flippedDataGridViewCheckBoxColumn,
            this.filling1stDataGridViewTextBoxColumn,
            this.filling2ndDataGridViewTextBoxColumn,
            this.filling3rdDataGridViewTextBoxColumn,
            this.toppingDataGridViewTextBoxColumn,
            this.shakerDataGridViewTextBoxColumn,
            this.sauceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sushiRecipiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sushiRecipiesBindingSource
            // 
            this.sushiRecipiesBindingSource.DataMember = "SushiRecipies";
            this.sushiRecipiesBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // sushiRecipiesTableAdapter
            // 
            this.sushiRecipiesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // riceDataGridViewTextBoxColumn
            // 
            this.riceDataGridViewTextBoxColumn.DataPropertyName = "rice";
            this.riceDataGridViewTextBoxColumn.HeaderText = "rice";
            this.riceDataGridViewTextBoxColumn.Name = "riceDataGridViewTextBoxColumn";
            // 
            // wrapDataGridViewTextBoxColumn
            // 
            this.wrapDataGridViewTextBoxColumn.DataPropertyName = "wrap";
            this.wrapDataGridViewTextBoxColumn.HeaderText = "wrap";
            this.wrapDataGridViewTextBoxColumn.Name = "wrapDataGridViewTextBoxColumn";
            // 
            // flippedDataGridViewCheckBoxColumn
            // 
            this.flippedDataGridViewCheckBoxColumn.DataPropertyName = "flipped";
            this.flippedDataGridViewCheckBoxColumn.HeaderText = "flipped";
            this.flippedDataGridViewCheckBoxColumn.Name = "flippedDataGridViewCheckBoxColumn";
            // 
            // filling1stDataGridViewTextBoxColumn
            // 
            this.filling1stDataGridViewTextBoxColumn.DataPropertyName = "filling_1st";
            this.filling1stDataGridViewTextBoxColumn.HeaderText = "filling_1st";
            this.filling1stDataGridViewTextBoxColumn.Name = "filling1stDataGridViewTextBoxColumn";
            // 
            // filling2ndDataGridViewTextBoxColumn
            // 
            this.filling2ndDataGridViewTextBoxColumn.DataPropertyName = "filling_2nd";
            this.filling2ndDataGridViewTextBoxColumn.HeaderText = "filling_2nd";
            this.filling2ndDataGridViewTextBoxColumn.Name = "filling2ndDataGridViewTextBoxColumn";
            // 
            // filling3rdDataGridViewTextBoxColumn
            // 
            this.filling3rdDataGridViewTextBoxColumn.DataPropertyName = "filling_3rd";
            this.filling3rdDataGridViewTextBoxColumn.HeaderText = "filling_3rd";
            this.filling3rdDataGridViewTextBoxColumn.Name = "filling3rdDataGridViewTextBoxColumn";
            // 
            // toppingDataGridViewTextBoxColumn
            // 
            this.toppingDataGridViewTextBoxColumn.DataPropertyName = "topping";
            this.toppingDataGridViewTextBoxColumn.HeaderText = "topping";
            this.toppingDataGridViewTextBoxColumn.Name = "toppingDataGridViewTextBoxColumn";
            // 
            // shakerDataGridViewTextBoxColumn
            // 
            this.shakerDataGridViewTextBoxColumn.DataPropertyName = "shaker";
            this.shakerDataGridViewTextBoxColumn.HeaderText = "shaker";
            this.shakerDataGridViewTextBoxColumn.Name = "shakerDataGridViewTextBoxColumn";
            // 
            // sauceDataGridViewTextBoxColumn
            // 
            this.sauceDataGridViewTextBoxColumn.DataPropertyName = "sauce";
            this.sauceDataGridViewTextBoxColumn.HeaderText = "sauce";
            this.sauceDataGridViewTextBoxColumn.Name = "sauceDataGridViewTextBoxColumn";
            // 
            // SushiList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 298);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SushiList";
            this.Text = "SushiList";
            this.Load += new System.EventHandler(this.SushiList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sushiRecipiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource sushiRecipiesBindingSource;
        private PapasDatabaseDataSetTableAdapters.SushiRecipiesTableAdapter sushiRecipiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flippedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filling1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filling2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filling3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shakerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sauceDataGridViewTextBoxColumn;
    }
}