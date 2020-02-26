namespace TestControlsApplication
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
            this.rgbControl1 = new MyControls_ex3_.RGBControl();
            this.SuspendLayout();
            // 
            // rgbControl1
            // 
            this.rgbControl1.Location = new System.Drawing.Point(12, 21);
            this.rgbControl1.Name = "rgbControl1";
            this.rgbControl1.NumSystem = MyControls_ex3_.NumSys.Dec;
            this.rgbControl1.Size = new System.Drawing.Size(371, 153);
            this.rgbControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 192);
            this.Controls.Add(this.rgbControl1);
            this.Name = "Form1";
            this.Text = "Color";
            this.ResumeLayout(false);

        }

        #endregion
        private MyControls_ex3_.RGBControl rgbControl1;
    }
}

