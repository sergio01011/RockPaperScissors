namespace RockPaperScissors
{
    partial class rock_paper_scissor
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
            txtYouChoose = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCpuChoose = new TextBox();
            txtWhoWin = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(102, 70);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(175, 98);
            button1.TabIndex = 0;
            button1.Text = "rock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSelector_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            button2.Location = new Point(361, 70);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(175, 98);
            button2.TabIndex = 1;
            button2.Text = "paper";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSelector_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            button3.Location = new Point(627, 70);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(175, 98);
            button3.TabIndex = 2;
            button3.Text = "scissor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSelector_Click;
            // 
            // txtYouChoose
            // 
            txtYouChoose.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtYouChoose.Location = new Point(319, 252);
            txtYouChoose.Margin = new Padding(4, 4, 4, 4);
            txtYouChoose.Multiline = true;
            txtYouChoose.Name = "txtYouChoose";
            txtYouChoose.Size = new Size(248, 45);
            txtYouChoose.TabIndex = 3;
            txtYouChoose.Text = "You choose: !";
            txtYouChoose.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 252);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 4;
            label1.Text = "You choose: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 365);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 5;
            label2.Text = "Cpu choose: ";
            // 
            // txtCpuChoose
            // 
            txtCpuChoose.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCpuChoose.Location = new Point(319, 361);
            txtCpuChoose.Margin = new Padding(4, 4, 4, 4);
            txtCpuChoose.Multiline = true;
            txtCpuChoose.Name = "txtCpuChoose";
            txtCpuChoose.Size = new Size(248, 45);
            txtCpuChoose.TabIndex = 6;
            txtCpuChoose.Text = "CPU choose: !";
            txtCpuChoose.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWhoWin
            // 
            txtWhoWin.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWhoWin.Location = new Point(243, 479);
            txtWhoWin.Margin = new Padding(4, 4, 4, 4);
            txtWhoWin.Multiline = true;
            txtWhoWin.Name = "txtWhoWin";
            txtWhoWin.Size = new Size(376, 89);
            txtWhoWin.TabIndex = 7;
            txtWhoWin.Text = "WHO WIN ?";
            txtWhoWin.TextAlign = HorizontalAlignment.Center;
            // 
            // rock_paper_scissor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(923, 630);
            Controls.Add(txtWhoWin);
            Controls.Add(txtCpuChoose);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYouChoose);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "rock_paper_scissor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock - Paper - Scissor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtYouChoose;
        private Label label1;
        private Label label2;
        private TextBox txtCpuChoose;
        private TextBox txtWhoWin;
    }
}
