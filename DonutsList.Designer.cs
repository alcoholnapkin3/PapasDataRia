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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.papasDatabaseDataSet = new PapasDataRia.PapasDatabaseDataSet();
            this.donutsRecipiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donutsRecipiesTableAdapter = new PapasDataRia.PapasDatabaseDataSetTableAdapters.DonutsRecipiesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dough1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dough2nsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dough3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shape1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shape2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shape3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filling1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filling2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filling3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icingorpowder1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icingorpowder2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icingorpowder3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprinkleordrizzle1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprinkleordrizzle2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprinkleordrizzle3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrasprinkleordrizzle1stDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrasprinkleordrizzle2ndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrasprinkleordrizzle3rdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutsRecipiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dough1stDataGridViewTextBoxColumn,
            this.dough2nsDataGridViewTextBoxColumn,
            this.dough3rdDataGridViewTextBoxColumn,
            this.shape1stDataGridViewTextBoxColumn,
            this.shape2ndDataGridViewTextBoxColumn,
            this.shape3rdDataGridViewTextBoxColumn,
            this.filling1stDataGridViewTextBoxColumn,
            this.filling2ndDataGridViewTextBoxColumn,
            this.filling3rdDataGridViewTextBoxColumn,
            this.icingorpowder1stDataGridViewTextBoxColumn,
            this.icingorpowder2ndDataGridViewTextBoxColumn,
            this.icingorpowder3rdDataGridViewTextBoxColumn,
            this.sprinkleordrizzle1stDataGridViewTextBoxColumn,
            this.sprinkleordrizzle2ndDataGridViewTextBoxColumn,
            this.sprinkleordrizzle3rdDataGridViewTextBoxColumn,
            this.extrasprinkleordrizzle1stDataGridViewTextBoxColumn,
            this.extrasprinkleordrizzle2ndDataGridViewTextBoxColumn,
            this.extrasprinkleordrizzle3rdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donutsRecipiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // papasDatabaseDataSet
            // 
            this.papasDatabaseDataSet.DataSetName = "PapasDatabaseDataSet";
            this.papasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donutsRecipiesBindingSource
            // 
            this.donutsRecipiesBindingSource.DataMember = "DonutsRecipies";
            this.donutsRecipiesBindingSource.DataSource = this.papasDatabaseDataSet;
            // 
            // donutsRecipiesTableAdapter
            // 
            this.donutsRecipiesTableAdapter.ClearBeforeFill = true;
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
            // dough1stDataGridViewTextBoxColumn
            // 
            this.dough1stDataGridViewTextBoxColumn.DataPropertyName = "dough_1st";
            this.dough1stDataGridViewTextBoxColumn.HeaderText = "dough_1st";
            this.dough1stDataGridViewTextBoxColumn.Name = "dough1stDataGridViewTextBoxColumn";
            // 
            // dough2nsDataGridViewTextBoxColumn
            // 
            this.dough2nsDataGridViewTextBoxColumn.DataPropertyName = "dough_2ns";
            this.dough2nsDataGridViewTextBoxColumn.HeaderText = "dough_2ns";
            this.dough2nsDataGridViewTextBoxColumn.Name = "dough2nsDataGridViewTextBoxColumn";
            // 
            // dough3rdDataGridViewTextBoxColumn
            // 
            this.dough3rdDataGridViewTextBoxColumn.DataPropertyName = "dough_3rd";
            this.dough3rdDataGridViewTextBoxColumn.HeaderText = "dough_3rd";
            this.dough3rdDataGridViewTextBoxColumn.Name = "dough3rdDataGridViewTextBoxColumn";
            // 
            // shape1stDataGridViewTextBoxColumn
            // 
            this.shape1stDataGridViewTextBoxColumn.DataPropertyName = "shape_1st";
            this.shape1stDataGridViewTextBoxColumn.HeaderText = "shape_1st";
            this.shape1stDataGridViewTextBoxColumn.Name = "shape1stDataGridViewTextBoxColumn";
            // 
            // shape2ndDataGridViewTextBoxColumn
            // 
            this.shape2ndDataGridViewTextBoxColumn.DataPropertyName = "shape_2nd";
            this.shape2ndDataGridViewTextBoxColumn.HeaderText = "shape_2nd";
            this.shape2ndDataGridViewTextBoxColumn.Name = "shape2ndDataGridViewTextBoxColumn";
            // 
            // shape3rdDataGridViewTextBoxColumn
            // 
            this.shape3rdDataGridViewTextBoxColumn.DataPropertyName = "shape_3rd";
            this.shape3rdDataGridViewTextBoxColumn.HeaderText = "shape_3rd";
            this.shape3rdDataGridViewTextBoxColumn.Name = "shape3rdDataGridViewTextBoxColumn";
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
            // icingorpowder1stDataGridViewTextBoxColumn
            // 
            this.icingorpowder1stDataGridViewTextBoxColumn.DataPropertyName = "icing_or_powder_1st";
            this.icingorpowder1stDataGridViewTextBoxColumn.HeaderText = "icing_or_powder_1st";
            this.icingorpowder1stDataGridViewTextBoxColumn.Name = "icingorpowder1stDataGridViewTextBoxColumn";
            // 
            // icingorpowder2ndDataGridViewTextBoxColumn
            // 
            this.icingorpowder2ndDataGridViewTextBoxColumn.DataPropertyName = "icing_or_powder_2nd";
            this.icingorpowder2ndDataGridViewTextBoxColumn.HeaderText = "icing_or_powder_2nd";
            this.icingorpowder2ndDataGridViewTextBoxColumn.Name = "icingorpowder2ndDataGridViewTextBoxColumn";
            // 
            // icingorpowder3rdDataGridViewTextBoxColumn
            // 
            this.icingorpowder3rdDataGridViewTextBoxColumn.DataPropertyName = "icing_or_powder_3rd";
            this.icingorpowder3rdDataGridViewTextBoxColumn.HeaderText = "icing_or_powder_3rd";
            this.icingorpowder3rdDataGridViewTextBoxColumn.Name = "icingorpowder3rdDataGridViewTextBoxColumn";
            // 
            // sprinkleordrizzle1stDataGridViewTextBoxColumn
            // 
            this.sprinkleordrizzle1stDataGridViewTextBoxColumn.DataPropertyName = "sprinkle_or_drizzle_1st";
            this.sprinkleordrizzle1stDataGridViewTextBoxColumn.HeaderText = "sprinkle_or_drizzle_1st";
            this.sprinkleordrizzle1stDataGridViewTextBoxColumn.Name = "sprinkleordrizzle1stDataGridViewTextBoxColumn";
            // 
            // sprinkleordrizzle2ndDataGridViewTextBoxColumn
            // 
            this.sprinkleordrizzle2ndDataGridViewTextBoxColumn.DataPropertyName = "sprinkle_or_drizzle_2nd";
            this.sprinkleordrizzle2ndDataGridViewTextBoxColumn.HeaderText = "sprinkle_or_drizzle_2nd";
            this.sprinkleordrizzle2ndDataGridViewTextBoxColumn.Name = "sprinkleordrizzle2ndDataGridViewTextBoxColumn";
            // 
            // sprinkleordrizzle3rdDataGridViewTextBoxColumn
            // 
            this.sprinkleordrizzle3rdDataGridViewTextBoxColumn.DataPropertyName = "sprinkle_or_drizzle_3rd";
            this.sprinkleordrizzle3rdDataGridViewTextBoxColumn.HeaderText = "sprinkle_or_drizzle_3rd";
            this.sprinkleordrizzle3rdDataGridViewTextBoxColumn.Name = "sprinkleordrizzle3rdDataGridViewTextBoxColumn";
            // 
            // extrasprinkleordrizzle1stDataGridViewTextBoxColumn
            // 
            this.extrasprinkleordrizzle1stDataGridViewTextBoxColumn.DataPropertyName = "extra_sprinkle_or_drizzle_1st";
            this.extrasprinkleordrizzle1stDataGridViewTextBoxColumn.HeaderText = "extra_sprinkle_or_drizzle_1st";
            this.extrasprinkleordrizzle1stDataGridViewTextBoxColumn.Name = "extrasprinkleordrizzle1stDataGridViewTextBoxColumn";
            // 
            // extrasprinkleordrizzle2ndDataGridViewTextBoxColumn
            // 
            this.extrasprinkleordrizzle2ndDataGridViewTextBoxColumn.DataPropertyName = "extra_sprinkle_or_drizzle_2nd";
            this.extrasprinkleordrizzle2ndDataGridViewTextBoxColumn.HeaderText = "extra_sprinkle_or_drizzle_2nd";
            this.extrasprinkleordrizzle2ndDataGridViewTextBoxColumn.Name = "extrasprinkleordrizzle2ndDataGridViewTextBoxColumn";
            // 
            // extrasprinkleordrizzle3rdDataGridViewTextBoxColumn
            // 
            this.extrasprinkleordrizzle3rdDataGridViewTextBoxColumn.DataPropertyName = "extra_sprinkle_or_drizzle_3rd";
            this.extrasprinkleordrizzle3rdDataGridViewTextBoxColumn.HeaderText = "extra_sprinkle_or_drizzle_3rd";
            this.extrasprinkleordrizzle3rdDataGridViewTextBoxColumn.Name = "extrasprinkleordrizzle3rdDataGridViewTextBoxColumn";
            // 
            // DonutsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 385);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DonutsList";
            this.Text = "DonutsList";
            this.Load += new System.EventHandler(this.DonutsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutsRecipiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PapasDatabaseDataSet papasDatabaseDataSet;
        private System.Windows.Forms.BindingSource donutsRecipiesBindingSource;
        private PapasDatabaseDataSetTableAdapters.DonutsRecipiesTableAdapter donutsRecipiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dough1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dough2nsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dough3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shape1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shape2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shape3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filling1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filling2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filling3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icingorpowder1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icingorpowder2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icingorpowder3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprinkleordrizzle1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprinkleordrizzle2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprinkleordrizzle3rdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrasprinkleordrizzle1stDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrasprinkleordrizzle2ndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrasprinkleordrizzle3rdDataGridViewTextBoxColumn;
    }
}