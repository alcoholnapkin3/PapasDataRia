namespace PapasDataRia
{
    partial class RecipesForm
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
            this.PizzaButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableAdapterManager1 = new PapasDataRia.PapasDatabaseDataSetTableAdapters.TableAdapterManager();
            this.SushiButton = new Guna.UI2.WinForms.Guna2Button();
            this.DonutsButton = new Guna.UI2.WinForms.Guna2Button();
            this.SandwichButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // PizzaButton
            // 
            this.PizzaButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PizzaButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PizzaButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PizzaButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PizzaButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PizzaButton.ForeColor = System.Drawing.Color.White;
            this.PizzaButton.Location = new System.Drawing.Point(12, 19);
            this.PizzaButton.Name = "PizzaButton";
            this.PizzaButton.Size = new System.Drawing.Size(223, 43);
            this.PizzaButton.TabIndex = 5;
            this.PizzaButton.Text = "Пицца";
            this.PizzaButton.Click += new System.EventHandler(this.PizzaButton_Click_1);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DonutDoughsTableAdapter = null;
            this.tableAdapterManager1.DonutFillingsTableAdapter = null;
            this.tableAdapterManager1.DonutIcingsAndPowdersTableAdapter = null;
            this.tableAdapterManager1.DonutShapesTableAdapter = null;
            this.tableAdapterManager1.DonutSprinklesAndDrizzlesTableAdapter = null;
            this.tableAdapterManager1.DonutsRecipiesTableAdapter = null;
            this.tableAdapterManager1.PizzaBakesTableAdapter = null;
            this.tableAdapterManager1.PizzaCheesesTableAdapter = null;
            this.tableAdapterManager1.PizzaCrustsTableAdapter = null;
            this.tableAdapterManager1.PizzaCutsTableAdapter = null;
            this.tableAdapterManager1.PizzaLocationsTableAdapter = null;
            this.tableAdapterManager1.PizzaRecipiesTableAdapter = null;
            this.tableAdapterManager1.PizzaSaucesTableAdapter = null;
            this.tableAdapterManager1.PizzaToppingsTableAdapter = null;
            this.tableAdapterManager1.RegularCustomersTableAdapter = null;
            this.tableAdapterManager1.SandwichBattersAndBreadingsTableAdapter = null;
            this.tableAdapterManager1.SandwichBunsTableAdapter = null;
            this.tableAdapterManager1.SandwichMeatsAndAlternativesTableAdapter = null;
            this.tableAdapterManager1.SandwichRecipiesTableAdapter = null;
            this.tableAdapterManager1.SandwichToppingsAndSaucesTableAdapter = null;
            this.tableAdapterManager1.SlushFlavorsTableAdapter = null;
            this.tableAdapterManager1.SlushSizesTableAdapter = null;
            this.tableAdapterManager1.SushiFillingsTableAdapter = null;
            this.tableAdapterManager1.SushiRecipiesTableAdapter = null;
            this.tableAdapterManager1.SushiRicesTableAdapter = null;
            this.tableAdapterManager1.SushiSauceTableAdapter = null;
            this.tableAdapterManager1.SushiShakersTableAdapter = null;
            this.tableAdapterManager1.SushiToppingsTableAdapter = null;
            this.tableAdapterManager1.SushiWrapsTableAdapter = null;
            this.tableAdapterManager1.TeaBubblesTableAdapter = null;
            this.tableAdapterManager1.TeaFlavorsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PapasDataRia.PapasDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SushiButton
            // 
            this.SushiButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SushiButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SushiButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SushiButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SushiButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SushiButton.ForeColor = System.Drawing.Color.White;
            this.SushiButton.Location = new System.Drawing.Point(258, 19);
            this.SushiButton.Name = "SushiButton";
            this.SushiButton.Size = new System.Drawing.Size(223, 43);
            this.SushiButton.TabIndex = 6;
            this.SushiButton.Text = "Суши";
            this.SushiButton.Click += new System.EventHandler(this.SushiButton_Click_1);
            // 
            // DonutsButton
            // 
            this.DonutsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DonutsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DonutsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DonutsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DonutsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DonutsButton.ForeColor = System.Drawing.Color.White;
            this.DonutsButton.Location = new System.Drawing.Point(12, 88);
            this.DonutsButton.Name = "DonutsButton";
            this.DonutsButton.Size = new System.Drawing.Size(223, 43);
            this.DonutsButton.TabIndex = 7;
            this.DonutsButton.Text = "Пончики";
            this.DonutsButton.Click += new System.EventHandler(this.DonutsButton_Click_1);
            // 
            // SandwichButton
            // 
            this.SandwichButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SandwichButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SandwichButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SandwichButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SandwichButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SandwichButton.ForeColor = System.Drawing.Color.White;
            this.SandwichButton.Location = new System.Drawing.Point(258, 88);
            this.SandwichButton.Name = "SandwichButton";
            this.SandwichButton.Size = new System.Drawing.Size(223, 43);
            this.SandwichButton.TabIndex = 8;
            this.SandwichButton.Text = "Сэндвич";
            this.SandwichButton.Click += new System.EventHandler(this.SandwichButton_Click_1);
            // 
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 155);
            this.Controls.Add(this.SandwichButton);
            this.Controls.Add(this.DonutsButton);
            this.Controls.Add(this.SushiButton);
            this.Controls.Add(this.PizzaButton);
            this.Name = "RecipesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепты";
            this.ResumeLayout(false);

        }

        #endregion
        private PapasDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Guna.UI2.WinForms.Guna2Button PizzaButton;
        private Guna.UI2.WinForms.Guna2Button SushiButton;
        private Guna.UI2.WinForms.Guna2Button DonutsButton;
        private Guna.UI2.WinForms.Guna2Button SandwichButton;
    }
}