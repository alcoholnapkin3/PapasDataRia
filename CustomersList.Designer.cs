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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.dgvCustomersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddCustomerButton = new Guna.UI2.WinForms.Guna2Button();
            this.rbAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbCloseMain = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMinimazeMain = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimazeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomersList.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(185)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomersList.ColumnHeadersHeight = 4;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomersList.Location = new System.Drawing.Point(0, 51);
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomersList.RowHeadersVisible = false;
            this.dgvCustomersList.Size = new System.Drawing.Size(1322, 360);
            this.dgvCustomersList.TabIndex = 0;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvCustomersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomersList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCustomersList.ThemeStyle.ReadOnly = true;
            this.dgvCustomersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvCustomersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomersList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCustomersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BorderRadius = 10;
            this.AddCustomerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCustomerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCustomerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCustomerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCustomerButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.AddCustomerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.Location = new System.Drawing.Point(976, 427);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(232, 45);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Добавить посетителя";
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
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
            this.rbAll.Location = new System.Drawing.Point(598, 437);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(170, 25);
            this.rbAll.TabIndex = 30;
            this.rbAll.Text = " по всем столбцам";
            this.rbAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAll.UncheckedState.BorderThickness = 2;
            this.rbAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
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
            this.rbName.Location = new System.Drawing.Point(473, 437);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(105, 25);
            this.rbName.TabIndex = 28;
            this.rbName.Text = " по имени";
            this.rbName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbName.UncheckedState.BorderThickness = 2;
            this.rbName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Поиск:";
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.BorderRadius = 10;
            this.tbSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchCustomer.DefaultText = "";
            this.tbSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchCustomer.Location = new System.Drawing.Point(121, 427);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.PasswordChar = '\0';
            this.tbSearchCustomer.PlaceholderText = "";
            this.tbSearchCustomer.SelectedText = "";
            this.tbSearchCustomer.Size = new System.Drawing.Size(303, 36);
            this.tbSearchCustomer.TabIndex = 25;
            this.tbSearchCustomer.TextChanged += new System.EventHandler(this.tbSearchCustomer_TextChanged);
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
            this.pbCloseMain.Location = new System.Drawing.Point(1264, 12);
            this.pbCloseMain.Name = "pbCloseMain";
            this.pbCloseMain.Size = new System.Drawing.Size(36, 33);
            this.pbCloseMain.TabIndex = 59;
            this.pbCloseMain.TabStop = false;
            this.pbCloseMain.Click += new System.EventHandler(this.pbCloseMain_Click);
            // 
            // pbMinimazeMain
            // 
            this.pbMinimazeMain.Image = global::PapasDataRia.Properties.Resources.icons8_свернуть_окно_26;
            this.pbMinimazeMain.ImageRotate = 0F;
            this.pbMinimazeMain.Location = new System.Drawing.Point(1231, 12);
            this.pbMinimazeMain.Name = "pbMinimazeMain";
            this.pbMinimazeMain.Size = new System.Drawing.Size(27, 33);
            this.pbMinimazeMain.TabIndex = 60;
            this.pbMinimazeMain.TabStop = false;
            this.pbMinimazeMain.Click += new System.EventHandler(this.pbMinimazeMain_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1322, 501);
            this.Controls.Add(this.pbMinimazeMain);
            this.Controls.Add(this.pbCloseMain);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchCustomer);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.dgvCustomersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimazeMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomersList;
        private Guna.UI2.WinForms.Guna2Button AddCustomerButton;
        private Guna.UI2.WinForms.Guna2RadioButton rbAll;
        private Guna.UI2.WinForms.Guna2RadioButton rbName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchCustomer;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pbCloseMain;
        private Guna.UI2.WinForms.Guna2PictureBox pbMinimazeMain;
    }
}