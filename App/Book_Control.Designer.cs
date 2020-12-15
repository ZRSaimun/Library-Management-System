namespace App
{
    partial class Book_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Control));
            this.newbook_Btn = new System.Windows.Forms.Button();
            this.searchBookBTN = new System.Windows.Forms.Button();
            this.searchBookTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.removeBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.refreshBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookTable)).BeginInit();
            this.SuspendLayout();
            // 
            // newbook_Btn
            // 
            this.newbook_Btn.BackColor = System.Drawing.Color.DarkCyan;
            this.newbook_Btn.ForeColor = System.Drawing.Color.White;
            this.newbook_Btn.Location = new System.Drawing.Point(555, 390);
            this.newbook_Btn.Name = "newbook_Btn";
            this.newbook_Btn.Size = new System.Drawing.Size(205, 40);
            this.newbook_Btn.TabIndex = 37;
            this.newbook_Btn.Text = "New Book";
            this.newbook_Btn.UseVisualStyleBackColor = false;
            this.newbook_Btn.Click += new System.EventHandler(this.Button_Click);
            // 
            // searchBookBTN
            // 
            this.searchBookBTN.Image = ((System.Drawing.Image)(resources.GetObject("searchBookBTN.Image")));
            this.searchBookBTN.Location = new System.Drawing.Point(735, 8);
            this.searchBookBTN.Name = "searchBookBTN";
            this.searchBookBTN.Size = new System.Drawing.Size(25, 21);
            this.searchBookBTN.TabIndex = 36;
            this.searchBookBTN.UseVisualStyleBackColor = true;
            // 
            // searchBookTB
            // 
            this.searchBookTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchBookTB.Location = new System.Drawing.Point(473, 9);
            this.searchBookTB.Name = "searchBookTB";
            this.searchBookTB.Size = new System.Drawing.Size(263, 20);
            this.searchBookTB.TabIndex = 35;
            this.searchBookTB.Text = "Search Book";
            this.searchBookTB.TextChanged += new System.EventHandler(this.searchBookTBTextChanged);
            this.searchBookTB.Enter += new System.EventHandler(this.searchBookTbEnter);
            this.searchBookTB.Leave += new System.EventHandler(this.searchBookTBLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Count";
            // 
            // BookTable
            // 
            this.BookTable.AllowUserToAddRows = false;
            this.BookTable.AllowUserToDeleteRows = false;
            this.BookTable.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookTable.Location = new System.Drawing.Point(15, 62);
            this.BookTable.Name = "BookTable";
            this.BookTable.ReadOnly = true;
            this.BookTable.Size = new System.Drawing.Size(742, 322);
            this.BookTable.TabIndex = 33;
            this.BookTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnTableCell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Count  :";
            // 
            // removeBTN
            // 
            this.removeBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.removeBTN.ForeColor = System.Drawing.Color.White;
            this.removeBTN.Location = new System.Drawing.Point(435, 390);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(158, 40);
            this.removeBTN.TabIndex = 42;
            this.removeBTN.Text = "Remove";
            this.removeBTN.UseVisualStyleBackColor = false;
            this.removeBTN.Visible = false;
            this.removeBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.cancelBTN.ForeColor = System.Drawing.Color.White;
            this.cancelBTN.Location = new System.Drawing.Point(271, 390);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(158, 40);
            this.cancelBTN.TabIndex = 41;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Visible = false;
            this.cancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.updateBTN.ForeColor = System.Drawing.Color.White;
            this.updateBTN.Location = new System.Drawing.Point(599, 390);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(158, 40);
            this.updateBTN.TabIndex = 40;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Visible = false;
            this.updateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.refreshBTN.ForeColor = System.Drawing.Color.White;
            this.refreshBTN.Location = new System.Drawing.Point(344, 390);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(205, 40);
            this.refreshBTN.TabIndex = 43;
            this.refreshBTN.Text = "Refresh ";
            this.refreshBTN.UseVisualStyleBackColor = false;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // Book_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.newbook_Btn);
            this.Controls.Add(this.searchBookBTN);
            this.Controls.Add(this.searchBookTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookTable);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Book_Control";
            this.Size = new System.Drawing.Size(775, 438);
            ((System.ComponentModel.ISupportInitialize)(this.BookTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newbook_Btn;
        private System.Windows.Forms.Button searchBookBTN;
        private System.Windows.Forms.TextBox searchBookTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BookTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button refreshBTN;
    }
}
