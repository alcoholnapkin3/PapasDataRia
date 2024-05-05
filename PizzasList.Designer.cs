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
            this.pizzaRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.pizzaRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.PizzaRecipiesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sauceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheeseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topping1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammount1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topping2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammount2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topping3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammount3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topping4thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammount4thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location4thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaRecipiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.crustDataGridViewTextBoxColumn,
            this.sauceDataGridViewTextBoxColumn,
            this.cheeseDataGridViewTextBoxColumn,
            this.topping1stDataGridViewTextBoxColumn,
            this.ammount1stDataGridViewTextBoxColumn,
            this.location1stDataGridViewTextBoxColumn,
            this.topping2ndDataGridViewTextBoxColumn,
            this.ammount2ndDataGridViewTextBoxColumn,
            this.location2ndDataGridViewTextBoxColumn,
            this.topping3rdDataGridViewTextBoxColumn,
            this.ammount3rdDataGridViewTextBoxColumn,
            this.location3rdDataGridViewTextBoxColumn,
            this.topping4thDataGridViewTextBoxColumn,
            this.ammount4thDataGridViewTextBoxColumn,
            this.location4thDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pizzaRecipiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 208);
            this.dataGridView1.TabIndex = 0;
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
            // crustDataGridViewTextBoxColumn
            // 
            this.crustDataGridViewTextBoxColumn.DataPropertyName = "crust";
            this.crustDataGridViewTextBoxColumn.HeaderText = "crust";
            this.crustDataGridViewTextBoxColumn.Name = "crustDataGridViewTextBoxColumn";
            // 
            // sauceDataGridViewTextBoxColumn
            // 
            this.sauceDataGridViewTextBoxColumn.DataPropertyName = "sauce";
            this.sauceDataGridViewTextBoxColumn.HeaderText = "sauce";
            this.sauceDataGridViewTextBoxColumn.Name = "sauceDataGridViewTextBoxColumn";
            // 
            // cheeseDataGridViewTextBoxColumn
            // 
            this.cheeseDataGridViewTextBoxColumn.DataPropertyName = "cheese";
            this.cheeseDataGridViewTextBoxColumn.HeaderText = "cheese";
            this.cheeseDataGridViewTextBoxColumn.Name = "cheeseDataGridViewTextBoxColumn";
            // 
            // topping1stDataGridViewTextBoxColumn
            // 
            this.topping1stDataGridViewTextBoxColumn.DataPropertyName = "topping_1st";
            this.topping1stDataGridViewTextBoxColumn.HeaderText = "topping_1st";
            this.topping1stDataGridViewTextBoxColumn.Name = "topping1stDataGridViewTextBoxColumn";
            // 
            // ammount1stDataGridViewTextBoxColumn
            // 
            this.ammount1stDataGridViewTextBoxColumn.DataPropertyName = "ammount_1st";
            this.ammount1stDataGridViewTextBoxColumn.HeaderText = "ammount_1st";
            this.ammount1stDataGridViewTextBoxColumn.Name = "ammount1stDataGridViewTextBoxColumn";
            // 
            // location1stDataGridViewTextBoxColumn
            // 
            this.location1stDataGridViewTextBoxColumn.DataPropertyName = "location_1st";
            this.location1stDataGridViewTextBoxColumn.HeaderText = "location_1st";
            this.location1stDataGridViewTextBoxColumn.Name = "location1stDataGridViewTextBoxColumn";
            // 
            // topping2ndDataGridViewTextBoxColumn
            // 
            this.topping2ndDataGridViewTextBoxColumn.DataPropertyName = "topping_2nd";
            this.topping2ndDataGridViewTextBoxColumn.HeaderText = "topping_2nd";
            this.topping2ndDataGridViewTextBoxColumn.Name = "topping2ndDataGridViewTextBoxColumn";
            // 
            // ammount2ndDataGridViewTextBoxColumn
            // 
            this.ammount2ndDataGridViewTextBoxColumn.DataPropertyName = "ammount_2nd";
            this.ammount2ndDataGridViewTextBoxColumn.HeaderText = "ammount_2nd";
            this.ammount2ndDataGridViewTextBoxColumn.Name = "ammount2ndDataGridViewTextBoxColumn";
            // 
            // location2ndDataGridViewTextBoxColumn
            // 
            this.location2ndDataGridViewTextBoxColumn.DataPropertyName = "location_2nd";
            this.location2ndDataGridViewTextBoxColumn.HeaderText = "location_2nd";
            this.location2ndDataGridViewTextBoxColumn.Name = "location2ndDataGridViewTextBoxColumn";
            // 
            // topping3rdDataGridViewTextBoxColumn
            // 
            this.topping3rdDataGridViewTextBoxColumn.DataPropertyName = "topping_3rd";
            this.topping3rdDataGridViewTextBoxColumn.HeaderText = "topping_3rd";
            this.topping3rdDataGridViewTextBoxColumn.Name = "topping3rdDataGridViewTextBoxColumn";
            // 
            // ammount3rdDataGridViewTextBoxColumn
            // 
            this.ammount3rdDataGridViewTextBoxColumn.DataPropertyName = "ammount_3rd";
            this.ammount3rdDataGridViewTextBoxColumn.HeaderText = "ammount_3rd";
            this.ammount3rdDataGridViewTextBoxColumn.Name = "ammount3rdDataGridViewTextBoxColumn";
            // 
            // location3rdDataGridViewTextBoxColumn
            // 
            this.location3rdDataGridViewTextBoxColumn.DataPropertyName = "location_3rd";
            this.location3rdDataGridViewTextBoxColumn.HeaderText = "location_3rd";
            this.location3rdDataGridViewTextBoxColumn.Name = "location3rdDataGridViewTextBoxColumn";
            // 
            // topping4thDataGridViewTextBoxColumn
            // 
            this.topping4thDataGridViewTextBoxColumn.DataPropertyName = "topping_4th";
            this.topping4thDataGridViewTextBoxColumn.HeaderText = "topping_4th";
            this.topping4thDataGridViewTextBoxColumn.Name = "topping4thDataGridViewTextBoxColumn";
            // 
            // ammount4thDataGridViewTextBoxColumn
            // 
            this.ammount4thDataGridViewTextBoxColumn.DataPropertyName = "ammount_4th";
            this.ammount4thDataGridViewTextBoxColumn.HeaderText = "ammount_4th";
            this.ammount4thDataGridViewTextBoxColumn.Name = "ammount4thDataGridViewTextBoxColumn";
            // 
            // location4thDataGridViewTextBoxColumn
            // 
            this.location4thDataGridViewTextBoxColumn.DataPropertyName = "location_4th";
            this.location4thDataGridViewTextBoxColumn.HeaderText = "location_4th";
            this.location4thDataGridViewTextBoxColumn.Name = "location4thDataGridViewTextBoxColumn";
            // 
            // PizzasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 336);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PizzasList";
            this.Text = "PizzasList";
            this.Load += new System.EventHandler(this.PizzasList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaRecipiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crustDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sauceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheeseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topping1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammount1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn location1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topping2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammount2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn location2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topping3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammount3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn location3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topping4thDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammount4thDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn location4thDataGridViewTextBoxColumn;
    }
}