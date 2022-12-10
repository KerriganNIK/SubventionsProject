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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboReceiver = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SumTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Depth = 0;
            this.CloseButton.Location = new System.Drawing.Point(467, 249);
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
            this.OkButton.Location = new System.Drawing.Point(281, 249);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Primary = true;
            this.OkButton.Size = new System.Drawing.Size(124, 40);
            this.OkButton.TabIndex = 26;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(425, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboReceiver
            // 
            this.comboReceiver.FormattingEnabled = true;
            this.comboReceiver.Location = new System.Drawing.Point(425, 114);
            this.comboReceiver.Name = "comboReceiver";
            this.comboReceiver.Size = new System.Drawing.Size(318, 21);
            this.comboReceiver.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(69, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Дата получения денежных средств:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(186, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Получатель субвенции:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(57, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Объём выданных денежных средств:";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Depth = 0;
            this.SumTextBox.Hint = "";
            this.SumTextBox.Location = new System.Drawing.Point(425, 154);
            this.SumTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.PasswordChar = '\0';
            this.SumTextBox.SelectedText = "";
            this.SumTextBox.SelectionLength = 0;
            this.SumTextBox.SelectionStart = 0;
            this.SumTextBox.Size = new System.Drawing.Size(318, 23);
            this.SumTextBox.TabIndex = 29;
            this.SumTextBox.UseSystemPasswordChar = false;
            // 
            // RegistrationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 355);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboReceiver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "RegistrationCardForm";
            this.Text = "Учётная карточка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CloseButton;
        private MaterialSkin.Controls.MaterialRaisedButton OkButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboReceiver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField SumTextBox;
    }
}