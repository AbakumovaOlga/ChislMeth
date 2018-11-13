namespace ChM1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.F_a = new System.Windows.Forms.TextBox();
            this.F_c = new System.Windows.Forms.TextBox();
            this.F_b = new System.Windows.Forms.TextBox();
            this.F_Res = new System.Windows.Forms.Button();
            this.F_otvet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // F_a
            // 
            this.F_a.Location = new System.Drawing.Point(121, 87);
            this.F_a.Name = "F_a";
            this.F_a.Size = new System.Drawing.Size(100, 26);
            this.F_a.TabIndex = 0;
            // 
            // F_c
            // 
            this.F_c.Location = new System.Drawing.Point(513, 87);
            this.F_c.Name = "F_c";
            this.F_c.Size = new System.Drawing.Size(100, 26);
            this.F_c.TabIndex = 1;
            // 
            // F_b
            // 
            this.F_b.Location = new System.Drawing.Point(320, 87);
            this.F_b.Name = "F_b";
            this.F_b.Size = new System.Drawing.Size(100, 26);
            this.F_b.TabIndex = 2;
            // 
            // F_Res
            // 
            this.F_Res.Location = new System.Drawing.Point(96, 227);
            this.F_Res.Name = "F_Res";
            this.F_Res.Size = new System.Drawing.Size(106, 33);
            this.F_Res.TabIndex = 3;
            this.F_Res.Text = "OK";
            this.F_Res.UseVisualStyleBackColor = true;
            this.F_Res.Click += new System.EventHandler(this.F_Res_Click);
            // 
            // F_otvet
            // 
            this.F_otvet.Location = new System.Drawing.Point(121, 344);
            this.F_otvet.Name = "F_otvet";
            this.F_otvet.Size = new System.Drawing.Size(431, 26);
            this.F_otvet.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_otvet);
            this.Controls.Add(this.F_Res);
            this.Controls.Add(this.F_b);
            this.Controls.Add(this.F_c);
            this.Controls.Add(this.F_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox F_a;
        private System.Windows.Forms.TextBox F_c;
        private System.Windows.Forms.TextBox F_b;
        private System.Windows.Forms.Button F_Res;
        private System.Windows.Forms.TextBox F_otvet;
    }
}

