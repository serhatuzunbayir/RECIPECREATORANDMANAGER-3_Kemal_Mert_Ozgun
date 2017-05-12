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
            this.lblSoupRecipe = new System.Windows.Forms.Label();
            this.txtSoupRecipes = new System.Windows.Forms.RichTextBox();
            this.lblSoupIngredients = new System.Windows.Forms.Label();
            this.lblSoup = new System.Windows.Forms.Label();
            this.txtSoupIngredients = new System.Windows.Forms.RichTextBox();
            this.lstSoup = new System.Windows.Forms.ListBox();
            this.tabRecipe = new System.Windows.Forms.TabControl();
            this.txtImgSoupList = new System.Windows.Forms.RichTextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.tabSoup.SuspendLayout();
            this.tabRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSoup
            // 
            this.tabSoup.Controls.Add(this.lblImage);
            this.tabSoup.Controls.Add(this.txtImgSoupList);
            this.tabSoup.Controls.Add(this.lblSoupRecipe);
            this.tabSoup.Controls.Add(this.txtSoupRecipes);
            this.tabSoup.Controls.Add(this.lblSoupIngredients);
            this.tabSoup.Controls.Add(this.lblSoup);
            this.tabSoup.Controls.Add(this.txtSoupIngredients);
            this.tabSoup.Controls.Add(this.lstSoup);
            this.tabSoup.Location = new System.Drawing.Point(4, 22);
            this.tabSoup.Name = "tabSoup";
            this.tabSoup.Size = new System.Drawing.Size(1214, 567);
            this.tabSoup.TabIndex = 3;
            this.tabSoup.Text = "Soup";
            this.tabSoup.UseVisualStyleBackColor = true;
            // 
            // lblSoupRecipe
            // 
            this.lblSoupRecipe.AutoSize = true;
            this.lblSoupRecipe.Location = new System.Drawing.Point(582, 15);
            this.lblSoupRecipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoupRecipe.Name = "lblSoupRecipe";
            this.lblSoupRecipe.Size = new System.Drawing.Size(72, 13);
            this.lblSoupRecipe.TabIndex = 8;
            this.lblSoupRecipe.Text = "Soup  Recipe";
            // 
            // txtSoupRecipes
            // 
            this.txtSoupRecipes.Location = new System.Drawing.Point(514, 31);
            this.txtSoupRecipes.Name = "txtSoupRecipes";
            this.txtSoupRecipes.Size = new System.Drawing.Size(258, 407);
            this.txtSoupRecipes.TabIndex = 7;
            this.txtSoupRecipes.Text = "";
            // 
            // lblSoupIngredients
            // 
            this.lblSoupIngredients.AutoSize = true;
            this.lblSoupIngredients.Location = new System.Drawing.Point(317, 15);
            this.lblSoupIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoupIngredients.Name = "lblSoupIngredients";
            this.lblSoupIngredients.Size = new System.Drawing.Size(90, 13);
            this.lblSoupIngredients.TabIndex = 6;
            this.lblSoupIngredients.Text = "Soup  Ingredients";
            // 
            // lblSoup
            // 
            this.lblSoup.AutoSize = true;
            this.lblSoup.Location = new System.Drawing.Point(77, 15);
            this.lblSoup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoup.Name = "lblSoup";
            this.lblSoup.Size = new System.Drawing.Size(51, 13);
            this.lblSoup.TabIndex = 5;
            this.lblSoup.Text = "Soup List";
            // 
            // txtSoupIngredients
            // 
            this.txtSoupIngredients.Location = new System.Drawing.Point(268, 31);
            this.txtSoupIngredients.Name = "txtSoupIngredients";
            this.txtSoupIngredients.Size = new System.Drawing.Size(240, 407);
            this.txtSoupIngredients.TabIndex = 4;
            this.txtSoupIngredients.Text = "";
            // 
            // lstSoup
            // 
            this.lstSoup.FormattingEnabled = true;
            this.lstSoup.Location = new System.Drawing.Point(15, 31);
            this.lstSoup.Name = "lstSoup";
            this.lstSoup.Size = new System.Drawing.Size(236, 407);
            this.lstSoup.TabIndex = 1;
            this.lstSoup.SelectedIndexChanged += new System.EventHandler(this.lstSoup_SelectedIndexChanged);
            // 
            // tabRecipe
            // 
            this.tabRecipe.Controls.Add(this.tabSoup);
            this.tabRecipe.Location = new System.Drawing.Point(61, 12);
            this.tabRecipe.Name = "tabRecipe";
            this.tabRecipe.SelectedIndex = 0;
            this.tabRecipe.Size = new System.Drawing.Size(1222, 593);
            this.tabRecipe.TabIndex = 0;
            // 
            // txtImgSoupList
            // 
            this.txtImgSoupList.Location = new System.Drawing.Point(796, 31);
            this.txtImgSoupList.Name = "txtImgSoupList";
            this.txtImgSoupList.Size = new System.Drawing.Size(258, 407);
            this.txtImgSoupList.TabIndex = 9;
            this.txtImgSoupList.Text = "";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(916, 15);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 607);
            this.Controls.Add(this.tabRecipe);
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
        private System.Windows.Forms.RichTextBox txtImgSoupList;
        private System.Windows.Forms.Label lblImage;
    }
}

