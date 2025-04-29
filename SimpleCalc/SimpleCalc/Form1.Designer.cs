namespace SimpleCalc
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbOperator = new ComboBox();
            btnCalculate = new Button();
            btnReset = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(225, 39);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(125, 30);
            txtNumber1.TabIndex = 0;
            txtNumber1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(225, 103);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(125, 30);
            txtNumber2.TabIndex = 1;
            txtNumber2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 42);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 2;
            label1.Text = "Number 1 : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 106);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 3;
            label2.Text = "Number 2 :";
            label2.Click += label2_Click;
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperator.Location = new Point(144, 164);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(151, 31);
            cmbOperator.TabIndex = 4;
            cmbOperator.SelectedIndexChanged += cmbOperator_SelectedIndexChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(98, 226);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(266, 226);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(203, 294);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(70, 23);
            lblResult.TabIndex = 7;
            lblResult.Text = "Result : ";
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(cmbOperator);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label label1;
        private Label label2;
        private ComboBox cmbOperator;
        private Button btnCalculate;
        private Button btnReset;
        private Label lblResult;
    }
}
