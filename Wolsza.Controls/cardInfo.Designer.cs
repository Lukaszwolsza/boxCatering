namespace Wolsza.Controls
{
    partial class cardInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.expDate = new System.Windows.Forms.TextBox();
            this.ccvNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter payment details";
            // 
            // cardNumber
            // 
            this.cardNumber.BackColor = System.Drawing.Color.White;
            this.cardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNumber.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cardNumber.Location = new System.Drawing.Point(14, 70);
            this.cardNumber.MaxLength = 20;
            this.cardNumber.Multiline = true;
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(300, 26);
            this.cardNumber.TabIndex = 1;
            this.cardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // expDate
            // 
            this.expDate.BackColor = System.Drawing.Color.White;
            this.expDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expDate.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expDate.Location = new System.Drawing.Point(14, 136);
            this.expDate.MaxLength = 5;
            this.expDate.Multiline = true;
            this.expDate.Name = "expDate";
            this.expDate.Size = new System.Drawing.Size(180, 26);
            this.expDate.TabIndex = 3;
            this.expDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ccvNumber
            // 
            this.ccvNumber.BackColor = System.Drawing.Color.White;
            this.ccvNumber.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ccvNumber.Location = new System.Drawing.Point(219, 136);
            this.ccvNumber.MaxLength = 3;
            this.ccvNumber.Multiline = true;
            this.ccvNumber.Name = "ccvNumber";
            this.ccvNumber.Size = new System.Drawing.Size(95, 26);
            this.ccvNumber.TabIndex = 4;
            this.ccvNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Card exp date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(225, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CCV";
            // 
            // cardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ccvNumber);
            this.Controls.Add(this.expDate);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.label1);
            this.Name = "cardInfo";
            this.Size = new System.Drawing.Size(350, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cardNumber;
        private System.Windows.Forms.TextBox expDate;
        private System.Windows.Forms.TextBox ccvNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
