namespace App
{
    partial class borrowcontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrowcontrol));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.name = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.booksDG = new System.Windows.Forms.DataGridView();
            this.bookList = new System.Windows.Forms.Label();
            this.overDue = new System.Windows.Forms.Label();
            this.borrowed = new System.Windows.Forms.Label();
            this.bookSearchTB = new System.Windows.Forms.TextBox();
            this.borrowListDG = new System.Windows.Forms.DataGridView();
            this.borrowList = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.borrowbtn = new System.Windows.Forms.Button();
            this.addBookBTN = new System.Windows.Forms.Button();
            this.studentSearchBTN = new System.Windows.Forms.Button();
            this.studentSearchTB = new System.Windows.Forms.TextBox();
            this.student_Name = new System.Windows.Forms.Label();
            this.student_Department = new System.Windows.Forms.Label();
            this.student_Due = new System.Windows.Forms.Label();
            this.student_Borrowed = new System.Windows.Forms.Label();
            this.TotalCopiesLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowedDate = new System.Windows.Forms.DateTimePicker();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.booksDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowListDG)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.name.Location = new System.Drawing.Point(20, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 14);
            this.name.TabIndex = 0;
            this.name.Text = "Name                     :";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.department.Location = new System.Drawing.Point(20, 130);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(84, 14);
            this.department.TabIndex = 1;
            this.department.Text = "Department      :";
            // 
            // booksDG
            // 
            this.booksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDG.Location = new System.Drawing.Point(14, 226);
            this.booksDG.Name = "booksDG";
            this.booksDG.Size = new System.Drawing.Size(368, 192);
            this.booksDG.TabIndex = 2;
            this.booksDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnTableCell_Click);
            // 
            // bookList
            // 
            this.bookList.AutoSize = true;
            this.bookList.Location = new System.Drawing.Point(11, 210);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(51, 13);
            this.bookList.TabIndex = 3;
            this.bookList.Text = "Book List";
            // 
            // overDue
            // 
            this.overDue.AutoSize = true;
            this.overDue.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.overDue.Location = new System.Drawing.Point(486, 106);
            this.overDue.Name = "overDue";
            this.overDue.Size = new System.Drawing.Size(97, 14);
            this.overDue.TabIndex = 6;
            this.overDue.Text = "Over Due                    :";
            // 
            // borrowed
            // 
            this.borrowed.AutoSize = true;
            this.borrowed.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.borrowed.Location = new System.Drawing.Point(486, 136);
            this.borrowed.Name = "borrowed";
            this.borrowed.Size = new System.Drawing.Size(99, 14);
            this.borrowed.TabIndex = 7;
            this.borrowed.Text = "Borrowed                    :";
            // 
            // bookSearchTB
            // 
            this.bookSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSearchTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookSearchTB.Location = new System.Drawing.Point(14, 175);
            this.bookSearchTB.Name = "bookSearchTB";
            this.bookSearchTB.Size = new System.Drawing.Size(368, 22);
            this.bookSearchTB.TabIndex = 8;
            this.bookSearchTB.Text = "Search Book Here";
            this.bookSearchTB.TextChanged += new System.EventHandler(this.BookSearchTextChanged);
            this.bookSearchTB.Enter += new System.EventHandler(this.bookSearchTBEnter);
            this.bookSearchTB.Leave += new System.EventHandler(this.bookSearchTBLeave);
            // 
            // borrowListDG
            // 
            this.borrowListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowListDG.Location = new System.Drawing.Point(446, 245);
            this.borrowListDG.Name = "borrowListDG";
            this.borrowListDG.Size = new System.Drawing.Size(335, 128);
            this.borrowListDG.TabIndex = 10;
            // 
            // borrowList
            // 
            this.borrowList.AutoSize = true;
            this.borrowList.Location = new System.Drawing.Point(446, 229);
            this.borrowList.Name = "borrowList";
            this.borrowList.Size = new System.Drawing.Size(59, 13);
            this.borrowList.TabIndex = 11;
            this.borrowList.Text = "Borrow List";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.b.Location = new System.Drawing.Point(486, 178);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(86, 14);
            this.b.TabIndex = 12;
            this.b.Text = "Borrow Date       :";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.d.Location = new System.Drawing.Point(486, 201);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(85, 14);
            this.d.TabIndex = 13;
            this.d.Text = "Due Date              :";
            // 
            // borrowbtn
            // 
            this.borrowbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.borrowbtn.ForeColor = System.Drawing.Color.White;
            this.borrowbtn.Location = new System.Drawing.Point(446, 379);
            this.borrowbtn.Name = "borrowbtn";
            this.borrowbtn.Size = new System.Drawing.Size(335, 36);
            this.borrowbtn.TabIndex = 16;
            this.borrowbtn.Text = "Borrow";
            this.borrowbtn.UseVisualStyleBackColor = false;
            this.borrowbtn.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // addBookBTN
            // 
            this.addBookBTN.Location = new System.Drawing.Point(395, 293);
            this.addBookBTN.Name = "addBookBTN";
            this.addBookBTN.Size = new System.Drawing.Size(38, 52);
            this.addBookBTN.TabIndex = 19;
            this.addBookBTN.Text = ">";
            this.addBookBTN.UseVisualStyleBackColor = true;
            this.addBookBTN.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // studentSearchBTN
            // 
            this.studentSearchBTN.Image = ((System.Drawing.Image)(resources.GetObject("studentSearchBTN.Image")));
            this.studentSearchBTN.Location = new System.Drawing.Point(761, -1);
            this.studentSearchBTN.Name = "studentSearchBTN";
            this.studentSearchBTN.Size = new System.Drawing.Size(25, 21);
            this.studentSearchBTN.TabIndex = 22;
            this.studentSearchBTN.UseVisualStyleBackColor = true;
            this.studentSearchBTN.Click += new System.EventHandler(this.StudentSearch_Click);
            // 
            // studentSearchTB
            // 
            this.studentSearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.studentSearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.studentSearchTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentSearchTB.Location = new System.Drawing.Point(499, 0);
            this.studentSearchTB.Name = "studentSearchTB";
            this.studentSearchTB.Size = new System.Drawing.Size(263, 20);
            this.studentSearchTB.TabIndex = 21;
            this.studentSearchTB.Text = "Search Student ID";
            this.studentSearchTB.TextChanged += new System.EventHandler(this.studentSearch_TextChanged);
            this.studentSearchTB.Enter += new System.EventHandler(this.studentSearchTBEnter);
            this.studentSearchTB.Leave += new System.EventHandler(this.studentSearchTBLeave);
            // 
            // student_Name
            // 
            this.student_Name.AutoSize = true;
            this.student_Name.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.student_Name.Location = new System.Drawing.Point(108, 106);
            this.student_Name.Name = "student_Name";
            this.student_Name.Size = new System.Drawing.Size(0, 14);
            this.student_Name.TabIndex = 23;
            // 
            // student_Department
            // 
            this.student_Department.AutoSize = true;
            this.student_Department.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.student_Department.Location = new System.Drawing.Point(110, 130);
            this.student_Department.Name = "student_Department";
            this.student_Department.Size = new System.Drawing.Size(0, 14);
            this.student_Department.TabIndex = 24;
            // 
            // student_Due
            // 
            this.student_Due.AutoSize = true;
            this.student_Due.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.student_Due.Location = new System.Drawing.Point(589, 106);
            this.student_Due.Name = "student_Due";
            this.student_Due.Size = new System.Drawing.Size(0, 14);
            this.student_Due.TabIndex = 25;
            // 
            // student_Borrowed
            // 
            this.student_Borrowed.AutoSize = true;
            this.student_Borrowed.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.student_Borrowed.Location = new System.Drawing.Point(591, 136);
            this.student_Borrowed.Name = "student_Borrowed";
            this.student_Borrowed.Size = new System.Drawing.Size(0, 14);
            this.student_Borrowed.TabIndex = 26;
            // 
            // TotalCopiesLB
            // 
            this.TotalCopiesLB.AutoSize = true;
            this.TotalCopiesLB.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalCopiesLB.Location = new System.Drawing.Point(758, 226);
            this.TotalCopiesLB.Name = "TotalCopiesLB";
            this.TotalCopiesLB.Size = new System.Drawing.Size(13, 14);
            this.TotalCopiesLB.TabIndex = 28;
            this.TotalCopiesLB.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(681, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total Copies:";
            // 
            // borrowedDate
            // 
            this.borrowedDate.CustomFormat = "dd-MM-yyyy";
            this.borrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.borrowedDate.Location = new System.Drawing.Point(578, 175);
            this.borrowedDate.Name = "borrowedDate";
            this.borrowedDate.Size = new System.Drawing.Size(103, 20);
            this.borrowedDate.TabIndex = 29;
            // 
            // dueDate
            // 
            this.dueDate.CustomFormat = "dd-MM-yyyy";
            this.dueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDate.Location = new System.Drawing.Point(578, 201);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(103, 20);
            this.dueDate.TabIndex = 30;
            // 
            // borrowcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.borrowedDate);
            this.Controls.Add(this.TotalCopiesLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student_Borrowed);
            this.Controls.Add(this.student_Due);
            this.Controls.Add(this.student_Department);
            this.Controls.Add(this.student_Name);
            this.Controls.Add(this.studentSearchBTN);
            this.Controls.Add(this.studentSearchTB);
            this.Controls.Add(this.addBookBTN);
            this.Controls.Add(this.borrowbtn);
            this.Controls.Add(this.d);
            this.Controls.Add(this.b);
            this.Controls.Add(this.borrowList);
            this.Controls.Add(this.borrowListDG);
            this.Controls.Add(this.bookSearchTB);
            this.Controls.Add(this.borrowed);
            this.Controls.Add(this.overDue);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.booksDG);
            this.Controls.Add(this.department);
            this.Controls.Add(this.name);
            this.Name = "borrowcontrol";
            this.Size = new System.Drawing.Size(787, 418);
            ((System.ComponentModel.ISupportInitialize)(this.booksDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowListDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.DataGridView booksDG;
        private System.Windows.Forms.Label bookList;
        private System.Windows.Forms.Label overDue;
        private System.Windows.Forms.Label borrowed;
        private System.Windows.Forms.TextBox bookSearchTB;
        private System.Windows.Forms.DataGridView borrowListDG;
        private System.Windows.Forms.Label borrowList;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Button borrowbtn;
        private System.Windows.Forms.Button addBookBTN;
        private System.Windows.Forms.Button studentSearchBTN;
        private System.Windows.Forms.TextBox studentSearchTB;
        private System.Windows.Forms.Label student_Name;
        private System.Windows.Forms.Label student_Department;
        private System.Windows.Forms.Label student_Due;
        private System.Windows.Forms.Label student_Borrowed;
        private System.Windows.Forms.Label TotalCopiesLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker borrowedDate;
        private System.Windows.Forms.DateTimePicker dueDate;
    }
}
