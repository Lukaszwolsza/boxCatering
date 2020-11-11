namespace Wolsza.Controls
{
    partial class sumOrderLabel
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
            this.summaryOrderLabel = new System.Windows.Forms.Label();
            this.summaryOrderUserData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // summaryOrderLabel
            // 
            this.summaryOrderLabel.AutoSize = true;
            this.summaryOrderLabel.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summaryOrderLabel.Location = new System.Drawing.Point(43, 14);
            this.summaryOrderLabel.Name = "summaryOrderLabel";
            this.summaryOrderLabel.Size = new System.Drawing.Size(120, 20);
            this.summaryOrderLabel.TabIndex = 0;
            this.summaryOrderLabel.Text = "> exampleText : ";
            // 
            // summaryOrderUserData
            // 
            this.summaryOrderUserData.AutoSize = true;
            this.summaryOrderUserData.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summaryOrderUserData.Location = new System.Drawing.Point(160, 14);
            this.summaryOrderUserData.Name = "summaryOrderUserData";
            this.summaryOrderUserData.Size = new System.Drawing.Size(93, 20);
            this.summaryOrderUserData.TabIndex = 1;
            this.summaryOrderUserData.Text = "exampleText";
            this.summaryOrderUserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sumOrderLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.summaryOrderUserData);
            this.Controls.Add(this.summaryOrderLabel);
            this.Name = "sumOrderLabel";
            this.Size = new System.Drawing.Size(335, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label summaryOrderLabel;
        private System.Windows.Forms.Label summaryOrderUserData;
    }
}
