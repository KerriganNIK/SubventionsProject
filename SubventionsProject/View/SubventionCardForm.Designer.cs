namespace SubventionsProject
{
    partial class SubventionCardForm
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
            this.EditButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddTransactionButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridSubvention = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubvention)).BeginInit();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Depth = 0;
            this.EditButton.Location = new System.Drawing.Point(781, 525);
            this.EditButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditButton.Name = "EditButton";
            this.EditButton.Primary = true;
            this.EditButton.Size = new System.Drawing.Size(124, 44);
            this.EditButton.TabIndex = 77;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.Depth = 0;
            this.AddTransactionButton.Location = new System.Drawing.Point(781, 455);
            this.AddTransactionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Primary = true;
            this.AddTransactionButton.Size = new System.Drawing.Size(124, 44);
            this.AddTransactionButton.TabIndex = 76;
            this.AddTransactionButton.Text = "Добавить транзакцию";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(429, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(423, 20);
            this.textBox2.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 20);
            this.textBox1.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(73, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Дата получения денежных средств:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Location = new System.Drawing.Point(511, 692);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Primary = true;
            this.ButtonCancel.Size = new System.Drawing.Size(149, 53);
            this.ButtonCancel.TabIndex = 67;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Depth = 0;
            this.ButtonOk.Location = new System.Drawing.Point(307, 692);
            this.ButtonOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Primary = true;
            this.ButtonOk.Size = new System.Drawing.Size(149, 53);
            this.ButtonOk.TabIndex = 66;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(242, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Транзакции субвенции";
            // 
            // dataGridSubvention
            // 
            this.dataGridSubvention.AllowUserToAddRows = false;
            this.dataGridSubvention.AllowUserToDeleteRows = false;
            this.dataGridSubvention.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridSubvention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubvention.Location = new System.Drawing.Point(35, 355);
            this.dataGridSubvention.Name = "dataGridSubvention";
            this.dataGridSubvention.ReadOnly = true;
            this.dataGridSubvention.Size = new System.Drawing.Size(731, 274);
            this.dataGridSubvention.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(61, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Объём выданных денежных средств:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(78, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "Год, на который выдана субвенция:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(142, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Распределитель субвенции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(190, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Получатель субвенции:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(127, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Муниципальное образование:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(429, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(423, 20);
            this.textBox5.TabIndex = 74;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(429, 132);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(423, 20);
            this.textBox4.TabIndex = 73;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(429, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(423, 20);
            this.textBox3.TabIndex = 72;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(429, 275);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(423, 20);
            this.textBox6.TabIndex = 75;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(429, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(429, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(423, 21);
            this.comboBox2.TabIndex = 62;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(429, 167);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(423, 21);
            this.comboBox3.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(429, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(423, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // SubventionCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 789);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridSubvention);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "SubventionCardForm";
            this.Text = "Карточка субвенции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubvention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton EditButton;
        private MaterialSkin.Controls.MaterialRaisedButton AddTransactionButton;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonCancel;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonOk;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dataGridSubvention;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}