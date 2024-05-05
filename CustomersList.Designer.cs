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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favpizzarecipieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favpizzabakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favpizzacutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favsushirecipieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favbubbleteaflavorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favbubbleteabubblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favdonutsrecipieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favsandwichrecipieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favslushsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favslushbottomflavorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favslushtopflavorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regularCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.papasDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regularCustomersTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter();
            this.regularCustomersTableAdapter1 = new PapasDataRia.PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(596, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customernameDataGridViewTextBoxColumn,
            this.favpizzarecipieDataGridViewTextBoxColumn,
            this.favpizzabakeDataGridViewTextBoxColumn,
            this.favpizzacutDataGridViewTextBoxColumn,
            this.favsushirecipieDataGridViewTextBoxColumn,
            this.favbubbleteaflavorDataGridViewTextBoxColumn,
            this.favbubbleteabubblesDataGridViewTextBoxColumn,
            this.favdonutsrecipieDataGridViewTextBoxColumn,
            this.favsandwichrecipieDataGridViewTextBoxColumn,
            this.favslushsizeDataGridViewTextBoxColumn,
            this.favslushbottomflavorDataGridViewTextBoxColumn,
            this.favslushtopflavorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regularCustomersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // favpizzarecipieDataGridViewTextBoxColumn
            // 
            this.favpizzarecipieDataGridViewTextBoxColumn.DataPropertyName = "fav_pizza_recipie";
            this.favpizzarecipieDataGridViewTextBoxColumn.HeaderText = "fav_pizza_recipie";
            this.favpizzarecipieDataGridViewTextBoxColumn.Name = "favpizzarecipieDataGridViewTextBoxColumn";
            // 
            // favpizzabakeDataGridViewTextBoxColumn
            // 
            this.favpizzabakeDataGridViewTextBoxColumn.DataPropertyName = "fav_pizza_bake";
            this.favpizzabakeDataGridViewTextBoxColumn.HeaderText = "fav_pizza_bake";
            this.favpizzabakeDataGridViewTextBoxColumn.Name = "favpizzabakeDataGridViewTextBoxColumn";
            // 
            // favpizzacutDataGridViewTextBoxColumn
            // 
            this.favpizzacutDataGridViewTextBoxColumn.DataPropertyName = "fav_pizza_cut";
            this.favpizzacutDataGridViewTextBoxColumn.HeaderText = "fav_pizza_cut";
            this.favpizzacutDataGridViewTextBoxColumn.Name = "favpizzacutDataGridViewTextBoxColumn";
            // 
            // favsushirecipieDataGridViewTextBoxColumn
            // 
            this.favsushirecipieDataGridViewTextBoxColumn.DataPropertyName = "fav_sushi_recipie";
            this.favsushirecipieDataGridViewTextBoxColumn.HeaderText = "fav_sushi_recipie";
            this.favsushirecipieDataGridViewTextBoxColumn.Name = "favsushirecipieDataGridViewTextBoxColumn";
            // 
            // favbubbleteaflavorDataGridViewTextBoxColumn
            // 
            this.favbubbleteaflavorDataGridViewTextBoxColumn.DataPropertyName = "fav_bubbletea_flavor";
            this.favbubbleteaflavorDataGridViewTextBoxColumn.HeaderText = "fav_bubbletea_flavor";
            this.favbubbleteaflavorDataGridViewTextBoxColumn.Name = "favbubbleteaflavorDataGridViewTextBoxColumn";
            // 
            // favbubbleteabubblesDataGridViewTextBoxColumn
            // 
            this.favbubbleteabubblesDataGridViewTextBoxColumn.DataPropertyName = "fav_bubbletea_bubbles";
            this.favbubbleteabubblesDataGridViewTextBoxColumn.HeaderText = "fav_bubbletea_bubbles";
            this.favbubbleteabubblesDataGridViewTextBoxColumn.Name = "favbubbleteabubblesDataGridViewTextBoxColumn";
            // 
            // favdonutsrecipieDataGridViewTextBoxColumn
            // 
            this.favdonutsrecipieDataGridViewTextBoxColumn.DataPropertyName = "fav_donuts_recipie";
            this.favdonutsrecipieDataGridViewTextBoxColumn.HeaderText = "fav_donuts_recipie";
            this.favdonutsrecipieDataGridViewTextBoxColumn.Name = "favdonutsrecipieDataGridViewTextBoxColumn";
            // 
            // favsandwichrecipieDataGridViewTextBoxColumn
            // 
            this.favsandwichrecipieDataGridViewTextBoxColumn.DataPropertyName = "fav_sandwich_recipie";
            this.favsandwichrecipieDataGridViewTextBoxColumn.HeaderText = "fav_sandwich_recipie";
            this.favsandwichrecipieDataGridViewTextBoxColumn.Name = "favsandwichrecipieDataGridViewTextBoxColumn";
            // 
            // favslushsizeDataGridViewTextBoxColumn
            // 
            this.favslushsizeDataGridViewTextBoxColumn.DataPropertyName = "fav_slush_size";
            this.favslushsizeDataGridViewTextBoxColumn.HeaderText = "fav_slush_size";
            this.favslushsizeDataGridViewTextBoxColumn.Name = "favslushsizeDataGridViewTextBoxColumn";
            // 
            // favslushbottomflavorDataGridViewTextBoxColumn
            // 
            this.favslushbottomflavorDataGridViewTextBoxColumn.DataPropertyName = "fav_slush_bottom_flavor";
            this.favslushbottomflavorDataGridViewTextBoxColumn.HeaderText = "fav_slush_bottom_flavor";
            this.favslushbottomflavorDataGridViewTextBoxColumn.Name = "favslushbottomflavorDataGridViewTextBoxColumn";
            // 
            // favslushtopflavorDataGridViewTextBoxColumn
            // 
            this.favslushtopflavorDataGridViewTextBoxColumn.DataPropertyName = "fav_slush_top_flavor";
            this.favslushtopflavorDataGridViewTextBoxColumn.HeaderText = "fav_slush_top_flavor";
            this.favslushtopflavorDataGridViewTextBoxColumn.Name = "favslushtopflavorDataGridViewTextBoxColumn";
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
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource papasDatabaseDataSetBindingSource;
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource regularCustomersBindingSource;
        private PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter regularCustomersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favpizzarecipieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favpizzabakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favpizzacutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favsushirecipieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favbubbleteaflavorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favbubbleteabubblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favdonutsrecipieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favsandwichrecipieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favslushsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favslushbottomflavorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favslushtopflavorDataGridViewTextBoxColumn;
        private PapasDatabaseDataSetTableAdapters.RegularCustomersTableAdapter regularCustomersTableAdapter1;
    }
}