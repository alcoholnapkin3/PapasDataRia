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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddPizzaButton = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPizzasList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbSearchPizza = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzasList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPizzaButton
            // 
            this.AddPizzaButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPizzaButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPizzaButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPizzaButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPizzaButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddPizzaButton.ForeColor = System.Drawing.Color.White;
            this.AddPizzaButton.Location = new System.Drawing.Point(803, 422);
            this.AddPizzaButton.Name = "AddPizzaButton";
            this.AddPizzaButton.Size = new System.Drawing.Size(180, 45);
            this.AddPizzaButton.TabIndex = 1;
            this.AddPizzaButton.Text = "Добавить рецепт пиццы";
            this.AddPizzaButton.Click += new System.EventHandler(this.AddPizzaButton_Click);
            // 
            // dgvPizzasList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPizzasList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPizzasList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPizzasList.ColumnHeadersHeight = 4;
            this.dgvPizzasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPizzasList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPizzasList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPizzasList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPizzasList.Location = new System.Drawing.Point(0, 0);
            this.dgvPizzasList.Name = "dgvPizzasList";
            this.dgvPizzasList.ReadOnly = true;
            this.dgvPizzasList.RowHeadersVisible = false;
            this.dgvPizzasList.Size = new System.Drawing.Size(1144, 373);
            this.dgvPizzasList.TabIndex = 2;
            this.dgvPizzasList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPizzasList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPizzasList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPizzasList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPizzasList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPizzasList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPizzasList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPizzasList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPizzasList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPizzasList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvPizzasList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPizzasList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPizzasList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPizzasList.ThemeStyle.ReadOnly = true;
            this.dgvPizzasList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPizzasList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPizzasList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvPizzasList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPizzasList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPizzasList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPizzasList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tbSearchPizza
            // 
            this.tbSearchPizza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchPizza.DefaultText = "";
            this.tbSearchPizza.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchPizza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchPizza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPizza.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPizza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchPizza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearchPizza.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchPizza.Location = new System.Drawing.Point(82, 422);
            this.tbSearchPizza.Name = "tbSearchPizza";
            this.tbSearchPizza.PasswordChar = '\0';
            this.tbSearchPizza.PlaceholderText = "";
            this.tbSearchPizza.SelectedText = "";
            this.tbSearchPizza.Size = new System.Drawing.Size(303, 36);
            this.tbSearchPizza.TabIndex = 3;
            this.tbSearchPizza.TextChanged += new System.EventHandler(this.tbSearchPizza_TextChanged);
            // 
            // PizzasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 510);
            this.Controls.Add(this.tbSearchPizza);
            this.Controls.Add(this.dgvPizzasList);
            this.Controls.Add(this.AddPizzaButton);
            this.Name = "PizzasList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепты пиццы";
            this.Load += new System.EventHandler(this.PizzasList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzasList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddPizzaButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPizzasList;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchPizza;
    }
}