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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddDonutButton = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDonutsList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonutsList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDonutButton
            // 
            this.AddDonutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddDonutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddDonutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddDonutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddDonutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddDonutButton.ForeColor = System.Drawing.Color.White;
            this.AddDonutButton.Location = new System.Drawing.Point(753, 403);
            this.AddDonutButton.Name = "AddDonutButton";
            this.AddDonutButton.Size = new System.Drawing.Size(203, 44);
            this.AddDonutButton.TabIndex = 1;
            this.AddDonutButton.Text = "Добавить рецепт пончиков";
            this.AddDonutButton.Click += new System.EventHandler(this.AddDonutButton_Click);
            // 
            // dgvDonutsList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDonutsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonutsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonutsList.ColumnHeadersHeight = 4;
            this.dgvDonutsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonutsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonutsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonutsList.Location = new System.Drawing.Point(1, 0);
            this.dgvDonutsList.Name = "dgvDonutsList";
            this.dgvDonutsList.ReadOnly = true;
            this.dgvDonutsList.RowHeadersVisible = false;
            this.dgvDonutsList.Size = new System.Drawing.Size(1136, 397);
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
            // DonutsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 459);
            this.Controls.Add(this.dgvDonutsList);
            this.Controls.Add(this.AddDonutButton);
            this.Name = "DonutsList";
            this.Text = "DonutsList";
            this.Load += new System.EventHandler(this.DonutsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonutsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddDonutButton;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonutsList;
    }
}