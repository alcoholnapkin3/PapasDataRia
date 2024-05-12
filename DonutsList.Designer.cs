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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonutsList));
            this.AddDonutButton = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDonutsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.rbAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbToppings = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbID = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchDonuts = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbCloseMain = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMinimazeMain = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonutsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimazeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDonutButton
            // 
            this.AddDonutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddDonutButton.BorderRadius = 10;
            this.AddDonutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddDonutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddDonutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddDonutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddDonutButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.AddDonutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDonutButton.ForeColor = System.Drawing.Color.White;
            this.AddDonutButton.Location = new System.Drawing.Point(1343, 423);
            this.AddDonutButton.Name = "AddDonutButton";
            this.AddDonutButton.Size = new System.Drawing.Size(258, 44);
            this.AddDonutButton.TabIndex = 1;
            this.AddDonutButton.Text = "Добавить рецепт пончиков";
            this.AddDonutButton.Click += new System.EventHandler(this.AddDonutButton_Click);
            // 
            // dgvDonutsList
            // 
            this.dgvDonutsList.AllowUserToAddRows = false;
            this.dgvDonutsList.AllowUserToDeleteRows = false;
            this.dgvDonutsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonutsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonutsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDonutsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonutsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonutsList.ColumnHeadersHeight = 4;
            this.dgvDonutsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonutsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonutsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonutsList.Location = new System.Drawing.Point(0, 51);
            this.dgvDonutsList.Name = "dgvDonutsList";
            this.dgvDonutsList.ReadOnly = true;
            this.dgvDonutsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonutsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDonutsList.RowHeadersVisible = false;
            this.dgvDonutsList.Size = new System.Drawing.Size(1904, 331);
            this.dgvDonutsList.TabIndex = 2;
            this.dgvDonutsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonutsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDonutsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDonutsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDonutsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDonutsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonutsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonutsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDonutsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonutsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvDonutsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonutsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDonutsList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDonutsList.ThemeStyle.ReadOnly = true;
            this.dgvDonutsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonutsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonutsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvDonutsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonutsList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDonutsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonutsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.CheckedState.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.rbAll.CheckedState.BorderThickness = 0;
            this.rbAll.CheckedState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.rbAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAll.CheckedState.InnerOffset = -4;
            this.rbAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbAll.Location = new System.Drawing.Point(574, 423);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(166, 25);
            this.rbAll.TabIndex = 18;
            this.rbAll.Text = "по всем столбцам";
            this.rbAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAll.UncheckedState.BorderThickness = 2;
            this.rbAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbToppings
            // 
            this.rbToppings.AutoSize = true;
            this.rbToppings.CheckedState.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.rbToppings.CheckedState.BorderThickness = 0;
            this.rbToppings.CheckedState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.rbToppings.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbToppings.CheckedState.InnerOffset = -4;
            this.rbToppings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbToppings.Location = new System.Drawing.Point(574, 454);
            this.rbToppings.Name = "rbToppings";
            this.rbToppings.Size = new System.Drawing.Size(123, 25);
            this.rbToppings.TabIndex = 17;
            this.rbToppings.Text = " по топпингу";
            this.rbToppings.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbToppings.UncheckedState.BorderThickness = 2;
            this.rbToppings.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbToppings.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbToppings.CheckedChanged += new System.EventHandler(this.rbToppings_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.CheckedState.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.rbName.CheckedState.BorderThickness = 0;
            this.rbName.CheckedState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.rbName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbName.CheckedState.InnerOffset = -4;
            this.rbName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbName.Location = new System.Drawing.Point(439, 454);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(129, 25);
            this.rbName.TabIndex = 16;
            this.rbName.Text = " по названию";
            this.rbName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbName.UncheckedState.BorderThickness = 2;
            this.rbName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.CheckedState.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.rbID.CheckedState.BorderThickness = 0;
            this.rbID.CheckedState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.rbID.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbID.CheckedState.InnerOffset = -4;
            this.rbID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbID.Location = new System.Drawing.Point(439, 423);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(71, 25);
            this.rbID.TabIndex = 15;
            this.rbID.Text = " по ID";
            this.rbID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbID.UncheckedState.BorderThickness = 2;
            this.rbID.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbID.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поиск:";
            // 
            // tbSearchDonuts
            // 
            this.tbSearchDonuts.BorderRadius = 10;
            this.tbSearchDonuts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchDonuts.DefaultText = "";
            this.tbSearchDonuts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchDonuts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchDonuts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchDonuts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchDonuts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchDonuts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearchDonuts.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchDonuts.Location = new System.Drawing.Point(90, 423);
            this.tbSearchDonuts.Name = "tbSearchDonuts";
            this.tbSearchDonuts.PasswordChar = '\0';
            this.tbSearchDonuts.PlaceholderText = "";
            this.tbSearchDonuts.SelectedText = "";
            this.tbSearchDonuts.Size = new System.Drawing.Size(303, 36);
            this.tbSearchDonuts.TabIndex = 13;
            this.tbSearchDonuts.TextChanged += new System.EventHandler(this.tbSearchDonuts_TextChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pbCloseMain
            // 
            this.pbCloseMain.Image = global::PapasDataRia.Properties.Resources.icons8_закрыть_окно_26;
            this.pbCloseMain.ImageRotate = 0F;
            this.pbCloseMain.Location = new System.Drawing.Point(1841, 12);
            this.pbCloseMain.Name = "pbCloseMain";
            this.pbCloseMain.Size = new System.Drawing.Size(36, 33);
            this.pbCloseMain.TabIndex = 26;
            this.pbCloseMain.TabStop = false;
            this.pbCloseMain.Click += new System.EventHandler(this.pbCloseMain_Click);
            // 
            // pbMinimazeMain
            // 
            this.pbMinimazeMain.Image = global::PapasDataRia.Properties.Resources.icons8_свернуть_окно_26;
            this.pbMinimazeMain.ImageRotate = 0F;
            this.pbMinimazeMain.Location = new System.Drawing.Point(1808, 12);
            this.pbMinimazeMain.Name = "pbMinimazeMain";
            this.pbMinimazeMain.Size = new System.Drawing.Size(27, 33);
            this.pbMinimazeMain.TabIndex = 27;
            this.pbMinimazeMain.TabStop = false;
            this.pbMinimazeMain.Click += new System.EventHandler(this.pbMinimazeMain_Click);
            // 
            // DonutsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1904, 512);
            this.Controls.Add(this.pbMinimazeMain);
            this.Controls.Add(this.pbCloseMain);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbToppings);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.rbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchDonuts);
            this.Controls.Add(this.dgvDonutsList);
            this.Controls.Add(this.AddDonutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonutsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепты пончиков";
            this.Load += new System.EventHandler(this.DonutsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonutsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimazeMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddDonutButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonutsList;
        private Guna.UI2.WinForms.Guna2RadioButton rbAll;
        private Guna.UI2.WinForms.Guna2RadioButton rbToppings;
        private Guna.UI2.WinForms.Guna2RadioButton rbName;
        private Guna.UI2.WinForms.Guna2RadioButton rbID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchDonuts;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pbCloseMain;
        private Guna.UI2.WinForms.Guna2PictureBox pbMinimazeMain;
    }
}