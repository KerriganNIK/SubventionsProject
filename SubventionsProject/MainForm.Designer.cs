namespace SubventionsProject
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OpenButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.FillterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExportButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ВетСлужба";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1037, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Муниципального района";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1037, 422);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(493, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Записи по субвенциям";
            // 
            // AddButton
            // 
            this.AddButton.Depth = 0;
            this.AddButton.Location = new System.Drawing.Point(1081, 147);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = true;
            this.AddButton.Size = new System.Drawing.Size(122, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Location = new System.Drawing.Point(1081, 192);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(122, 39);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            this.OpenButton.Depth = 0;
            this.OpenButton.Location = new System.Drawing.Point(1081, 237);
            this.OpenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Primary = true;
            this.OpenButton.Size = new System.Drawing.Size(122, 39);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // FillterButton
            // 
            this.FillterButton.Depth = 0;
            this.FillterButton.Location = new System.Drawing.Point(1081, 298);
            this.FillterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FillterButton.Name = "FillterButton";
            this.FillterButton.Primary = true;
            this.FillterButton.Size = new System.Drawing.Size(122, 39);
            this.FillterButton.TabIndex = 5;
            this.FillterButton.Text = "Фильтр реестра";
            this.FillterButton.UseVisualStyleBackColor = true;
            this.FillterButton.Click += new System.EventHandler(this.FillterButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Depth = 0;
            this.ExportButton.Location = new System.Drawing.Point(1081, 343);
            this.ExportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Primary = true;
            this.ExportButton.Size = new System.Drawing.Size(122, 39);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "Экспорт в EXCEL";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Depth = 0;
            this.ExitButton.Location = new System.Drawing.Point(1081, 499);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Primary = true;
            this.ExitButton.Size = new System.Drawing.Size(122, 39);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 564);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.FillterButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Окно реестра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialRaisedButton FillterButton;
        private MaterialSkin.Controls.MaterialRaisedButton ExportButton;
        private MaterialSkin.Controls.MaterialRaisedButton ExitButton;
        public MaterialSkin.Controls.MaterialRaisedButton AddButton;
        public MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        public MaterialSkin.Controls.MaterialRaisedButton OpenButton;
    }
}