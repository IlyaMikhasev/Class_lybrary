namespace test_dll_forms
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
            this.tb_message = new System.Windows.Forms.TextBox();
            this.b_message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(25, 42);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(284, 20);
            this.tb_message.TabIndex = 0;
            // 
            // b_message
            // 
            this.b_message.Location = new System.Drawing.Point(335, 42);
            this.b_message.Name = "b_message";
            this.b_message.Size = new System.Drawing.Size(75, 23);
            this.b_message.TabIndex = 1;
            this.b_message.Text = "Сообщение";
            this.b_message.UseVisualStyleBackColor = true;
            this.b_message.Click += new System.EventHandler(this.b_message_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_message);
            this.Controls.Add(this.tb_message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button b_message;
    }
}

