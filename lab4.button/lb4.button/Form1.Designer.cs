namespace lb4.button
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
            this.label1 = new System.Windows.Forms.Label();
            this.hoverButtonB1 = new lb4.button.HoverButtonB();
            this.hoverButton1 = new lb4.button.HoverButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Галерея смешных обезьянок";
            // 
            // hoverButtonB1
            // 
            this.hoverButtonB1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.hoverButtonB1.ForeColor = System.Drawing.Color.Black;
            this.hoverButtonB1.Location = new System.Drawing.Point(116, 374);
            this.hoverButtonB1.Name = "hoverButtonB1";
            this.hoverButtonB1.Size = new System.Drawing.Size(297, 282);
            this.hoverButtonB1.TabIndex = 1;
            this.hoverButtonB1.Text = "Бибизяны в круге";
            this.hoverButtonB1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.hoverButtonB1.UseVisualStyleBackColor = true;
            this.hoverButtonB1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hoverButtonB1_KeyDown);
            // 
            // hoverButton1
            // 
            this.hoverButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.ForeColor = System.Drawing.Color.White;
            this.hoverButton1.Location = new System.Drawing.Point(78, 63);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(372, 305);
            this.hoverButton1.TabIndex = 0;
            this.hoverButton1.Text = "Бибизяны в квадрате";
            this.hoverButton1.UseVisualStyleBackColor = true;
            this.hoverButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hoverButton1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(604, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 612);
            this.label2.TabIndex = 3;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(868, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тест";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 694);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoverButtonB1);
            this.Controls.Add(this.hoverButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HoverButton hoverButton1;
        private HoverButtonB hoverButtonB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

