namespace TextEditor
{
    partial class statisticForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lavel2 = new System.Windows.Forms.Label();
            this.TextLengthLabel = new System.Windows.Forms.Label();
            this.WordsCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина текста:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lavel2
            // 
            this.lavel2.AutoSize = true;
            this.lavel2.Location = new System.Drawing.Point(132, 44);
            this.lavel2.Name = "lavel2";
            this.lavel2.Size = new System.Drawing.Size(66, 13);
            this.lavel2.TabIndex = 1;
            this.lavel2.Text = "число слов:";
            // 
            // TextLengthLabel
            // 
            this.TextLengthLabel.AutoSize = true;
            this.TextLengthLabel.Location = new System.Drawing.Point(28, 72);
            this.TextLengthLabel.Name = "TextLengthLabel";
            this.TextLengthLabel.Size = new System.Drawing.Size(35, 13);
            this.TextLengthLabel.TabIndex = 2;
            this.TextLengthLabel.Text = "label3";
            // 
            // WordsCountLabel
            // 
            this.WordsCountLabel.AutoSize = true;
            this.WordsCountLabel.Location = new System.Drawing.Point(132, 72);
            this.WordsCountLabel.Name = "WordsCountLabel";
            this.WordsCountLabel.Size = new System.Drawing.Size(35, 13);
            this.WordsCountLabel.TabIndex = 3;
            this.WordsCountLabel.Text = "label4";
            // 
            // statisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WordsCountLabel);
            this.Controls.Add(this.TextLengthLabel);
            this.Controls.Add(this.lavel2);
            this.Controls.Add(this.label1);
            this.Name = "statisticForm";
            this.Text = "statisticForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lavel2;
        private System.Windows.Forms.Label TextLengthLabel;
        private System.Windows.Forms.Label WordsCountLabel;
    }
}