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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.sandwichRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sandwichRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.SandwichRecipiesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meatoralternativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batterorbreadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrameatoralternativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrabatterorbreadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingorsauce1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingorsauce2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingorsauce3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingorsauce4thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingorsauce5thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingorsauce6thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandwichRecipiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.meatoralternativeDataGridViewTextBoxColumn,
            this.batterorbreadingDataGridViewTextBoxColumn,
            this.extrameatoralternativeDataGridViewTextBoxColumn,
            this.extrabatterorbreadingDataGridViewTextBoxColumn,
            this.bunDataGridViewTextBoxColumn,
            this.toppingorsauce1stDataGridViewTextBoxColumn,
            this.toppingorsauce2ndDataGridViewTextBoxColumn,
            this.toppingorsauce3rdDataGridViewTextBoxColumn,
            this.toppingorsauce4thDataGridViewTextBoxColumn,
            this.toppingorsauce5thDataGridViewTextBoxColumn,
            this.toppingorsauce6thDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sandwichRecipiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sandwichRecipiesBindingSource
            // 
            this.sandwichRecipiesBindingSource.DataMember = "SandwichRecipies";
            this.sandwichRecipiesBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // sandwichRecipiesTableAdapter
            // 
            this.sandwichRecipiesTableAdapter.ClearBeforeFill = true;
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
            // meatoralternativeDataGridViewTextBoxColumn
            // 
            this.meatoralternativeDataGridViewTextBoxColumn.DataPropertyName = "meat_or_alternative";
            this.meatoralternativeDataGridViewTextBoxColumn.HeaderText = "meat_or_alternative";
            this.meatoralternativeDataGridViewTextBoxColumn.Name = "meatoralternativeDataGridViewTextBoxColumn";
            // 
            // batterorbreadingDataGridViewTextBoxColumn
            // 
            this.batterorbreadingDataGridViewTextBoxColumn.DataPropertyName = "batter_or_breading";
            this.batterorbreadingDataGridViewTextBoxColumn.HeaderText = "batter_or_breading";
            this.batterorbreadingDataGridViewTextBoxColumn.Name = "batterorbreadingDataGridViewTextBoxColumn";
            // 
            // extrameatoralternativeDataGridViewTextBoxColumn
            // 
            this.extrameatoralternativeDataGridViewTextBoxColumn.DataPropertyName = "extra_meat_or_alternative";
            this.extrameatoralternativeDataGridViewTextBoxColumn.HeaderText = "extra_meat_or_alternative";
            this.extrameatoralternativeDataGridViewTextBoxColumn.Name = "extrameatoralternativeDataGridViewTextBoxColumn";
            // 
            // extrabatterorbreadingDataGridViewTextBoxColumn
            // 
            this.extrabatterorbreadingDataGridViewTextBoxColumn.DataPropertyName = "extra_batter_or_breading";
            this.extrabatterorbreadingDataGridViewTextBoxColumn.HeaderText = "extra_batter_or_breading";
            this.extrabatterorbreadingDataGridViewTextBoxColumn.Name = "extrabatterorbreadingDataGridViewTextBoxColumn";
            // 
            // bunDataGridViewTextBoxColumn
            // 
            this.bunDataGridViewTextBoxColumn.DataPropertyName = "bun";
            this.bunDataGridViewTextBoxColumn.HeaderText = "bun";
            this.bunDataGridViewTextBoxColumn.Name = "bunDataGridViewTextBoxColumn";
            // 
            // toppingorsauce1stDataGridViewTextBoxColumn
            // 
            this.toppingorsauce1stDataGridViewTextBoxColumn.DataPropertyName = "topping_or_sauce_1st";
            this.toppingorsauce1stDataGridViewTextBoxColumn.HeaderText = "topping_or_sauce_1st";
            this.toppingorsauce1stDataGridViewTextBoxColumn.Name = "toppingorsauce1stDataGridViewTextBoxColumn";
            // 
            // toppingorsauce2ndDataGridViewTextBoxColumn
            // 
            this.toppingorsauce2ndDataGridViewTextBoxColumn.DataPropertyName = "topping_or_sauce_2nd";
            this.toppingorsauce2ndDataGridViewTextBoxColumn.HeaderText = "topping_or_sauce_2nd";
            this.toppingorsauce2ndDataGridViewTextBoxColumn.Name = "toppingorsauce2ndDataGridViewTextBoxColumn";
            // 
            // toppingorsauce3rdDataGridViewTextBoxColumn
            // 
            this.toppingorsauce3rdDataGridViewTextBoxColumn.DataPropertyName = "topping_or_sauce_3rd";
            this.toppingorsauce3rdDataGridViewTextBoxColumn.HeaderText = "topping_or_sauce_3rd";
            this.toppingorsauce3rdDataGridViewTextBoxColumn.Name = "toppingorsauce3rdDataGridViewTextBoxColumn";
            // 
            // toppingorsauce4thDataGridViewTextBoxColumn
            // 
            this.toppingorsauce4thDataGridViewTextBoxColumn.DataPropertyName = "topping_or_sauce_4th";
            this.toppingorsauce4thDataGridViewTextBoxColumn.HeaderText = "topping_or_sauce_4th";
            this.toppingorsauce4thDataGridViewTextBoxColumn.Name = "toppingorsauce4thDataGridViewTextBoxColumn";
            // 
            // toppingorsauce5thDataGridViewTextBoxColumn
            // 
            this.toppingorsauce5thDataGridViewTextBoxColumn.DataPropertyName = "topping_or_sauce_5th";
            this.toppingorsauce5thDataGridViewTextBoxColumn.HeaderText = "topping_or_sauce_5th";
            this.toppingorsauce5thDataGridViewTextBoxColumn.Name = "toppingorsauce5thDataGridViewTextBoxColumn";
            // 
            // toppingorsauce6thDataGridViewTextBoxColumn
            // 
            this.toppingorsauce6thDataGridViewTextBoxColumn.DataPropertyName = "topping_or_sauce_6th";
            this.toppingorsauce6thDataGridViewTextBoxColumn.HeaderText = "topping_or_sauce_6th";
            this.toppingorsauce6thDataGridViewTextBoxColumn.Name = "toppingorsauce6thDataGridViewTextBoxColumn";
            // 
            // SandwichesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 319);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SandwichesList";
            this.Text = "SandwichesList";
            this.Load += new System.EventHandler(this.SandwichesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sandwichRecipiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource sandwichRecipiesBindingSource;
        private PapasDatabaseDataSetTableAdapters.SandwichRecipiesTableAdapter sandwichRecipiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meatoralternativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batterorbreadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrameatoralternativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrabatterorbreadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingorsauce1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingorsauce2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingorsauce3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingorsauce4thDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingorsauce5thDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingorsauce6thDataGridViewTextBoxColumn;
    }
}