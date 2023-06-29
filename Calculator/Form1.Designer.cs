namespace Calculator
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
            numTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnMinus = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // numTotal
            // 
            numTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numTotal.Location = new Point(187, 12);
            numTotal.Multiline = true;
            numTotal.Name = "numTotal";
            numTotal.Size = new Size(484, 90);
            numTotal.TabIndex = 0;
            numTotal.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(22, 353);
            btn1.Name = "btn1";
            btn1.Size = new Size(148, 105);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(187, 353);
            btn2.Name = "btn2";
            btn2.Size = new Size(148, 105);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(351, 353);
            btn3.Name = "btn3";
            btn3.Size = new Size(148, 105);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(22, 242);
            btn4.Name = "btn4";
            btn4.Size = new Size(148, 105);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(187, 242);
            btn5.Name = "btn5";
            btn5.Size = new Size(148, 105);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(351, 242);
            btn6.Name = "btn6";
            btn6.Size = new Size(148, 105);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(22, 131);
            btn7.Name = "btn7";
            btn7.Size = new Size(148, 105);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(187, 131);
            btn8.Name = "btn8";
            btn8.Size = new Size(148, 105);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(351, 131);
            btn9.Name = "btn9";
            btn9.Size = new Size(148, 105);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button9_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(523, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 105);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMulti.Location = new Point(523, 242);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(148, 105);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(523, 131);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(148, 105);
            btnDiv.TabIndex = 10;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(187, 464);
            btn0.Name = "btn0";
            btn0.Size = new Size(148, 105);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(22, 464);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(148, 105);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(351, 464);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(148, 105);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(523, 464);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(148, 105);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(22, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 90);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 591);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnMinus);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnAdd);
            Controls.Add(btnMulti);
            Controls.Add(btnDiv);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(numTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnMulti;
        private Button btnDiv;
        private Button btn0;
        private Button btnDot;
        private Button btnMinus;
        private Button btnEquals;
        private Button btnClear;
    }
}