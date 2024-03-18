namespace EuclideanAlgorithmForm
{
    partial class CalculatorChoice
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
            this.pickLabel = new System.Windows.Forms.Label();
            this.EuclideanButton = new System.Windows.Forms.Button();
            this.BinaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickLabel
            // 
            this.pickLabel.AutoSize = true;
            this.pickLabel.BackColor = System.Drawing.SystemColors.Control;
            this.pickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickLabel.Location = new System.Drawing.Point(100, 41);
            this.pickLabel.Name = "pickLabel";
            this.pickLabel.Size = new System.Drawing.Size(265, 31);
            this.pickLabel.TabIndex = 0;
            this.pickLabel.Text = "Choose an operation";
            // 
            // EuclideanButton
            // 
            this.EuclideanButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EuclideanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EuclideanButton.Location = new System.Drawing.Point(98, 124);
            this.EuclideanButton.Name = "EuclideanButton";
            this.EuclideanButton.Size = new System.Drawing.Size(116, 61);
            this.EuclideanButton.TabIndex = 1;
            this.EuclideanButton.Text = "Euclidean Algorithm";
            this.EuclideanButton.UseVisualStyleBackColor = false;
            this.EuclideanButton.Click += new System.EventHandler(this.EuclideanButton_Click);
            // 
            // BinaryButton
            // 
            this.BinaryButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BinaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BinaryButton.Location = new System.Drawing.Point(238, 124);
            this.BinaryButton.Name = "BinaryButton";
            this.BinaryButton.Size = new System.Drawing.Size(116, 61);
            this.BinaryButton.TabIndex = 1;
            this.BinaryButton.Text = "Binary \r\nConverter";
            this.BinaryButton.UseVisualStyleBackColor = false;
            this.BinaryButton.Click += new System.EventHandler(this.BinaryButton_Click);
            // 
            // CalculatorChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.BinaryButton);
            this.Controls.Add(this.EuclideanButton);
            this.Controls.Add(this.pickLabel);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "CalculatorChoice";
            this.Text = "CalculatorChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickLabel;
        private System.Windows.Forms.Button EuclideanButton;
        private System.Windows.Forms.Button BinaryButton;
    }
}