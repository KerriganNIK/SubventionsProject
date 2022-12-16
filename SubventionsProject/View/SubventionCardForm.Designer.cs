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
            this.AddTransactionButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.YearText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonWrite = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getSubventionText = new System.Windows.Forms.TextBox();
            this.distributorText = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.getSubventionComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.municipalityText = new System.Windows.Forms.TextBox();
            this.TransactionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.Depth = 0;
            this.AddTransactionButton.Location = new System.Drawing.Point(345, 646);
            this.AddTransactionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Primary = true;
            this.AddTransactionButton.Size = new System.Drawing.Size(149, 53);
            this.AddTransactionButton.TabIndex = 76;
            this.AddTransactionButton.Text = "Добавить транзакцию";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // AmountText
            // 
            this.AmountText.Location = new System.Drawing.Point(390, 228);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(423, 20);
            this.AmountText.TabIndex = 71;
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(390, 194);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(423, 20);
            this.YearText.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(34, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Дата получения денежных средств:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Depth = 0;
            this.ButtonClose.Location = new System.Drawing.Point(663, 646);
            this.ButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Primary = true;
            this.ButtonClose.Size = new System.Drawing.Size(149, 53);
            this.ButtonClose.TabIndex = 67;
            this.ButtonClose.Text = "закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonWrite
            // 
            this.ButtonWrite.Depth = 0;
            this.ButtonWrite.Location = new System.Drawing.Point(34, 646);
            this.ButtonWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonWrite.Name = "ButtonWrite";
            this.ButtonWrite.Primary = true;
            this.ButtonWrite.Size = new System.Drawing.Size(149, 53);
            this.ButtonWrite.TabIndex = 66;
            this.ButtonWrite.Text = "записать";
            this.ButtonWrite.UseVisualStyleBackColor = true;
            this.ButtonWrite.Click += new System.EventHandler(this.ButtonWrite_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(269, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Транзакции субвенции";
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.AllowUserToAddRows = false;
            this.transactionsDataGridView.AllowUserToDeleteRows = false;
            this.transactionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionAmount,
            this.TransactionDate});
            this.transactionsDataGridView.Location = new System.Drawing.Point(35, 355);
            this.transactionsDataGridView.MultiSelect = false;
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.ReadOnly = true;
            this.transactionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsDataGridView.Size = new System.Drawing.Size(778, 274);
            this.transactionsDataGridView.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(22, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Объём выданных денежных средств:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(39, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "Год, на который выдана субвенция:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(103, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Распределитель субвенции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(151, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Получатель субвенции:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Муниципальное образование:";
            // 
            // getSubventionText
            // 
            this.getSubventionText.Location = new System.Drawing.Point(390, 121);
            this.getSubventionText.Name = "getSubventionText";
            this.getSubventionText.Size = new System.Drawing.Size(423, 20);
            this.getSubventionText.TabIndex = 73;
            // 
            // distributorText
            // 
            this.distributorText.Location = new System.Drawing.Point(390, 157);
            this.distributorText.Name = "distributorText";
            this.distributorText.Size = new System.Drawing.Size(423, 20);
            this.distributorText.TabIndex = 72;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(390, 264);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(423, 20);
            this.DateText.TabIndex = 75;
            // 
            // getSubventionComboBox
            // 
            this.getSubventionComboBox.FormattingEnabled = true;
            this.getSubventionComboBox.Location = new System.Drawing.Point(390, 120);
            this.getSubventionComboBox.Name = "getSubventionComboBox";
            this.getSubventionComboBox.Size = new System.Drawing.Size(423, 21);
            this.getSubventionComboBox.TabIndex = 62;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(423, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // municipalityText
            // 
            this.municipalityText.Location = new System.Drawing.Point(390, 80);
            this.municipalityText.Name = "municipalityText";
            this.municipalityText.Size = new System.Drawing.Size(423, 20);
            this.municipalityText.TabIndex = 74;
            // 
            // TransactionAmount
            // 
            this.TransactionAmount.HeaderText = "Объём транзакции";
            this.TransactionAmount.Name = "TransactionAmount";
            this.TransactionAmount.ReadOnly = true;
            this.TransactionAmount.Width = 200;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "Дата транзакции";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.Width = 300;
            // 
            // SubventionCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 711);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonWrite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transactionsDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.getSubventionComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.municipalityText);
            this.Controls.Add(this.distributorText);
            this.Controls.Add(this.getSubventionText);
            this.Name = "SubventionCardForm";
            this.Text = "Карточка субвенции";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton AddTransactionButton;
        public System.Windows.Forms.TextBox AmountText;
        public System.Windows.Forms.TextBox YearText;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonClose;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonWrite;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getSubventionText;
        private System.Windows.Forms.TextBox distributorText;
        private System.Windows.Forms.TextBox DateText;
        public System.Windows.Forms.ComboBox getSubventionComboBox;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox municipalityText;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
    }
}