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
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OpenButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.FilterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExportButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // FillterButton
            // 
            this.FilterButton.Depth = 0;
            this.FilterButton.Location = new System.Drawing.Point(1081, 298);
            this.FilterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FilterButton.Name = "FillterButton";
            this.FilterButton.Primary = true;
            this.FilterButton.Size = new System.Drawing.Size(122, 39);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.Text = "Фильтр реестра";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FillterButton_Click);
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
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 411);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Окно реестра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton FilterButton;
        private MaterialSkin.Controls.MaterialRaisedButton ExportButton;
        private MaterialSkin.Controls.MaterialRaisedButton ExitButton;
        public MaterialSkin.Controls.MaterialRaisedButton AddButton;
        public MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        public MaterialSkin.Controls.MaterialRaisedButton OpenButton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}