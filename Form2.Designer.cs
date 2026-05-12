namespace Hangmangame
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLivesRemaining = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGuessedLetters = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelHiddenWord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLivesRemaining);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelLivesRemaining
            // 
            this.labelLivesRemaining.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLivesRemaining.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivesRemaining.ForeColor = System.Drawing.Color.White;
            this.labelLivesRemaining.Location = new System.Drawing.Point(634, 28);
            this.labelLivesRemaining.Name = "labelLivesRemaining";
            this.labelLivesRemaining.Size = new System.Drawing.Size(172, 43);
            this.labelLivesRemaining.TabIndex = 1;
            this.labelLivesRemaining.Text = "label2";
            this.labelLivesRemaining.Click += new System.EventHandler(this.labelLivesRemaining_Click);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.Black;
            this.playAgain.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.ForeColor = System.Drawing.SystemColors.Control;
            this.playAgain.Location = new System.Drawing.Point(38, 582);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(144, 49);
            this.playAgain.TabIndex = 2;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(674, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGuessedLetters
            // 
            this.labelGuessedLetters.AutoSize = true;
            this.labelGuessedLetters.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessedLetters.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGuessedLetters.Location = new System.Drawing.Point(314, 160);
            this.labelGuessedLetters.Name = "labelGuessedLetters";
            this.labelGuessedLetters.Size = new System.Drawing.Size(0, 52);
            this.labelGuessedLetters.TabIndex = 2;
            this.labelGuessedLetters.Click += new System.EventHandler(this.labelGuessedLetters_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCategory.Location = new System.Drawing.Point(189, 28);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(70, 26);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "label1";
            this.labelCategory.Click += new System.EventHandler(this.labelCategory_Click);
            // 
            // labelHiddenWord
            // 
            this.labelHiddenWord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHiddenWord.Location = new System.Drawing.Point(236, 77);
            this.labelHiddenWord.Name = "labelHiddenWord";
            this.labelHiddenWord.Size = new System.Drawing.Size(98, 37);
            this.labelHiddenWord.TabIndex = 4;
            this.labelHiddenWord.Click += new System.EventHandler(this.labelHiddenWord_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(843, 656);
            this.Controls.Add(this.labelHiddenWord);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelGuessedLetters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLivesRemaining;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGuessedLetters;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelHiddenWord;
    }
}