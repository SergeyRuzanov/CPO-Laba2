namespace MyControls_ex3_
{
    partial class RGBControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HexRadBtn = new System.Windows.Forms.RadioButton();
            this.DecRadBtn = new System.Windows.Forms.RadioButton();
            this.displayColor1 = new MyControls_ex3_.DisplayColor();
            this.BlueRGBNum = new MyControls_ex3_.RGBNumber();
            this.GreenRGBNum = new MyControls_ex3_.RGBNumber();
            this.RedRGBNum = new MyControls_ex3_.RGBNumber();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Синий";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HexRadBtn);
            this.panel1.Controls.Add(this.DecRadBtn);
            this.panel1.Location = new System.Drawing.Point(20, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 33);
            this.panel1.TabIndex = 8;
            // 
            // HexRadBtn
            // 
            this.HexRadBtn.AutoSize = true;
            this.HexRadBtn.Location = new System.Drawing.Point(73, 3);
            this.HexRadBtn.Name = "HexRadBtn";
            this.HexRadBtn.Size = new System.Drawing.Size(53, 21);
            this.HexRadBtn.TabIndex = 1;
            this.HexRadBtn.TabStop = true;
            this.HexRadBtn.Text = "Hex";
            this.HexRadBtn.UseVisualStyleBackColor = true;
            this.HexRadBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // DecRadBtn
            // 
            this.DecRadBtn.AutoSize = true;
            this.DecRadBtn.Checked = true;
            this.DecRadBtn.Location = new System.Drawing.Point(3, 3);
            this.DecRadBtn.Name = "DecRadBtn";
            this.DecRadBtn.Size = new System.Drawing.Size(54, 21);
            this.DecRadBtn.TabIndex = 0;
            this.DecRadBtn.TabStop = true;
            this.DecRadBtn.Text = "Dec";
            this.DecRadBtn.UseVisualStyleBackColor = true;
            this.DecRadBtn.CheckedChanged += new System.EventHandler(this.RadioBtn_CheckedChanged);
            // 
            // displayColor1
            // 
            this.displayColor1.Color = System.Drawing.Color.Empty;
            this.displayColor1.Location = new System.Drawing.Point(226, 4);
            this.displayColor1.Name = "displayColor1";
            this.displayColor1.Size = new System.Drawing.Size(142, 146);
            this.displayColor1.TabIndex = 6;
            // 
            // BlueRGBNum
            // 
            this.BlueRGBNum.Location = new System.Drawing.Point(119, 89);
            this.BlueRGBNum.Name = "BlueRGBNum";
            this.BlueRGBNum.NumSystem = MyControls_ex3_.NumSys.Dec;
            this.BlueRGBNum.Size = new System.Drawing.Size(100, 22);
            this.BlueRGBNum.TabIndex = 5;
            this.BlueRGBNum.Text = "0";
            // 
            // GreenRGBNum
            // 
            this.GreenRGBNum.Location = new System.Drawing.Point(119, 57);
            this.GreenRGBNum.Name = "GreenRGBNum";
            this.GreenRGBNum.NumSystem = MyControls_ex3_.NumSys.Dec;
            this.GreenRGBNum.Size = new System.Drawing.Size(100, 22);
            this.GreenRGBNum.TabIndex = 4;
            this.GreenRGBNum.Text = "0";
            // 
            // RedRGBNum
            // 
            this.RedRGBNum.Location = new System.Drawing.Point(119, 24);
            this.RedRGBNum.Name = "RedRGBNum";
            this.RedRGBNum.NumSystem = MyControls_ex3_.NumSys.Dec;
            this.RedRGBNum.Size = new System.Drawing.Size(100, 22);
            this.RedRGBNum.TabIndex = 0;
            this.RedRGBNum.Text = "0";
            // 
            // RGBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayColor1);
            this.Controls.Add(this.BlueRGBNum);
            this.Controls.Add(this.GreenRGBNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedRGBNum);
            this.Name = "RGBControl";
            this.Size = new System.Drawing.Size(371, 153);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RGBNumber RedRGBNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RGBNumber GreenRGBNum;
        private RGBNumber BlueRGBNum;
        private DisplayColor displayColor1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton HexRadBtn;
        private System.Windows.Forms.RadioButton DecRadBtn;
    }
}
