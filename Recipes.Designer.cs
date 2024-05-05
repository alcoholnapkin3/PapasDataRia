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
            this.PizzaButton = new System.Windows.Forms.Button();
            this.SushiButton = new System.Windows.Forms.Button();
            this.DonutsButton = new System.Windows.Forms.Button();
            this.SandwichButton = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new PapasDataRia.PapasDatabaseDataSetTableAdapters.TableAdapterManager();
            this.SuspendLayout();
            // 
            // PizzaButton
            // 
            this.PizzaButton.Location = new System.Drawing.Point(12, 12);
            this.PizzaButton.Name = "PizzaButton";
            this.PizzaButton.Size = new System.Drawing.Size(168, 50);
            this.PizzaButton.TabIndex = 0;
            this.PizzaButton.Text = "Пицца";
            this.PizzaButton.UseVisualStyleBackColor = true;
            this.PizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // SushiButton
            // 
            this.SushiButton.Location = new System.Drawing.Point(202, 12);
            this.SushiButton.Name = "SushiButton";
            this.SushiButton.Size = new System.Drawing.Size(168, 50);
            this.SushiButton.TabIndex = 1;
            this.SushiButton.Text = "Суши";
            this.SushiButton.UseVisualStyleBackColor = true;
            this.SushiButton.Click += new System.EventHandler(this.SushiButton_Click);
            // 
            // DonutsButton
            // 
            this.DonutsButton.Location = new System.Drawing.Point(12, 81);
            this.DonutsButton.Name = "DonutsButton";
            this.DonutsButton.Size = new System.Drawing.Size(168, 50);
            this.DonutsButton.TabIndex = 3;
            this.DonutsButton.Text = "Пончики";
            this.DonutsButton.UseVisualStyleBackColor = true;
            this.DonutsButton.Click += new System.EventHandler(this.DonutsButton_Click);
            // 
            // SandwichButton
            // 
            this.SandwichButton.Location = new System.Drawing.Point(202, 81);
            this.SandwichButton.Name = "SandwichButton";
            this.SandwichButton.Size = new System.Drawing.Size(168, 50);
            this.SandwichButton.TabIndex = 4;
            this.SandwichButton.Text = "Сэндвич";
            this.SandwichButton.UseVisualStyleBackColor = true;
            this.SandwichButton.Click += new System.EventHandler(this.SandwichButton_Click);
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
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 162);
            this.Controls.Add(this.SandwichButton);
            this.Controls.Add(this.DonutsButton);
            this.Controls.Add(this.SushiButton);
            this.Controls.Add(this.PizzaButton);
            this.Name = "RecipesForm";
            this.Text = "Recipes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PizzaButton;
        private System.Windows.Forms.Button SushiButton;
        private System.Windows.Forms.Button DonutsButton;
        private System.Windows.Forms.Button SandwichButton;
        private PapasDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}