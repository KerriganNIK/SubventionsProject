namespace SubventionsProject
{
    partial class RegistrationCardForm
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
            this.CloseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OkButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboReceiver = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.YearTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Depth = 0;
            this.CloseButton.Location = new System.Drawing.Point(396, 203);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Primary = true;
            this.CloseButton.Size = new System.Drawing.Size(124, 40);
            this.CloseButton.TabIndex = 27;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Depth = 0;
            this.OkButton.Location = new System.Drawing.Point(237, 203);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Primary = true;
            this.OkButton.Size = new System.Drawing.Size(124, 40);
            this.OkButton.TabIndex = 26;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // comboReceiver
            // 
            this.comboReceiver.FormattingEnabled = true;
            this.comboReceiver.Location = new System.Drawing.Point(379, 79);
            this.comboReceiver.Name = "comboReceiver";
            this.comboReceiver.Size = new System.Drawing.Size(318, 21);
            this.comboReceiver.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(31, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Год, на который выдана субвенция:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(140, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Получатель субвенции:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Объём выданных денежных средств:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Depth = 0;
            this.AmountTextBox.Hint = "";
            this.AmountTextBox.Location = new System.Drawing.Point(379, 119);
            this.AmountTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.PasswordChar = '\0';
            this.AmountTextBox.SelectedText = "";
            this.AmountTextBox.SelectionLength = 0;
            this.AmountTextBox.SelectionStart = 0;
            this.AmountTextBox.Size = new System.Drawing.Size(318, 23);
            this.AmountTextBox.TabIndex = 29;
            this.AmountTextBox.UseSystemPasswordChar = false;
            // 
            // YearTextbox
            // 
            this.YearTextbox.Depth = 0;
            this.YearTextbox.Hint = "";
            this.YearTextbox.Location = new System.Drawing.Point(379, 156);
            this.YearTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.YearTextbox.Name = "YearTextbox";
            this.YearTextbox.PasswordChar = '\0';
            this.YearTextbox.SelectedText = "";
            this.YearTextbox.SelectionLength = 0;
            this.YearTextbox.SelectionStart = 0;
            this.YearTextbox.Size = new System.Drawing.Size(318, 23);
            this.YearTextbox.TabIndex = 30;
            this.YearTextbox.UseSystemPasswordChar = false;
            // 
            // RegistrationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 265);
            this.Controls.Add(this.YearTextbox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.comboReceiver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "RegistrationCardForm";
            this.Text = "Учётная карточка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationCardForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CloseButton;
        private MaterialSkin.Controls.MaterialRaisedButton OkButton;
        private System.Windows.Forms.ComboBox comboReceiver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField AmountTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField YearTextbox;
    }
}