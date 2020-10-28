namespace boxCatering.Forms
{
    partial class MainForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leftArrowButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rightArrowButton = new System.Windows.Forms.Button();
            this.dietBox4 = new Wolsza.Controls.dietBox();
            this.dietBox5 = new Wolsza.Controls.dietBox();
            this.dietBox6 = new Wolsza.Controls.dietBox();
            this.dietBox3 = new Wolsza.Controls.dietBox();
            this.dietBox2 = new Wolsza.Controls.dietBox();
            this.dietBox1 = new Wolsza.Controls.dietBox();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(-3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 68);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "urHealtyDiet";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(888, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "MAIN";
            // 
            // leftArrowButton
            // 
            this.leftArrowButton.BackColor = System.Drawing.Color.White;
            this.leftArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftArrowButton.Location = new System.Drawing.Point(20, 12);
            this.leftArrowButton.Name = "leftArrowButton";
            this.leftArrowButton.Size = new System.Drawing.Size(75, 23);
            this.leftArrowButton.TabIndex = 20;
            this.leftArrowButton.Text = "<";
            this.leftArrowButton.UseVisualStyleBackColor = false;
            this.leftArrowButton.Click += new System.EventHandler(this.leftArrowButton_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rightArrowButton);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.leftArrowButton);
            this.panel8.Location = new System.Drawing.Point(337, 84);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(298, 45);
            this.panel8.TabIndex = 23;
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.BackColor = System.Drawing.Color.White;
            this.rightArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightArrowButton.Location = new System.Drawing.Point(200, 12);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(75, 23);
            this.rightArrowButton.TabIndex = 23;
            this.rightArrowButton.Text = ">";
            this.rightArrowButton.UseVisualStyleBackColor = false;
            this.rightArrowButton.Click += new System.EventHandler(this.rightArrowButton_Click);
            // 
            // dietBox4
            // 
            this.dietBox4.dietName = "dietName";
            this.dietBox4.firstLabel = "diet Desc 1";
            this.dietBox4.Location = new System.Drawing.Point(667, 367);
            this.dietBox4.Name = "dietBox4";
            this.dietBox4.secondLabel = "diet Desc 2";
            this.dietBox4.Size = new System.Drawing.Size(233, 169);
            this.dietBox4.TabIndex = 29;
            this.dietBox4.thirdLabel = "diet Desc 3";
            // 
            // dietBox5
            // 
            this.dietBox5.dietName = "dietName";
            this.dietBox5.firstLabel = "diet Desc 1";
            this.dietBox5.Location = new System.Drawing.Point(369, 367);
            this.dietBox5.Name = "dietBox5";
            this.dietBox5.secondLabel = "diet Desc 2";
            this.dietBox5.Size = new System.Drawing.Size(233, 169);
            this.dietBox5.TabIndex = 28;
            this.dietBox5.thirdLabel = "diet Desc 3";
            // 
            // dietBox6
            // 
            this.dietBox6.dietName = "dietName";
            this.dietBox6.firstLabel = "diet Desc 1";
            this.dietBox6.Location = new System.Drawing.Point(69, 367);
            this.dietBox6.Name = "dietBox6";
            this.dietBox6.secondLabel = "diet Desc 2";
            this.dietBox6.Size = new System.Drawing.Size(233, 169);
            this.dietBox6.TabIndex = 27;
            this.dietBox6.thirdLabel = "diet Desc 3";
            // 
            // dietBox3
            // 
            this.dietBox3.dietName = "dietName";
            this.dietBox3.firstLabel = "diet Desc 1";
            this.dietBox3.Location = new System.Drawing.Point(667, 157);
            this.dietBox3.Name = "dietBox3";
            this.dietBox3.secondLabel = "diet Desc 2";
            this.dietBox3.Size = new System.Drawing.Size(233, 169);
            this.dietBox3.TabIndex = 26;
            this.dietBox3.thirdLabel = "diet Desc 3";
            // 
            // dietBox2
            // 
            this.dietBox2.dietName = ":D ";
            this.dietBox2.firstLabel = "diet Desc 1";
            this.dietBox2.Location = new System.Drawing.Point(369, 157);
            this.dietBox2.Name = "dietBox2";
            this.dietBox2.secondLabel = "diet Desc 2";
            this.dietBox2.Size = new System.Drawing.Size(233, 169);
            this.dietBox2.TabIndex = 25;
            this.dietBox2.thirdLabel = "diet Desc 3";
            // 
            // dietBox1
            // 
            this.dietBox1.dietName = "siema";
            this.dietBox1.firstLabel = "diet Desc 1";
            this.dietBox1.Location = new System.Drawing.Point(69, 157);
            this.dietBox1.Name = "dietBox1";
            this.dietBox1.secondLabel = "diet Desc 2";
            this.dietBox1.Size = new System.Drawing.Size(233, 169);
            this.dietBox1.TabIndex = 24;
            this.dietBox1.thirdLabel = "diet Desc 3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 610);
            this.Controls.Add(this.dietBox4);
            this.Controls.Add(this.dietBox5);
            this.Controls.Add(this.dietBox6);
            this.Controls.Add(this.dietBox3);
            this.Controls.Add(this.dietBox2);
            this.Controls.Add(this.dietBox1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button leftArrowButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button rightArrowButton;
        private Wolsza.Controls.dietBox dietBox1;
        private Wolsza.Controls.dietBox dietBox2;
        private Wolsza.Controls.dietBox dietBox3;
        private Wolsza.Controls.dietBox dietBox4;
        private Wolsza.Controls.dietBox dietBox5;
        private Wolsza.Controls.dietBox dietBox6;
    }
}