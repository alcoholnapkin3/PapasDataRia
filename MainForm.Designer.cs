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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CustomersButton = new Guna.UI2.WinForms.Guna2Button();
            this.RecipiesButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbCloseMain = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMinimazeMain = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimazeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.BorderRadius = 10;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.ImageRotate = 0F;
            this.PictureBox1.InitialImage = null;
            this.PictureBox1.Location = new System.Drawing.Point(6, 51);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(700, 226);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // CustomersButton
            // 
            this.CustomersButton.BorderRadius = 10;
            this.CustomersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomersButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.CustomersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Location = new System.Drawing.Point(128, 295);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(180, 45);
            this.CustomersButton.TabIndex = 5;
            this.CustomersButton.Text = "Посетители";
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // RecipiesButton
            // 
            this.RecipiesButton.BorderRadius = 10;
            this.RecipiesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RecipiesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RecipiesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RecipiesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RecipiesButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.RecipiesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipiesButton.ForeColor = System.Drawing.Color.White;
            this.RecipiesButton.Location = new System.Drawing.Point(421, 295);
            this.RecipiesButton.Name = "RecipiesButton";
            this.RecipiesButton.Size = new System.Drawing.Size(180, 45);
            this.RecipiesButton.TabIndex = 6;
            this.RecipiesButton.Text = "Рецепты";
            this.RecipiesButton.Click += new System.EventHandler(this.RecipiesButton_Click_1);
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
            this.pbCloseMain.Location = new System.Drawing.Point(670, 12);
            this.pbCloseMain.Name = "pbCloseMain";
            this.pbCloseMain.Size = new System.Drawing.Size(36, 33);
            this.pbCloseMain.TabIndex = 10;
            this.pbCloseMain.TabStop = false;
            this.pbCloseMain.Click += new System.EventHandler(this.pbCloseMain_Click);
            // 
            // pbMinimazeMain
            // 
            this.pbMinimazeMain.Image = global::PapasDataRia.Properties.Resources.icons8_свернуть_окно_26;
            this.pbMinimazeMain.ImageRotate = 0F;
            this.pbMinimazeMain.Location = new System.Drawing.Point(637, 12);
            this.pbMinimazeMain.Name = "pbMinimazeMain";
            this.pbMinimazeMain.Size = new System.Drawing.Size(27, 33);
            this.pbMinimazeMain.TabIndex = 11;
            this.pbMinimazeMain.TabStop = false;
            this.pbMinimazeMain.Click += new System.EventHandler(this.pbMinimazeMain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(712, 358);
            this.Controls.Add(this.pbMinimazeMain);
            this.Controls.Add(this.pbCloseMain);
            this.Controls.Add(this.RecipiesButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimazeMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2Button CustomersButton;
        private Guna.UI2.WinForms.Guna2Button RecipiesButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pbCloseMain;
        private Guna.UI2.WinForms.Guna2PictureBox pbMinimazeMain;
    }
}

