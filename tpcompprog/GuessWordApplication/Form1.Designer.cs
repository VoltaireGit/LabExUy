namespace GuessWordApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_mask_word = new Label();
            tb_answer = new TextBox();
            tb_guess = new Button();
            label2 = new Label();
            wrong_guessed_list = new ListBox();
            SuspendLayout();
            // 
            // lb_mask_word
            // 
            lb_mask_word.BackColor = Color.DarkSeaGreen;
            lb_mask_word.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_mask_word.ForeColor = Color.White;
            lb_mask_word.Location = new Point(12, 23);
            lb_mask_word.Name = "lb_mask_word";
            lb_mask_word.Size = new Size(530, 136);
            lb_mask_word.TabIndex = 0;
            lb_mask_word.Text = "Mask Word";
            // 
            // tb_answer
            // 
            tb_answer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_answer.Location = new Point(12, 188);
            tb_answer.Name = "tb_answer";
            tb_answer.Size = new Size(519, 38);
            tb_answer.TabIndex = 1;
            // 
            // tb_guess
            // 
            tb_guess.BackColor = Color.DarkSeaGreen;
            tb_guess.FlatStyle = FlatStyle.Flat;
            tb_guess.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_guess.ForeColor = Color.White;
            tb_guess.Location = new Point(198, 232);
            tb_guess.Name = "tb_guess";
            tb_guess.Size = new Size(150, 66);
            tb_guess.TabIndex = 2;
            tb_guess.Text = "Guess";
            tb_guess.UseVisualStyleBackColor = false;
            tb_guess.Click += tb_guess_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(548, 23);
            label2.Name = "label2";
            label2.Size = new Size(240, 47);
            label2.TabIndex = 3;
            label2.Text = "Wrong Guessed";
            // 
            // wrong_guessed_list
            // 
            wrong_guessed_list.FormattingEnabled = true;
            wrong_guessed_list.Location = new Point(548, 73);
            wrong_guessed_list.Name = "wrong_guessed_list";
            wrong_guessed_list.Size = new Size(240, 264);
            wrong_guessed_list.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 353);
            Controls.Add(wrong_guessed_list);
            Controls.Add(label2);
            Controls.Add(tb_guess);
            Controls.Add(tb_answer);
            Controls.Add(lb_mask_word);
            Name = "Form1";
            Text = "Guess the word";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mask_word;
        private TextBox tb_answer;
        private Button tb_guess;
        private Label label2;
        private ListBox wrong_guessed_list;
    }
}
