namespace SubventionsProject
{
    partial class FilterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboGetSubvention = new System.Windows.Forms.ComboBox();
            this.comboSetSubvention = new System.Windows.Forms.ComboBox();
            this.comboYears = new System.Windows.Forms.ComboBox();
            this.comboSum = new System.Windows.Forms.ComboBox();
            this.OkButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CloseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboMunicipal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(163, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Получатель субвенции:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(115, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Распределитель субвенции:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(51, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год, на который выдана субвенция:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(34, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Объём выданных денежных средств:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(46, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата получения денежных средств:";
            // 
            // comboGetSubvention
            // 
            this.comboGetSubvention.FormattingEnabled = true;
            this.comboGetSubvention.Location = new System.Drawing.Point(402, 134);
            this.comboGetSubvention.Name = "comboGetSubvention";
            this.comboGetSubvention.Size = new System.Drawing.Size(318, 21);
            this.comboGetSubvention.TabIndex = 7;
            // 
            // comboSetSubvention
            // 
            this.comboSetSubvention.FormattingEnabled = true;
            this.comboSetSubvention.Location = new System.Drawing.Point(402, 170);
            this.comboSetSubvention.Name = "comboSetSubvention";
            this.comboSetSubvention.Size = new System.Drawing.Size(318, 21);
            this.comboSetSubvention.TabIndex = 8;
            // 
            // comboYears
            // 
            this.comboYears.FormattingEnabled = true;
            this.comboYears.Location = new System.Drawing.Point(402, 208);
            this.comboYears.Name = "comboYears";
            this.comboYears.Size = new System.Drawing.Size(318, 21);
            this.comboYears.TabIndex = 9;
            // 
            // comboSum
            // 
            this.comboSum.FormattingEnabled = true;
            this.comboSum.Location = new System.Drawing.Point(402, 242);
            this.comboSum.Name = "comboSum";
            this.comboSum.Size = new System.Drawing.Size(318, 21);
            this.comboSum.TabIndex = 10;
            // 
            // OkButton
            // 
            this.OkButton.Depth = 0;
            this.OkButton.Location = new System.Drawing.Point(258, 337);
            this.OkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkButton.Name = "OkButton";
            this.OkButton.Primary = true;
            this.OkButton.Size = new System.Drawing.Size(124, 40);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Depth = 0;
            this.CloseButton.Location = new System.Drawing.Point(444, 337);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Primary = true;
            this.CloseButton.Size = new System.Drawing.Size(124, 40);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // comboMunicipal
            // 
            this.comboMunicipal.FormattingEnabled = true;
            this.comboMunicipal.Location = new System.Drawing.Point(404, 99);
            this.comboMunicipal.Name = "comboMunicipal";
            this.comboMunicipal.Size = new System.Drawing.Size(318, 21);
            this.comboMunicipal.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(102, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Муниципальное образование:";
            // 
            // comboDate
            // 
            this.comboDate.FormattingEnabled = true;
            this.comboDate.Location = new System.Drawing.Point(402, 282);
            this.comboDate.Name = "comboDate";
            this.comboDate.Size = new System.Drawing.Size(318, 21);
            this.comboDate.TabIndex = 25;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 417);
            this.Controls.Add(this.comboDate);
            this.Controls.Add(this.comboMunicipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.comboSum);
            this.Controls.Add(this.comboYears);
            this.Controls.Add(this.comboSetSubvention);
            this.Controls.Add(this.comboGetSubvention);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FilterForm";
            this.Text = "Параметры фильтрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboGetSubvention;
        private System.Windows.Forms.ComboBox comboSetSubvention;
        private System.Windows.Forms.ComboBox comboYears;
        private System.Windows.Forms.ComboBox comboSum;
        private MaterialSkin.Controls.MaterialRaisedButton OkButton;
        private MaterialSkin.Controls.MaterialRaisedButton CloseButton;
        private System.Windows.Forms.ComboBox comboMunicipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDate;
    }
}