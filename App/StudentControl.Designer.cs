namespace App
{
    partial class StudentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentControl));
            this.button3 = new System.Windows.Forms.Button();
            this.searchStudentTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.register_Btn = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(735, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 21);
            this.button3.TabIndex = 34;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // searchStudentTB
            // 
            this.searchStudentTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchStudentTB.Location = new System.Drawing.Point(473, 13);
            this.searchStudentTB.Name = "searchStudentTB";
            this.searchStudentTB.Size = new System.Drawing.Size(263, 20);
            this.searchStudentTB.TabIndex = 33;
            this.searchStudentTB.Text = "Search Student";
            this.searchStudentTB.TextChanged += new System.EventHandler(this.searchStudentTBTextChanged);
            this.searchStudentTB.Enter += new System.EventHandler(this.searchStudentTBEnter);
            this.searchStudentTB.Leave += new System.EventHandler(this.searchStudentTBLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Count";
            // 
            // studentTable
            // 
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Location = new System.Drawing.Point(18, 52);
            this.studentTable.Name = "studentTable";
            this.studentTable.Size = new System.Drawing.Size(742, 330);
            this.studentTable.TabIndex = 31;
            this.studentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentCell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Count  :";
            // 
            // register_Btn
            // 
            this.register_Btn.BackColor = System.Drawing.Color.DarkCyan;
            this.register_Btn.ForeColor = System.Drawing.Color.White;
            this.register_Btn.Location = new System.Drawing.Point(602, 389);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.Size = new System.Drawing.Size(158, 40);
            this.register_Btn.TabIndex = 35;
            this.register_Btn.Text = "Register";
            this.register_Btn.UseVisualStyleBackColor = false;
            this.register_Btn.Click += new System.EventHandler(this.Student_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.updateBTN.ForeColor = System.Drawing.Color.White;
            this.updateBTN.Location = new System.Drawing.Point(602, 389);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(158, 40);
            this.updateBTN.TabIndex = 36;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Visible = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.cancelBTN.ForeColor = System.Drawing.Color.White;
            this.cancelBTN.Location = new System.Drawing.Point(274, 389);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(158, 40);
            this.cancelBTN.TabIndex = 37;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Visible = false;
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.deleteBTN.ForeColor = System.Drawing.Color.White;
            this.deleteBTN.Location = new System.Drawing.Point(438, 386);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(158, 40);
            this.deleteBTN.TabIndex = 38;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Visible = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.register_Btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchStudentTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentTable);
            this.Controls.Add(this.label1);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(775, 429);
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchStudentTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView studentTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_Btn;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button deleteBTN;
    }
}
