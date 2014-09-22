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
            this.button1 = new System.Windows.Forms.Button();
            this.grpbxStudentActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxStudentActions
            // 
            this.grpbxStudentActions.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 449);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.grpbxStudentActions);
            this.Name = "Form1";
            this.Text = "Студент";
            this.grpbxStudentActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
    }
}

