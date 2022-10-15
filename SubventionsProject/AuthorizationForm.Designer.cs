﻿namespace SubventionsProject
{
    partial class AuthorizationForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PasswordText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OkButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CloseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.LoginLabel.Location = new System.Drawing.Point(88, 116);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(74, 25);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.PasswordLabel.Location = new System.Drawing.Point(79, 153);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 25);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LoginText
            // 
            this.LoginText.Depth = 0;
            this.LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LoginText.Hint = "";
            this.LoginText.Location = new System.Drawing.Point(177, 118);
            this.LoginText.Margin = new System.Windows.Forms.Padding(2);
            this.LoginText.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginText.Name = "LoginText";
            this.LoginText.PasswordChar = '\0';
            this.LoginText.SelectedText = "";
            this.LoginText.SelectionLength = 0;
            this.LoginText.SelectionStart = 0;
            this.LoginText.Size = new System.Drawing.Size(181, 23);
            this.LoginText.TabIndex = 2;
            this.LoginText.UseSystemPasswordChar = false;
            // 
            // PasswordText
            // 
            this.PasswordText.Depth = 0;
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PasswordText.Hint = "";
            this.PasswordText.Location = new System.Drawing.Point(177, 154);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordText.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '\0';
            this.PasswordText.SelectedText = "";
            this.PasswordText.SelectionLength = 0;
            this.PasswordText.SelectionStart = 0;
            this.PasswordText.Size = new System.Drawing.Size(181, 23);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.UseSystemPasswordChar = false;
            // 
            // OkButton
            // 
            this.OkButton.Depth = 0;
            this.OkButton.Location = new System.Drawing.Point(119, 227);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Primary = true;
            this.OkButton.Size = new System.Drawing.Size(93, 35);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Depth = 0;
            this.CloseButton.Location = new System.Drawing.Point(239, 227);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Primary = true;
            this.CloseButton.Size = new System.Drawing.Size(93, 35);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 298);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginText;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordText;
        private MaterialSkin.Controls.MaterialRaisedButton OkButton;
        private MaterialSkin.Controls.MaterialRaisedButton CloseButton;
    }
}

