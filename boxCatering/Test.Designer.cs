namespace boxCatering
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cardInfo1 = new Wolsza.Controls.cardInfo();
            this.SuspendLayout();
            // 
            // cardInfo1
            // 
            this.cardInfo1.BackColor = System.Drawing.Color.White;
            this.cardInfo1.cardNum = "";
            this.cardInfo1.Location = new System.Drawing.Point(257, 80);
            this.cardInfo1.Name = "cardInfo1";
            this.cardInfo1.Size = new System.Drawing.Size(350, 200);
            this.cardInfo1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardInfo1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Wolsza.Controls.cardInfo cardInfo1;
    }
}