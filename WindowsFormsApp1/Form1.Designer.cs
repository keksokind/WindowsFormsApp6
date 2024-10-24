namespace WindowsFormsApp1
{
    partial class Form1
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
            this.hint_big_or_low = new System.Windows.Forms.Label();
            this.inpBox = new System.Windows.Forms.TextBox();
            this.checkNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number Guessing Game";
            // 
            // hint_big_or_low
            // 
            this.hint_big_or_low.AutoSize = true;
            this.hint_big_or_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_big_or_low.Location = new System.Drawing.Point(35, 111);
            this.hint_big_or_low.Name = "hint_big_or_low";
            this.hint_big_or_low.Size = new System.Drawing.Size(0, 25);
            this.hint_big_or_low.TabIndex = 2;
            this.hint_big_or_low.Click += new System.EventHandler(this.hint_big_or_low_Click);
            // 
            // inpBox
            // 
            this.inpBox.Location = new System.Drawing.Point(38, 72);
            this.inpBox.Name = "inpBox";
            this.inpBox.Size = new System.Drawing.Size(144, 22);
            this.inpBox.TabIndex = 3;
            this.inpBox.TextChanged += new System.EventHandler(this.inpBox_TextChanged);
            // 
            // checkNum
            // 
            this.checkNum.Location = new System.Drawing.Point(188, 71);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(75, 23);
            this.checkNum.TabIndex = 4;
            this.checkNum.Text = "Check";
            this.checkNum.UseVisualStyleBackColor = true;
            this.checkNum.Click += new System.EventHandler(this.checkNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkNum);
            this.Controls.Add(this.inpBox);
            this.Controls.Add(this.hint_big_or_low);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hint_big_or_low;
        private System.Windows.Forms.TextBox inpBox;
        private System.Windows.Forms.Button checkNum;
    }
}

