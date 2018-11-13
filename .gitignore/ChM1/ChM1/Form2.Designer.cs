namespace ChM1
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
            this.F_otvet = new System.Windows.Forms.TextBox();
            this.F_Res = new System.Windows.Forms.Button();
            this.F_b = new System.Windows.Forms.TextBox();
            this.F_c = new System.Windows.Forms.TextBox();
            this.F_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.F_resh = new System.Windows.Forms.RichTextBox();
            this.F_formula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // F_otvet
            // 
            this.F_otvet.Location = new System.Drawing.Point(457, 467);
            this.F_otvet.Name = "F_otvet";
            this.F_otvet.Size = new System.Drawing.Size(431, 26);
            this.F_otvet.TabIndex = 9;
            // 
            // F_Res
            // 
            this.F_Res.Location = new System.Drawing.Point(136, 418);
            this.F_Res.Name = "F_Res";
            this.F_Res.Size = new System.Drawing.Size(106, 33);
            this.F_Res.TabIndex = 8;
            this.F_Res.Text = "OK";
            this.F_Res.UseVisualStyleBackColor = true;
            this.F_Res.Click += new System.EventHandler(this.F_Res_Click);
            // 
            // F_b
            // 
            this.F_b.Location = new System.Drawing.Point(142, 203);
            this.F_b.Name = "F_b";
            this.F_b.Size = new System.Drawing.Size(100, 26);
            this.F_b.TabIndex = 7;
            // 
            // F_c
            // 
            this.F_c.Location = new System.Drawing.Point(142, 258);
            this.F_c.Name = "F_c";
            this.F_c.Size = new System.Drawing.Size(100, 26);
            this.F_c.TabIndex = 6;
            // 
            // F_a
            // 
            this.F_a.Location = new System.Drawing.Point(142, 146);
            this.F_a.Name = "F_a";
            this.F_a.Size = new System.Drawing.Size(100, 26);
            this.F_a.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "c";
            // 
            // F_resh
            // 
            this.F_resh.Location = new System.Drawing.Point(443, 146);
            this.F_resh.Name = "F_resh";
            this.F_resh.Size = new System.Drawing.Size(474, 279);
            this.F_resh.TabIndex = 13;
            this.F_resh.Text = "";
            // 
            // F_formula
            // 
            this.F_formula.Location = new System.Drawing.Point(92, 335);
            this.F_formula.Name = "F_formula";
            this.F_formula.Size = new System.Drawing.Size(242, 26);
            this.F_formula.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 746);
            this.Controls.Add(this.F_formula);
            this.Controls.Add(this.F_resh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_otvet);
            this.Controls.Add(this.F_Res);
            this.Controls.Add(this.F_b);
            this.Controls.Add(this.F_c);
            this.Controls.Add(this.F_a);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox F_otvet;
        private System.Windows.Forms.Button F_Res;
        private System.Windows.Forms.TextBox F_b;
        private System.Windows.Forms.TextBox F_c;
        private System.Windows.Forms.TextBox F_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox F_resh;
        private System.Windows.Forms.TextBox F_formula;
    }
}