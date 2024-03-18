namespace EuclideanAlgorithmForm
{
    partial class EuclideanAlgorithmForm
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
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.SecondNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.workTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.Location = new System.Drawing.Point(128, 37);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(55, 16);
            this.FirstNumberLabel.TabIndex = 0;
            this.FirstNumberLabel.Text = "Value 1:";
            // 
            // SecondNumberLabel
            // 
            this.SecondNumberLabel.AutoSize = true;
            this.SecondNumberLabel.Location = new System.Drawing.Point(128, 83);
            this.SecondNumberLabel.Name = "SecondNumberLabel";
            this.SecondNumberLabel.Size = new System.Drawing.Size(55, 16);
            this.SecondNumberLabel.TabIndex = 1;
            this.SecondNumberLabel.Text = "Value 2:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDown);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(302, 131);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(99, 40);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(86, 131);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(103, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // workTextbox
            // 
            this.workTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workTextbox.Location = new System.Drawing.Point(12, 191);
            this.workTextbox.Name = "workTextbox";
            this.workTextbox.ReadOnly = true;
            this.workTextbox.Size = new System.Drawing.Size(458, 350);
            this.workTextbox.TabIndex = 6;
            this.workTextbox.TabStop = false;
            this.workTextbox.Text = "";
            // 
            // EuclideanAlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.workTextbox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecondNumberLabel);
            this.Controls.Add(this.FirstNumberLabel);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "EuclideanAlgorithmForm";
            this.Text = "Euclidean Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNumberLabel;
        private System.Windows.Forms.Label SecondNumberLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox workTextbox;
    }
}

