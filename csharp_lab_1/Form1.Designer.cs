namespace csharp_lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbxStudentActions = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxSubjName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numpdCurs = new System.Windows.Forms.NumericUpDown();
            this.btnGoMidMark = new System.Windows.Forms.Button();
            this.grpbxStudentActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpdCurs)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxStudentActions
            // 
            this.grpbxStudentActions.Controls.Add(this.btnGoMidMark);
            this.grpbxStudentActions.Controls.Add(this.numpdCurs);
            this.grpbxStudentActions.Controls.Add(this.label3);
            this.grpbxStudentActions.Controls.Add(this.label2);
            this.grpbxStudentActions.Controls.Add(this.txbxSubjName);
            this.grpbxStudentActions.Controls.Add(this.label1);
            this.grpbxStudentActions.Controls.Add(this.btnAddStudent);
            this.grpbxStudentActions.Controls.Add(this.dgvStudents);
            this.grpbxStudentActions.Location = new System.Drawing.Point(12, 32);
            this.grpbxStudentActions.Name = "grpbxStudentActions";
            this.grpbxStudentActions.Size = new System.Drawing.Size(405, 401);
            this.grpbxStudentActions.TabIndex = 0;
            this.grpbxStudentActions.TabStop = false;
            this.grpbxStudentActions.Text = "Студенты";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(6, 256);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(135, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Добавить студента";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFio,
            this.colCurs,
            this.colGroup});
            this.dgvStudents.Location = new System.Drawing.Point(6, 19);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(391, 231);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // colFio
            // 
            this.colFio.FillWeight = 154.2799F;
            this.colFio.HeaderText = "ФИО";
            this.colFio.Name = "colFio";
            this.colFio.ReadOnly = true;
            this.colFio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCurs
            // 
            this.colCurs.FillWeight = 47.83756F;
            this.colCurs.HeaderText = "Курс";
            this.colCurs.Name = "colCurs";
            this.colCurs.ReadOnly = true;
            this.colCurs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colGroup
            // 
            this.colGroup.FillWeight = 45.88255F;
            this.colGroup.HeaderText = "Группа";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colMark});
            this.dgvSessions.Location = new System.Drawing.Point(423, 51);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(271, 382);
            this.dgvSessions.TabIndex = 1;
            // 
            // colSubject
            // 
            this.colSubject.FillWeight = 142.132F;
            this.colSubject.HeaderText = "Предмет";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            // 
            // colMark
            // 
            this.colMark.FillWeight = 57.86803F;
            this.colMark.HeaderText = "Оценка";
            this.colMark.Name = "colMark";
            this.colMark.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromXMLToolStripMenuItem,
            this.loadFromBinaryToolStripMenuItem,
            this.loadFromTextToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToXMLToolStripMenuItem,
            this.saveToBinaryToolStripMenuItem,
            this.saveToTextToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // loadFromXMLToolStripMenuItem
            // 
            this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
            this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.loadFromXMLToolStripMenuItem.Text = "Загрузить из XML";
            this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.loadFromXMLToolStripMenuItem_Click);
            // 
            // loadFromBinaryToolStripMenuItem
            // 
            this.loadFromBinaryToolStripMenuItem.Name = "loadFromBinaryToolStripMenuItem";
            this.loadFromBinaryToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.loadFromBinaryToolStripMenuItem.Text = "Загрузить из бинарного файла";
            this.loadFromBinaryToolStripMenuItem.Click += new System.EventHandler(this.loadFromBinaryToolStripMenuItem_Click);
            // 
            // loadFromTextToolStripMenuItem
            // 
            this.loadFromTextToolStripMenuItem.Name = "loadFromTextToolStripMenuItem";
            this.loadFromTextToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.loadFromTextToolStripMenuItem.Text = "Загрузить из текстового файла";
            this.loadFromTextToolStripMenuItem.Click += new System.EventHandler(this.loadFromTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // saveToXMLToolStripMenuItem
            // 
            this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
            this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.saveToXMLToolStripMenuItem.Text = "Сохранить в XML";
            this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
            // 
            // saveToBinaryToolStripMenuItem
            // 
            this.saveToBinaryToolStripMenuItem.Name = "saveToBinaryToolStripMenuItem";
            this.saveToBinaryToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.saveToBinaryToolStripMenuItem.Text = "Сохранить в бинарный файл";
            this.saveToBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveToBinaryToolStripMenuItem_Click);
            // 
            // saveToTextToolStripMenuItem
            // 
            this.saveToTextToolStripMenuItem.Name = "saveToTextToolStripMenuItem";
            this.saveToTextToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.saveToTextToolStripMenuItem.Text = "Сохранить в текстовый файл";
            this.saveToTextToolStripMenuItem.Click += new System.EventHandler(this.saveToTextToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Подсчет среднего балла по предмету на курсе";
            // 
            // txbxSubjName
            // 
            this.txbxSubjName.Location = new System.Drawing.Point(132, 309);
            this.txbxSubjName.Name = "txbxSubjName";
            this.txbxSubjName.Size = new System.Drawing.Size(265, 20);
            this.txbxSubjName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название предмета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер курса";
            // 
            // numpdCurs
            // 
            this.numpdCurs.Location = new System.Drawing.Point(132, 342);
            this.numpdCurs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numpdCurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numpdCurs.Name = "numpdCurs";
            this.numpdCurs.Size = new System.Drawing.Size(120, 20);
            this.numpdCurs.TabIndex = 7;
            this.numpdCurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numpdCurs.ValueChanged += new System.EventHandler(this.numpdCurs_ValueChanged);
            // 
            // btnGoMidMark
            // 
            this.btnGoMidMark.Location = new System.Drawing.Point(279, 342);
            this.btnGoMidMark.Name = "btnGoMidMark";
            this.btnGoMidMark.Size = new System.Drawing.Size(120, 23);
            this.btnGoMidMark.TabIndex = 8;
            this.btnGoMidMark.Text = "Подсчитать";
            this.btnGoMidMark.UseVisualStyleBackColor = true;
            this.btnGoMidMark.Click += new System.EventHandler(this.btnGoMidMark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 446);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.grpbxStudentActions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Студент";
            this.grpbxStudentActions.ResumeLayout(false);
            this.grpbxStudentActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpdCurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxStudentActions;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMark;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnGoMidMark;
        private System.Windows.Forms.NumericUpDown numpdCurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxSubjName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToTextToolStripMenuItem;
    }
}

