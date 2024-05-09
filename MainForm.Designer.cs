namespace PapasDataRia
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomersButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RecipiesButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // CustomersButton
            // 
            this.CustomersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomersButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomersButton.FillColor = System.Drawing.Color.LemonChiffon;
            this.CustomersButton.FillColor2 = System.Drawing.Color.Tomato;
            this.CustomersButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Location = new System.Drawing.Point(142, 23);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(180, 45);
            this.CustomersButton.TabIndex = 2;
            this.CustomersButton.Text = "Посетители";
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click_1);
            // 
            // RecipiesButton
            // 
            this.RecipiesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RecipiesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RecipiesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RecipiesButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RecipiesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RecipiesButton.FillColor = System.Drawing.Color.LemonChiffon;
            this.RecipiesButton.FillColor2 = System.Drawing.Color.Tomato;
            this.RecipiesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RecipiesButton.ForeColor = System.Drawing.Color.White;
            this.RecipiesButton.Location = new System.Drawing.Point(142, 92);
            this.RecipiesButton.Name = "RecipiesButton";
            this.RecipiesButton.Size = new System.Drawing.Size(180, 45);
            this.RecipiesButton.TabIndex = 3;
            this.RecipiesButton.Text = "Рецепты";
            this.RecipiesButton.Click += new System.EventHandler(this.RecipiesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 173);
            this.Controls.Add(this.RecipiesButton);
            this.Controls.Add(this.CustomersButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton CustomersButton;
        private Guna.UI2.WinForms.Guna2GradientButton RecipiesButton;
    }
}

