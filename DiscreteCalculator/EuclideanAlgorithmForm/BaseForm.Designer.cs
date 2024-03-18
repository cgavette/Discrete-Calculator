namespace EuclideanAlgorithmForm
{
    partial class BaseForm
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
            this.numLabel = new System.Windows.Forms.Label();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.workTextbox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.baseLabel = new System.Windows.Forms.Label();
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(76, 28);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(58, 16);
            this.numLabel.TabIndex = 0;
            this.numLabel.Text = "Number:";
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(141, 24);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 22);
            this.numTextBox.TabIndex = 1;
            this.numTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDown);
            // 
            // workTextbox
            // 
            this.workTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workTextbox.Location = new System.Drawing.Point(12, 191);
            this.workTextbox.Name = "workTextbox";
            this.workTextbox.ReadOnly = true;
            this.workTextbox.Size = new System.Drawing.Size(458, 350);
            this.workTextbox.TabIndex = 7;
            this.workTextbox.TabStop = false;
            this.workTextbox.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(110, 119);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(103, 40);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(266, 119);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(103, 40);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(90, 53);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(42, 16);
            this.baseLabel.TabIndex = 0;
            this.baseLabel.Text = "Base:";
            // 
            // baseTextBox
            // 
            this.baseTextBox.Location = new System.Drawing.Point(141, 51);
            this.baseTextBox.MaxLength = 1;
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(33, 22);
            this.baseTextBox.TabIndex = 1;
            this.baseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numLabel);
            this.groupBox1.Controls.Add(this.numTextBox);
            this.groupBox1.Controls.Add(this.baseLabel);
            this.groupBox1.Controls.Add(this.baseTextBox);
            this.groupBox1.Location = new System.Drawing.Point(91, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 91);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.workTextbox);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "BaseForm";
            this.Text = "Base Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.RichTextBox workTextbox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}