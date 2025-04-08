namespace Lab4
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
            label1 = new Label();
            label2 = new Label();
            gpaBox = new TextBox();
            admissionBox = new TextBox();
            resultButton = new Button();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 100);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your gpa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 129);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter your admission test score:";
            // 
            // gpaBox
            // 
            gpaBox.Location = new Point(273, 97);
            gpaBox.Name = "gpaBox";
            gpaBox.Size = new Size(100, 23);
            gpaBox.TabIndex = 2;
            gpaBox.TextChanged += textBox1_TextChanged;
            // 
            // admissionBox
            // 
            admissionBox.Location = new Point(273, 126);
            admissionBox.Name = "admissionBox";
            admissionBox.Size = new Size(100, 23);
            admissionBox.TabIndex = 3;
            admissionBox.TextChanged += admissionBox_TextChanged;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(180, 170);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(193, 23);
            resultButton.TabIndex = 4;
            resultButton.Text = "Check results:";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(129, 209);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(304, 23);
            resultBox.TabIndex = 5;
            resultBox.TextChanged += resultBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultBox);
            Controls.Add(resultButton);
            Controls.Add(admissionBox);
            Controls.Add(gpaBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox gpaBox;
        private TextBox admissionBox;
        private Button resultButton;
        private TextBox resultBox;
    }
}
