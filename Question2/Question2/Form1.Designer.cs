namespace Question2
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
            this.name = new System.Windows.Forms.Label();
            this.rollno = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(202, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(113, 37);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // rollno
            // 
            this.rollno.AutoSize = true;
            this.rollno.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollno.Location = new System.Drawing.Point(186, 195);
            this.rollno.Name = "rollno";
            this.rollno.Size = new System.Drawing.Size(129, 37);
            this.rollno.TabIndex = 1;
            this.rollno.Text = "RollNo:";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.Location = new System.Drawing.Point(178, 283);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(137, 37);
            this.course.TabIndex = 2;
            this.course.Text = "Course:";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(434, 113);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(188, 26);
            this.text1.TabIndex = 3;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(434, 223);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(188, 26);
            this.text2.TabIndex = 4;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(434, 303);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(188, 26);
            this.text3.TabIndex = 5;
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Arial Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(287, 361);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(166, 65);
            this.insert.TabIndex = 6;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.course);
            this.Controls.Add(this.rollno);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label rollno;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button insert;
    }
}

