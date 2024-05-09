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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddPizzaButton = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPizzasList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbSearchPizza = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbID = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbToppings = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAll = new Guna.UI2.WinForms.Guna2RadioButton();
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
            this.AddPizzaButton.Location = new System.Drawing.Point(834, 422);
            this.AddPizzaButton.Name = "AddPizzaButton";
            this.AddPizzaButton.Size = new System.Drawing.Size(180, 45);
            this.AddPizzaButton.TabIndex = 1;
            this.AddPizzaButton.Text = "Добавить рецепт пиццы";
            this.AddPizzaButton.Click += new System.EventHandler(this.AddPizzaButton_Click);
            // 
            // dgvPizzasList
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvPizzasList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPizzasList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPizzasList.ColumnHeadersHeight = 4;
            this.dgvPizzasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPizzasList.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.tbSearchPizza.Location = new System.Drawing.Point(73, 422);
            this.tbSearchPizza.Name = "tbSearchPizza";
            this.tbSearchPizza.PasswordChar = '\0';
            this.tbSearchPizza.PlaceholderText = "";
            this.tbSearchPizza.SelectedText = "";
            this.tbSearchPizza.Size = new System.Drawing.Size(303, 36);
            this.tbSearchPizza.TabIndex = 3;
            this.tbSearchPizza.TextChanged += new System.EventHandler(this.tbSearchPizza_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск:";
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbID.CheckedState.BorderThickness = 0;
            this.rbID.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbID.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbID.CheckedState.InnerOffset = -4;
            this.rbID.Location = new System.Drawing.Point(408, 413);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(54, 17);
            this.rbID.TabIndex = 5;
            this.rbID.Text = " по ID";
            this.rbID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbID.UncheckedState.BorderThickness = 2;
            this.rbID.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbID.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbName.CheckedState.BorderThickness = 0;
            this.rbName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbName.CheckedState.InnerOffset = -4;
            this.rbName.Location = new System.Drawing.Point(408, 450);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(93, 17);
            this.rbName.TabIndex = 6;
            this.rbName.Text = " по названию";
            this.rbName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbName.UncheckedState.BorderThickness = 2;
            this.rbName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbToppings
            // 
            this.rbToppings.AutoSize = true;
            this.rbToppings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbToppings.CheckedState.BorderThickness = 0;
            this.rbToppings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbToppings.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbToppings.CheckedState.InnerOffset = -4;
            this.rbToppings.Location = new System.Drawing.Point(520, 450);
            this.rbToppings.Name = "rbToppings";
            this.rbToppings.Size = new System.Drawing.Size(84, 17);
            this.rbToppings.TabIndex = 7;
            this.rbToppings.Text = " по начинке";
            this.rbToppings.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbToppings.UncheckedState.BorderThickness = 2;
            this.rbToppings.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbToppings.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbToppings.CheckedChanged += new System.EventHandler(this.rbToppings_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAll.CheckedState.BorderThickness = 0;
            this.rbAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAll.CheckedState.InnerOffset = -4;
            this.rbAll.Location = new System.Drawing.Point(520, 413);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(118, 17);
            this.rbAll.TabIndex = 8;
            this.rbAll.Text = "по всем столбцам";
            this.rbAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAll.UncheckedState.BorderThickness = 2;
            this.rbAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // PizzasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 510);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbToppings);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.rbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchPizza);
            this.Controls.Add(this.dgvPizzasList);
            this.Controls.Add(this.AddPizzaButton);
            this.Name = "PizzasList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепты пиццы";
            this.Load += new System.EventHandler(this.PizzasList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzasList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddPizzaButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPizzasList;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchPizza;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton rbID;
        private Guna.UI2.WinForms.Guna2RadioButton rbName;
        private Guna.UI2.WinForms.Guna2RadioButton rbToppings;
        private Guna.UI2.WinForms.Guna2RadioButton rbAll;
    }
}