namespace Assignment5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputlabel = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.guessthenumber = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputlabel
            // 
            this.inputlabel.AutoSize = true;
            this.inputlabel.Location = new System.Drawing.Point(143, 131);
            this.inputlabel.Name = "inputlabel";
            this.inputlabel.Size = new System.Drawing.Size(67, 13);
            this.inputlabel.TabIndex = 0;
            this.inputlabel.Text = "Your number";
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(227, 128);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(217, 20);
            this.guess.TabIndex = 1;
            this.guess.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // guessthenumber
            // 
            this.guessthenumber.AutoSize = true;
            this.guessthenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.guessthenumber.Location = new System.Drawing.Point(84, 46);
            this.guessthenumber.Name = "guessthenumber";
            this.guessthenumber.Size = new System.Drawing.Size(304, 39);
            this.guessthenumber.TabIndex = 2;
            this.guessthenumber.Text = "Guess the number!";
            this.guessthenumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(251, 172);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(150, 54);
            this.Check.TabIndex = 7;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.numbercheck);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.count.Location = new System.Drawing.Point(12, 404);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(199, 26);
            this.count.TabIndex = 8;
            this.count.Text = "Count of guesses:  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 443);
            this.Controls.Add(this.count);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.guessthenumber);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.inputlabel);
            this.Name = "Form1";
            this.Text = "Guess the number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputlabel;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Label guessthenumber;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label count;
    }
}

