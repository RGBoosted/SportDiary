﻿
namespace SportDiary.Forms
{
    partial class AddMealForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.ProductsToAdd = new System.Windows.Forms.CheckedListBox();
            this.AddedProducts = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(248, 142);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(66, 37);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = ">";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ProductsToAdd
            // 
            this.ProductsToAdd.FormattingEnabled = true;
            this.ProductsToAdd.Location = new System.Drawing.Point(23, 12);
            this.ProductsToAdd.Name = "ProductsToAdd";
            this.ProductsToAdd.Size = new System.Drawing.Size(219, 276);
            this.ProductsToAdd.TabIndex = 2;
            // 
            // AddedProducts
            // 
            this.AddedProducts.FormattingEnabled = true;
            this.AddedProducts.Location = new System.Drawing.Point(320, 12);
            this.AddedProducts.Name = "AddedProducts";
            this.AddedProducts.Size = new System.Drawing.Size(211, 276);
            this.AddedProducts.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Принять";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddMeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddedProducts);
            this.Controls.Add(this.ProductsToAdd);
            this.Controls.Add(this.AddButton);
            this.Name = "AddMeatForm";
            this.Text = "AddMeat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckedListBox ProductsToAdd;
        private System.Windows.Forms.CheckedListBox AddedProducts;
        private System.Windows.Forms.Button button2;
    }
}