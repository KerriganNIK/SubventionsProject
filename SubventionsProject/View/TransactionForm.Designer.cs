namespace SubventionsProject.View
{
    partial class TransactionForm
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
            this.WriteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AmountTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WriteButton
            // 
            this.WriteButton.Depth = 0;
            this.WriteButton.Location = new System.Drawing.Point(218, 174);
            this.WriteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Primary = true;
            this.WriteButton.Size = new System.Drawing.Size(109, 39);
            this.WriteButton.TabIndex = 3;
            this.WriteButton.Text = "Ок";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Depth = 0;
            this.CancelButton.Location = new System.Drawing.Point(351, 174);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = true;
            this.CancelButton.Size = new System.Drawing.Size(106, 39);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Depth = 0;
            this.AmountTextBox.Hint = "";
            this.AmountTextBox.Location = new System.Drawing.Point(317, 84);
            this.AmountTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.PasswordChar = '\0';
            this.AmountTextBox.SelectedText = "";
            this.AmountTextBox.SelectionLength = 0;
            this.AmountTextBox.SelectionStart = 0;
            this.AmountTextBox.Size = new System.Drawing.Size(318, 23);
            this.AmountTextBox.TabIndex = 33;
            this.AmountTextBox.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(15, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Дата совершения транзакции:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(114, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Объём транзакции:";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 247);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.WriteButton);
            this.Name = "TransactionForm";
            this.Text = "Новая транзакция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialRaisedButton WriteButton;
        public MaterialSkin.Controls.MaterialRaisedButton CancelButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField AmountTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}