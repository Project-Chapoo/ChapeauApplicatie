namespace ChapeauUI.Forms
{
    partial class Payingfrm
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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(148, 190);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(43, 23);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(206, 190);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(23, 23);
            this.btnAddTip.TabIndex = 1;
            this.btnAddTip.Text = "+";
            this.btnAddTip.UseVisualStyleBackColor = true;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(131, 87);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(121, 97);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(131, 58);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Payingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.btnPay);
            this.Name = "Payingfrm";
            this.Text = "Payingfrm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPay;
        private Button btnAddTip;
        private ListView txtOrder;
        private Button btnBack;
    }
}