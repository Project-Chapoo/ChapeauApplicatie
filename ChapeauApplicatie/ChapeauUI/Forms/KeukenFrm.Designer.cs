﻿namespace ChapeauUI.Forms
{
    partial class KeukenFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.KeukenListView1 = new System.Windows.Forms.ListView();
            this.KeukenListView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.KeukenListView3 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Amount
            // 
            this.Amount.Tag = "Amount";
            this.Amount.Text = "Amount";
            this.Amount.Width = 80;
            // 
            // Description
            // 
            this.Description.Tag = "Description";
            this.Description.Text = "Description";
            this.Description.Width = 250;
            // 
            // KeukenListView1
            // 
            this.KeukenListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.Description});
            this.KeukenListView1.FullRowSelect = true;
            this.KeukenListView1.GridLines = true;
            this.KeukenListView1.Location = new System.Drawing.Point(40, 53);
            this.KeukenListView1.Name = "KeukenListView1";
            this.KeukenListView1.Size = new System.Drawing.Size(335, 631);
            this.KeukenListView1.TabIndex = 1;
            this.KeukenListView1.UseCompatibleStateImageBehavior = false;
            // 
            // KeukenListView2
            // 
            this.KeukenListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.KeukenListView2.FullRowSelect = true;
            this.KeukenListView2.GridLines = true;
            this.KeukenListView2.Location = new System.Drawing.Point(420, 53);
            this.KeukenListView2.Name = "KeukenListView2";
            this.KeukenListView2.Size = new System.Drawing.Size(335, 631);
            this.KeukenListView2.TabIndex = 2;
            this.KeukenListView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Amount";
            this.columnHeader1.Text = "Amount";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "Description";
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 250;
            // 
            // KeukenListView3
            // 
            this.KeukenListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.KeukenListView3.FullRowSelect = true;
            this.KeukenListView3.GridLines = true;
            this.KeukenListView3.Location = new System.Drawing.Point(810, 53);
            this.KeukenListView3.Name = "KeukenListView3";
            this.KeukenListView3.Size = new System.Drawing.Size(335, 631);
            this.KeukenListView3.TabIndex = 3;
            this.KeukenListView3.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "Amount";
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "Description";
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 678);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 678);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(810, 678);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(335, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // KeukenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1176, 787);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KeukenListView3);
            this.Controls.Add(this.KeukenListView2);
            this.Controls.Add(this.KeukenListView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KeukenFrm";
            this.Text = "KeukenFrm";
            this.Load += new System.EventHandler(this.KeukenFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ColumnHeader Amount;
        private ColumnHeader Description;
        private ListView KeukenListView1;
        private ListView KeukenListView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView KeukenListView3;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}