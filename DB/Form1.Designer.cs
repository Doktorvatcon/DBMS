namespace DB
{
    partial class Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_name = new System.Windows.Forms.Label();
            this.Delete_row = new System.Windows.Forms.Button();
            this.Insert_Row = new System.Windows.Forms.Button();
            this.update_row = new System.Windows.Forms.Button();
            this.Add_all = new System.Windows.Forms.Button();
            this.Update_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.InstructionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UploadToolStripMenuItem
            // 
            this.UploadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
            this.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem";
            this.UploadToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.UploadToolStripMenuItem.Text = "Открыть базу данных";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.aboutProgramToolStripMenuItem.Text = "Об программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // InstructionToolStripMenuItem
            // 
            this.InstructionToolStripMenuItem.Name = "InstructionToolStripMenuItem";
            this.InstructionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.InstructionToolStripMenuItem.Text = "Инструкция";
            this.InstructionToolStripMenuItem.Click += new System.EventHandler(this.InstructionToolStripMenuItem_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_name.Location = new System.Drawing.Point(39, 26);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 37);
            this.label_name.TabIndex = 2;
            // 
            // Delete_row
            // 
            this.Delete_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Delete_row.Location = new System.Drawing.Point(607, 66);
            this.Delete_row.Name = "Delete_row";
            this.Delete_row.Size = new System.Drawing.Size(163, 47);
            this.Delete_row.TabIndex = 3;
            this.Delete_row.Text = "Удалить строку";
            this.Delete_row.UseVisualStyleBackColor = true;
            this.Delete_row.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert_Row
            // 
            this.Insert_Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Insert_Row.Location = new System.Drawing.Point(607, 139);
            this.Insert_Row.Name = "Insert_Row";
            this.Insert_Row.Size = new System.Drawing.Size(163, 47);
            this.Insert_Row.TabIndex = 4;
            this.Insert_Row.Text = "Добавить строку";
            this.Insert_Row.UseVisualStyleBackColor = true;
            this.Insert_Row.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_row
            // 
            this.update_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.update_row.Location = new System.Drawing.Point(607, 210);
            this.update_row.Name = "update_row";
            this.update_row.Size = new System.Drawing.Size(163, 47);
            this.update_row.TabIndex = 5;
            this.update_row.Text = "Обновить строку";
            this.update_row.UseVisualStyleBackColor = true;
            this.update_row.Click += new System.EventHandler(this.update_row_Click);
            // 
            // Add_all
            // 
            this.Add_all.Location = new System.Drawing.Point(607, 276);
            this.Add_all.Name = "Add_all";
            this.Add_all.Size = new System.Drawing.Size(163, 23);
            this.Add_all.TabIndex = 6;
            this.Add_all.Text = "Добавить все";
            this.Add_all.UseVisualStyleBackColor = true;
            this.Add_all.Click += new System.EventHandler(this.Add_all_Click);
            // 
            // Update_all
            // 
            this.Update_all.Location = new System.Drawing.Point(607, 314);
            this.Update_all.Name = "Update_all";
            this.Update_all.Size = new System.Drawing.Size(163, 23);
            this.Update_all.TabIndex = 7;
            this.Update_all.Text = "Обновить все";
            this.Update_all.UseVisualStyleBackColor = true;
            this.Update_all.Click += new System.EventHandler(this.Update_all_Click);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.Update_all);
            this.Controls.Add(this.Add_all);
            this.Controls.Add(this.update_row);
            this.Controls.Add(this.Insert_Row);
            this.Controls.Add(this.Delete_row);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button Delete_row;
        private System.Windows.Forms.Button Insert_Row;
        private System.Windows.Forms.Button update_row;
        private System.Windows.Forms.ToolStripMenuItem InstructionToolStripMenuItem;
        private System.Windows.Forms.Button Add_all;
        private System.Windows.Forms.Button Update_all;
    }
}

