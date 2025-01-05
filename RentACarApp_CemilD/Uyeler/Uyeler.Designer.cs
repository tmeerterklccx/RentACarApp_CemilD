namespace RentACarApp_CemilD
{
    partial class Uyeler
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tCDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eMailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yetkiDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            statuDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            userBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            uyeSil_BTN = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIDDataGridViewTextBoxColumn, tCDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, eMailDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, yetkiDataGridViewCheckBoxColumn, statuDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(735, 299);
            dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            tCDataGridViewTextBoxColumn.HeaderText = "TC";
            tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            tCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yetkiDataGridViewCheckBoxColumn
            // 
            yetkiDataGridViewCheckBoxColumn.DataPropertyName = "Yetki";
            yetkiDataGridViewCheckBoxColumn.HeaderText = "Yetki";
            yetkiDataGridViewCheckBoxColumn.Name = "yetkiDataGridViewCheckBoxColumn";
            yetkiDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // statuDataGridViewCheckBoxColumn
            // 
            statuDataGridViewCheckBoxColumn.DataPropertyName = "Statu";
            statuDataGridViewCheckBoxColumn.HeaderText = "Statu";
            statuDataGridViewCheckBoxColumn.Name = "statuDataGridViewCheckBoxColumn";
            statuDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(EntityLayer.Concrete.User);
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 11.25F);
            button1.Location = new Point(372, 317);
            button1.Name = "button1";
            button1.Size = new Size(121, 53);
            button1.TabIndex = 4;
            button1.Text = "Üye Ara";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei", 11.25F);
            button2.Location = new Point(499, 317);
            button2.Name = "button2";
            button2.Size = new Size(121, 53);
            button2.TabIndex = 5;
            button2.Text = "Seçili Üyeyi Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // uyeSil_BTN
            // 
            uyeSil_BTN.Font = new Font("Microsoft YaHei", 11.25F);
            uyeSil_BTN.Location = new Point(626, 317);
            uyeSil_BTN.Name = "uyeSil_BTN";
            uyeSil_BTN.Size = new Size(121, 53);
            uyeSil_BTN.TabIndex = 6;
            uyeSil_BTN.Text = "Seçili Üyeyi Sil";
            uyeSil_BTN.UseVisualStyleBackColor = true;
            uyeSil_BTN.Click += uyeSil_BTN_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 334);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 401);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 23);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 11.25F);
            label1.Location = new Point(39, 338);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 9;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 11.25F);
            label2.Location = new Point(39, 400);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 10;
            label2.Text = "AD";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei", 11.25F);
            button3.Location = new Point(372, 384);
            button3.Name = "button3";
            button3.Size = new Size(375, 53);
            button3.TabIndex = 11;
            button3.Text = "Yeni Üye Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += uyeEkle_BTN_Click;
            // 
            // Uyeler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 449);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(uyeSil_BTN);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Uyeler";
            Text = "Uyeler";
            Load += Uyeler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
//        private Button uyeEkle_BTN;
        private Button button1;
        private Button button2;
        private Button uyeSil_BTN;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button3;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn yetkiDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn statuDataGridViewCheckBoxColumn;
        private BindingSource userBindingSource;
    }
}