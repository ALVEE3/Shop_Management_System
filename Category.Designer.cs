﻿namespace Shop_Management_System
{
    partial class Category
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
            this.lblExit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblExitP = new System.Windows.Forms.Label();
            this.btnSeller = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnAddCategory1 = new System.Windows.Forms.Button();
            this.dgvCategoryMaintining = new System.Windows.Forms.DataGridView();
            this.txtDescriptionCategory = new System.Windows.Forms.TextBox();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryMaintining)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(1232, 4);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(29, 35);
            this.lblExit.TabIndex = 27;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "CATEGORY MAINTAINING";
            // 
            // btnSelling
            // 
            this.btnSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.Location = new System.Drawing.Point(824, 54);
            this.btnSelling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(144, 38);
            this.btnSelling.TabIndex = 3;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(287, 54);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(135, 38);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 609);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BackgroundImage = global::Shop_Management_System.Properties.Resources.shopping_cart_full_food_supermarket_aisle_elevated_view_high_internal_horizontal_composition_63616470;
            this.panel4.Controls.Add(this.lblExitP);
            this.panel4.Controls.Add(this.lblExit);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnSelling);
            this.panel4.Controls.Add(this.btnSeller);
            this.panel4.Controls.Add(this.btnProduct);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1219, 108);
            this.panel4.TabIndex = 0;
            // 
            // lblExitP
            // 
            this.lblExitP.AutoSize = true;
            this.lblExitP.BackColor = System.Drawing.Color.Red;
            this.lblExitP.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitP.ForeColor = System.Drawing.Color.White;
            this.lblExitP.Location = new System.Drawing.Point(1180, 0);
            this.lblExitP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitP.Name = "lblExitP";
            this.lblExitP.Size = new System.Drawing.Size(33, 39);
            this.lblExitP.TabIndex = 30;
            this.lblExitP.Text = "X";
            this.lblExitP.Click += new System.EventHandler(this.lblExitP_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeller.Location = new System.Drawing.Point(528, 54);
            this.btnSeller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(163, 38);
            this.btnSeller.TabIndex = 2;
            this.btnSeller.Text = "Seller";
            this.btnSeller.UseVisualStyleBackColor = true;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 613);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.BackgroundImage = global::Shop_Management_System.Properties.Resources.shopping_cart_full_food_supermarket_aisle_elevated_view_high_internal_horizontal_composition_63616470;
            this.panel3.Controls.Add(this.lblLogout);
            this.panel3.Controls.Add(this.btnAddCategory1);
            this.panel3.Controls.Add(this.dgvCategoryMaintining);
            this.panel3.Controls.Add(this.txtDescriptionCategory);
            this.panel3.Controls.Add(this.txtNameCategory);
            this.panel3.Controls.Add(this.txtIdCategory);
            this.panel3.Controls.Add(this.btnDeleteCategory);
            this.panel3.Controls.Add(this.btnUpdateCategory);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1217, 505);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogout.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(13, 457);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(85, 35);
            this.lblLogout.TabIndex = 27;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // btnAddCategory1
            // 
            this.btnAddCategory1.BackColor = System.Drawing.Color.Green;
            this.btnAddCategory1.FlatAppearance.BorderSize = 0;
            this.btnAddCategory1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory1.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory1.Location = new System.Drawing.Point(15, 372);
            this.btnAddCategory1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory1.Name = "btnAddCategory1";
            this.btnAddCategory1.Size = new System.Drawing.Size(105, 46);
            this.btnAddCategory1.TabIndex = 26;
            this.btnAddCategory1.Text = "Add";
            this.btnAddCategory1.UseVisualStyleBackColor = false;
            this.btnAddCategory1.Click += new System.EventHandler(this.btnAddCategory1_Click);
            // 
            // dgvCategoryMaintining
            // 
            this.dgvCategoryMaintining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoryMaintining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryMaintining.Location = new System.Drawing.Point(447, 37);
            this.dgvCategoryMaintining.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategoryMaintining.Name = "dgvCategoryMaintining";
            this.dgvCategoryMaintining.RowHeadersWidth = 51;
            this.dgvCategoryMaintining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryMaintining.Size = new System.Drawing.Size(756, 454);
            this.dgvCategoryMaintining.TabIndex = 25;
            this.dgvCategoryMaintining.DoubleClick += new System.EventHandler(this.dgvCategoryMaintining_DoubleClick);
            // 
            // txtDescriptionCategory
            // 
            this.txtDescriptionCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionCategory.Location = new System.Drawing.Point(155, 183);
            this.txtDescriptionCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionCategory.Name = "txtDescriptionCategory";
            this.txtDescriptionCategory.Size = new System.Drawing.Size(265, 30);
            this.txtDescriptionCategory.TabIndex = 23;
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategory.Location = new System.Drawing.Point(155, 123);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(265, 30);
            this.txtNameCategory.TabIndex = 22;
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategory.Location = new System.Drawing.Point(155, 57);
            this.txtIdCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.Size = new System.Drawing.Size(265, 30);
            this.txtIdCategory.TabIndex = 21;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(304, 372);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(117, 46);
            this.btnDeleteCategory.TabIndex = 18;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click_1);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(155, 372);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(117, 46);
            this.btnUpdateCategory.TabIndex = 19;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 613);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryMaintining)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button btnAddCategory1;
        private System.Windows.Forms.DataGridView dgvCategoryMaintining;
        private System.Windows.Forms.TextBox txtDescriptionCategory;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.TextBox txtIdCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExitP;
    }
}