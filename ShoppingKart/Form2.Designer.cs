namespace ShoppingKart
{
    partial class CheckoutPage
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
            this.go_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // go_back
            // 
            this.go_back.BackColor = System.Drawing.Color.DarkGray;
            this.go_back.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back.ForeColor = System.Drawing.Color.Snow;
            this.go_back.Location = new System.Drawing.Point(12, 12);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(108, 35);
            this.go_back.TabIndex = 0;
            this.go_back.Text = "BACK";
            this.go_back.UseVisualStyleBackColor = false;
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 487);
            this.Controls.Add(this.go_back);
            this.Name = "CheckoutPage";
            this.Text = "Checkout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_back;
    }
}