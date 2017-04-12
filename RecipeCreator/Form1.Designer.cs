namespace RecipeCreator
{
    partial class Form1
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
            this.tabSoup = new System.Windows.Forms.TabPage();
            this.txtSoupRecipes = new System.Windows.Forms.RichTextBox();
            this.lblSoupIngredients = new System.Windows.Forms.Label();
            this.lblSoup = new System.Windows.Forms.Label();
            this.txtSoupIngredients = new System.Windows.Forms.RichTextBox();
            this.lstSoup = new System.Windows.Forms.ListBox();
            this.tabRecipe = new System.Windows.Forms.TabControl();
            this.lblSoupRecipe = new System.Windows.Forms.Label();
            this.tabSoup.SuspendLayout();
            this.tabRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSoup
            // 
            this.tabSoup.Controls.Add(this.lblSoupRecipe);
            this.tabSoup.Controls.Add(this.txtSoupRecipes);
            this.tabSoup.Controls.Add(this.lblSoupIngredients);
            this.tabSoup.Controls.Add(this.lblSoup);
            this.tabSoup.Controls.Add(this.txtSoupIngredients);
            this.tabSoup.Controls.Add(this.lstSoup);
            this.tabSoup.Location = new System.Drawing.Point(4, 25);
            this.tabSoup.Margin = new System.Windows.Forms.Padding(4);
            this.tabSoup.Name = "tabSoup";
            this.tabSoup.Size = new System.Drawing.Size(1621, 701);
            this.tabSoup.TabIndex = 3;
            this.tabSoup.Text = "Soup";
            this.tabSoup.UseVisualStyleBackColor = true;
            // 
            // txtSoupRecipes
            // 
            this.txtSoupRecipes.Location = new System.Drawing.Point(1089, 38);
            this.txtSoupRecipes.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoupRecipes.Name = "txtSoupRecipes";
            this.txtSoupRecipes.Size = new System.Drawing.Size(524, 500);
            this.txtSoupRecipes.TabIndex = 7;
            this.txtSoupRecipes.Text = "";
            // 
            // lblSoupIngredients
            // 
            this.lblSoupIngredients.AutoSize = true;
            this.lblSoupIngredients.Location = new System.Drawing.Point(780, 18);
            this.lblSoupIngredients.Name = "lblSoupIngredients";
            this.lblSoupIngredients.Size = new System.Drawing.Size(112, 16);
            this.lblSoupIngredients.TabIndex = 6;
            this.lblSoupIngredients.Text = "Soup  Ingredients";
            // 
            // lblSoup
            // 
            this.lblSoup.AutoSize = true;
            this.lblSoup.Location = new System.Drawing.Point(235, 18);
            this.lblSoup.Name = "lblSoup";
            this.lblSoup.Size = new System.Drawing.Size(63, 16);
            this.lblSoup.TabIndex = 5;
            this.lblSoup.Text = "Soup List";
            // 
            // txtSoupIngredients
            // 
            this.txtSoupIngredients.Location = new System.Drawing.Point(606, 38);
            this.txtSoupIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoupIngredients.Name = "txtSoupIngredients";
            this.txtSoupIngredients.Size = new System.Drawing.Size(444, 500);
            this.txtSoupIngredients.TabIndex = 4;
            this.txtSoupIngredients.Text = "";
            // 
            // lstSoup
            // 
            this.lstSoup.FormattingEnabled = true;
            this.lstSoup.ItemHeight = 16;
            this.lstSoup.Location = new System.Drawing.Point(20, 38);
            this.lstSoup.Margin = new System.Windows.Forms.Padding(4);
            this.lstSoup.Name = "lstSoup";
            this.lstSoup.Size = new System.Drawing.Size(557, 500);
            this.lstSoup.TabIndex = 1;
            this.lstSoup.SelectedIndexChanged += new System.EventHandler(this.lstSoup_SelectedIndexChanged);
            // 
            // tabRecipe
            // 
            this.tabRecipe.Controls.Add(this.tabSoup);
            this.tabRecipe.Location = new System.Drawing.Point(81, 15);
            this.tabRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.tabRecipe.Name = "tabRecipe";
            this.tabRecipe.SelectedIndex = 0;
            this.tabRecipe.Size = new System.Drawing.Size(1629, 730);
            this.tabRecipe.TabIndex = 0;
            // 
            // lblSoupRecipe
            // 
            this.lblSoupRecipe.AutoSize = true;
            this.lblSoupRecipe.Location = new System.Drawing.Point(1328, 18);
            this.lblSoupRecipe.Name = "lblSoupRecipe";
            this.lblSoupRecipe.Size = new System.Drawing.Size(90, 16);
            this.lblSoupRecipe.TabIndex = 8;
            this.lblSoupRecipe.Text = "Soup  Recipe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 747);
            this.Controls.Add(this.tabRecipe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabSoup.ResumeLayout(false);
            this.tabSoup.PerformLayout();
            this.tabRecipe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabSoup;
        private System.Windows.Forms.RichTextBox txtSoupIngredients;
        private System.Windows.Forms.ListBox lstSoup;
        private System.Windows.Forms.TabControl tabRecipe;
        private System.Windows.Forms.Label lblSoupIngredients;
        private System.Windows.Forms.Label lblSoup;
        private System.Windows.Forms.RichTextBox txtSoupRecipes;
        private System.Windows.Forms.Label lblSoupRecipe;
    }
}

