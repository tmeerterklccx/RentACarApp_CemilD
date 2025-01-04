namespace RentACarApp_CemilD
{
    partial class Giris
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
            label1 = new Label();
            label2 = new Label();
            tcTBox = new TextBox();
            sifreTBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(78, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 28);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(46, 88);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "ŞİFRE";
            // 
            // tcTBox
            // 
            tcTBox.Location = new Point(154, 42);
            tcTBox.Name = "tcTBox";
            tcTBox.Size = new Size(167, 23);
            tcTBox.TabIndex = 2;
            // 
            // sifreTBox
            // 
            sifreTBox.Location = new Point(154, 88);
            sifreTBox.Name = "sifreTBox";
            sifreTBox.Size = new Size(167, 23);
            sifreTBox.TabIndex = 3;
            sifreTBox.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(145, 147);
            button1.Name = "button1";
            button1.Size = new Size(176, 50);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 219);
            Controls.Add(button1);
            Controls.Add(sifreTBox);
            Controls.Add(tcTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Giris";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tcTBox;
        private TextBox sifreTBox;
        private Button button1;
    }
}
