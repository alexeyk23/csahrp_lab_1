namespace csharp_lab_1
{
    partial class frmNewStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxFio = new System.Windows.Forms.TextBox();
            this.numpdCurs = new System.Windows.Forms.NumericUpDown();
            this.numpdGroup = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numpdCurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpdGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Курс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа";
            // 
            // txbxFio
            // 
            this.txbxFio.Location = new System.Drawing.Point(77, 19);
            this.txbxFio.Name = "txbxFio";
            this.txbxFio.Size = new System.Drawing.Size(226, 20);
            this.txbxFio.TabIndex = 3;
            // 
            // numpdCurs
            // 
            this.numpdCurs.Location = new System.Drawing.Point(178, 46);
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
            this.numpdCurs.TabIndex = 4;
            this.numpdCurs.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numpdGroup
            // 
            this.numpdGroup.Location = new System.Drawing.Point(178, 72);
            this.numpdGroup.Maximum = new decimal(new int[] {
            91,
            0,
            0,
            0});
            this.numpdGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numpdGroup.Name = "numpdGroup";
            this.numpdGroup.Size = new System.Drawing.Size(120, 20);
            this.numpdGroup.TabIndex = 5;
            this.numpdGroup.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(77, 120);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 164);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numpdGroup);
            this.Controls.Add(this.numpdCurs);
            this.Controls.Add(this.txbxFio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewStudent";
            this.Text = "Новый студент";
            this.Load += new System.EventHandler(this.frmNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numpdCurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpdGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxFio;
        private System.Windows.Forms.NumericUpDown numpdCurs;
        private System.Windows.Forms.NumericUpDown numpdGroup;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button2;
    }
}