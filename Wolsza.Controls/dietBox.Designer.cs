namespace Wolsza.Controls
{
    partial class dietBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dietDesc = new System.Windows.Forms.TextBox();
            this.orderDietBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dietNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dietDesc);
            this.panel1.Controls.Add(this.orderDietBtn);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 169);
            this.panel1.TabIndex = 12;
            // 
            // dietDesc
            // 
            this.dietDesc.BackColor = System.Drawing.Color.White;
            this.dietDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dietDesc.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dietDesc.Location = new System.Drawing.Point(23, 63);
            this.dietDesc.Multiline = true;
            this.dietDesc.Name = "dietDesc";
            this.dietDesc.Size = new System.Drawing.Size(187, 67);
            this.dietDesc.TabIndex = 2;
            this.dietDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderDietBtn
            // 
            this.orderDietBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.orderDietBtn.FlatAppearance.BorderSize = 0;
            this.orderDietBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDietBtn.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderDietBtn.ForeColor = System.Drawing.Color.White;
            this.orderDietBtn.Location = new System.Drawing.Point(76, 136);
            this.orderDietBtn.Name = "orderDietBtn";
            this.orderDietBtn.Size = new System.Drawing.Size(81, 23);
            this.orderDietBtn.TabIndex = 1;
            this.orderDietBtn.Text = "Order";
            this.orderDietBtn.UseVisualStyleBackColor = false;
            this.orderDietBtn.Click += new System.EventHandler(this.orderDietBtn_Click);
            this.orderDietBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.orderDietBtn_MouseMove);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.panel9.Controls.Add(this.dietNameLabel);
            this.panel9.Location = new System.Drawing.Point(-1, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(233, 37);
            this.panel9.TabIndex = 0;
            // 
            // dietNameLabel
            // 
            this.dietNameLabel.AutoSize = true;
            this.dietNameLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dietNameLabel.Location = new System.Drawing.Point(73, 8);
            this.dietNameLabel.Name = "dietNameLabel";
            this.dietNameLabel.Size = new System.Drawing.Size(86, 21);
            this.dietNameLabel.TabIndex = 0;
            this.dietNameLabel.Text = "dietName";
            this.dietNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dietBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "dietBox";
            this.Size = new System.Drawing.Size(233, 169);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button orderDietBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label dietNameLabel;
        private System.Windows.Forms.TextBox dietDesc;
    }
}
