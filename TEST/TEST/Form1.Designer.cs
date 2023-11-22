namespace TEST
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
            this.lb_Question = new System.Windows.Forms.Label();
            this.rbtn_A = new System.Windows.Forms.RadioButton();
            this.btn_Next = new System.Windows.Forms.Button();
            this.rbtn_B = new System.Windows.Forms.RadioButton();
            this.rbtn_C = new System.Windows.Forms.RadioButton();
            this.rbtn_D = new System.Windows.Forms.RadioButton();
            this.btn_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Question
            // 
            this.lb_Question.AutoSize = true;
            this.lb_Question.ForeColor = System.Drawing.Color.Red;
            this.lb_Question.Location = new System.Drawing.Point(31, 34);
            this.lb_Question.Name = "lb_Question";
            this.lb_Question.Size = new System.Drawing.Size(51, 18);
            this.lb_Question.TabIndex = 0;
            this.lb_Question.Text = "Câu 1:";
            // 
            // rbtn_A
            // 
            this.rbtn_A.AutoSize = true;
            this.rbtn_A.Location = new System.Drawing.Point(34, 173);
            this.rbtn_A.Name = "rbtn_A";
            this.rbtn_A.Size = new System.Drawing.Size(53, 22);
            this.rbtn_A.TabIndex = 1;
            this.rbtn_A.TabStop = true;
            this.rbtn_A.Text = "A. 1";
            this.rbtn_A.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(144, 359);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(137, 43);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Câu tiếp theo";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // rbtn_B
            // 
            this.rbtn_B.AutoSize = true;
            this.rbtn_B.Location = new System.Drawing.Point(34, 217);
            this.rbtn_B.Name = "rbtn_B";
            this.rbtn_B.Size = new System.Drawing.Size(53, 22);
            this.rbtn_B.TabIndex = 1;
            this.rbtn_B.TabStop = true;
            this.rbtn_B.Text = "B. 2";
            this.rbtn_B.UseVisualStyleBackColor = true;
            // 
            // rbtn_C
            // 
            this.rbtn_C.AutoSize = true;
            this.rbtn_C.Location = new System.Drawing.Point(34, 258);
            this.rbtn_C.Name = "rbtn_C";
            this.rbtn_C.Size = new System.Drawing.Size(53, 22);
            this.rbtn_C.TabIndex = 1;
            this.rbtn_C.TabStop = true;
            this.rbtn_C.Text = "C. 3";
            this.rbtn_C.UseVisualStyleBackColor = true;
            // 
            // rbtn_D
            // 
            this.rbtn_D.AutoSize = true;
            this.rbtn_D.Location = new System.Drawing.Point(34, 304);
            this.rbtn_D.Name = "rbtn_D";
            this.rbtn_D.Size = new System.Drawing.Size(54, 22);
            this.rbtn_D.TabIndex = 1;
            this.rbtn_D.TabStop = true;
            this.rbtn_D.Text = "D. 4";
            this.rbtn_D.UseVisualStyleBackColor = true;
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(328, 359);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(102, 43);
            this.btn_Result.TabIndex = 3;
            this.btn_Result.Text = "Xem điểm";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 472);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.rbtn_D);
            this.Controls.Add(this.rbtn_C);
            this.Controls.Add(this.rbtn_B);
            this.Controls.Add(this.rbtn_A);
            this.Controls.Add(this.lb_Question);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Question;
        private System.Windows.Forms.RadioButton rbtn_A;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.RadioButton rbtn_B;
        private System.Windows.Forms.RadioButton rbtn_C;
        private System.Windows.Forms.RadioButton rbtn_D;
        private System.Windows.Forms.Button btn_Result;
    }
}

