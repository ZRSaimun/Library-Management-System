namespace App
{
    partial class Librarian_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian_Control));
            this.searchLibrarianBTN = new System.Windows.Forms.Button();
            this.searchLibrarianTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.librarianDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.register_Btn = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.librarianDG)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLibrarianBTN
            // 
            this.searchLibrarianBTN.Image = ((System.Drawing.Image)(resources.GetObject("searchLibrarianBTN.Image")));
            this.searchLibrarianBTN.Location = new System.Drawing.Point(743, 13);
            this.searchLibrarianBTN.Name = "searchLibrarianBTN";
            this.searchLibrarianBTN.Size = new System.Drawing.Size(25, 21);
            this.searchLibrarianBTN.TabIndex = 29;
            this.searchLibrarianBTN.UseVisualStyleBackColor = true;
            // 
            // searchLibrarianTB
            // 
            this.searchLibrarianTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchLibrarianTB.Location = new System.Drawing.Point(481, 14);
            this.searchLibrarianTB.Name = "searchLibrarianTB";
            this.searchLibrarianTB.Size = new System.Drawing.Size(263, 20);
            this.searchLibrarianTB.TabIndex = 28;
            this.searchLibrarianTB.Text = "Search Librarian";
            this.searchLibrarianTB.TextChanged += new System.EventHandler(this.searchLibrarianTBTextChanged);
            this.searchLibrarianTB.Enter += new System.EventHandler(this.searchLibrarianTBEnter);
            this.searchLibrarianTB.Leave += new System.EventHandler(this.searchLibrarianTBLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Count";
            // 
            // librarianDG
            // 
            this.librarianDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librarianDG.Location = new System.Drawing.Point(23, 67);
            this.librarianDG.Name = "librarianDG";
            this.librarianDG.Size = new System.Drawing.Size(742, 322);
            this.librarianDG.TabIndex = 26;
            this.librarianDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Count  :";
            // 
            // register_Btn
            // 
            this.register_Btn.BackColor = System.Drawing.Color.DarkCyan;
            this.register_Btn.ForeColor = System.Drawing.Color.White;
            this.register_Btn.Location = new System.Drawing.Point(560, 395);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.Size = new System.Drawing.Size(205, 40);
            this.register_Btn.TabIndex = 30;
            this.register_Btn.Text = "Register";
            this.register_Btn.UseVisualStyleBackColor = false;
            this.register_Btn.Click += new System.EventHandler(this.admin_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.deleteBTN.ForeColor = System.Drawing.Color.White;
            this.deleteBTN.Location = new System.Drawing.Point(404, 395);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(167, 40);
            this.deleteBTN.TabIndex = 31;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Visible = false;
            this.deleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.updateBTN.ForeColor = System.Drawing.Color.White;
            this.updateBTN.Location = new System.Drawing.Point(577, 395);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(167, 40);
            this.updateBTN.TabIndex = 32;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Visible = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.cancelBTN.ForeColor = System.Drawing.Color.White;
            this.cancelBTN.Location = new System.Drawing.Point(222, 395);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(167, 40);
            this.cancelBTN.TabIndex = 33;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Visible = false;
            // 
            // Librarian_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.register_Btn);
            this.Controls.Add(this.searchLibrarianBTN);
            this.Controls.Add(this.searchLibrarianTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.librarianDG);
            this.Controls.Add(this.label1);
            this.Name = "Librarian_Control";
            this.Size = new System.Drawing.Size(775, 438);
            ((System.ComponentModel.ISupportInitialize)(this.librarianDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchLibrarianBTN;
        private System.Windows.Forms.TextBox searchLibrarianTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView librarianDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_Btn;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button cancelBTN;
    }
}
