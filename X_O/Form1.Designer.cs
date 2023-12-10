namespace X_O
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(120, 70);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += delegate { this.button_click(new Space(0, 0), new System.EventArgs()); };
            // 
            // button2
            // 
            button2.Location = new Point(236, 70);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += delegate { this.button_click(new Space(0, 1), new System.EventArgs()); };
            // 
            // button3
            // 
            button3.Location = new Point(357, 70);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += delegate { this.button_click(new Space(0, 2), new System.EventArgs()); };

            // 
            // button4
            // 
            button4.Location = new Point(120, 119);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = " ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += delegate { this.button_click(new Space(1, 0), new System.EventArgs()); };
            // 
            // button5
            // 
            button5.Location = new Point(236, 119);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = " ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += delegate { this.button_click(new Space(1, 1), new System.EventArgs()); };
            // 
            // button6
            // 
            button6.Location = new Point(357, 119);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = " ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += delegate { this.button_click(new Space(1, 2), new System.EventArgs()); };
            // 
            // button7
            // 
            button7.Location = new Point(120, 172);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = " ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += delegate { this.button_click(new Space(2, 0), new System.EventArgs()); };
            // 
            // button8
            // 
            button8.Location = new Point(236, 172);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = " ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += delegate { this.button_click(new Space(2, 1), new System.EventArgs()); };

            // 
            // button9
            // 
            button9.Location = new Point(357, 172);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 8;
            button9.Text = " ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += delegate { this.button_click(new Space(2, 2), new System.EventArgs()); };
            // 
            // button10
            // 
            button10.Location = new Point(177, 305);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 9;
            button10.Text = "X";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(296, 305);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 10;
            button11.Text = "O";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            button11.Click += delegate { this.button_click(new Space(2, 2), new System.EventArgs()); }; ;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(593, 38);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 11;
            label1.Text = " ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(593, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(32, 27);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 38);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 13;
            label2.Text = "Вы играете за :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}