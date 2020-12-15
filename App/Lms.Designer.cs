namespace App
{
    partial class Lms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lms));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelsidemenu = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.librarian_Btn = new System.Windows.Forms.Button();
            this.panelAdminSubMenu = new System.Windows.Forms.Panel();
            this.adminListBTN = new System.Windows.Forms.Button();
            this.admin_Panel_BTN = new System.Windows.Forms.Button();
            this.book_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.borrow_Btn = new System.Windows.Forms.Button();
            this.student_Btn = new System.Windows.Forms.Button();
            this.records_Btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.welcomeLB = new System.Windows.Forms.Label();
            this.adminPanel1 = new App.AdminPanel();
            this.book_Control1 = new App.Book_Control();
            this.studentControl1 = new App.StudentControl();
            this.Librarian_Control1 = new App.Librarian_Control();
            this.records1 = new App.Records();
            this.borrowcontrol1 = new App.borrowcontrol();
            this.panelsidemenu.SuspendLayout();
            this.panelAdminSubMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(208, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 15);
            this.panel2.TabIndex = 8;
            // 
            // panelsidemenu
            // 
            this.panelsidemenu.AutoScroll = true;
            this.panelsidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelsidemenu.Controls.Add(this.sidepanel);
            this.panelsidemenu.Controls.Add(this.librarian_Btn);
            this.panelsidemenu.Controls.Add(this.panelAdminSubMenu);
            this.panelsidemenu.Controls.Add(this.admin_Panel_BTN);
            this.panelsidemenu.Controls.Add(this.book_Btn);
            this.panelsidemenu.Controls.Add(this.label3);
            this.panelsidemenu.Controls.Add(this.panelLogo);
            this.panelsidemenu.Controls.Add(this.borrow_Btn);
            this.panelsidemenu.Controls.Add(this.student_Btn);
            this.panelsidemenu.Controls.Add(this.records_Btn);
            this.panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelsidemenu.Name = "panelsidemenu";
            this.panelsidemenu.Size = new System.Drawing.Size(208, 609);
            this.panelsidemenu.TabIndex = 7;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sidepanel.Location = new System.Drawing.Point(3, 115);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(8, 45);
            this.sidepanel.TabIndex = 6;
            // 
            // librarian_Btn
            // 
            this.librarian_Btn.FlatAppearance.BorderSize = 0;
            this.librarian_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.librarian_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarian_Btn.ForeColor = System.Drawing.Color.White;
            this.librarian_Btn.Image = ((System.Drawing.Image)(resources.GetObject("librarian_Btn.Image")));
            this.librarian_Btn.Location = new System.Drawing.Point(0, 110);
            this.librarian_Btn.Name = "librarian_Btn";
            this.librarian_Btn.Size = new System.Drawing.Size(208, 51);
            this.librarian_Btn.TabIndex = 25;
            this.librarian_Btn.Text = "   Librarian";
            this.librarian_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.librarian_Btn.UseVisualStyleBackColor = true;
            this.librarian_Btn.Click += new System.EventHandler(this.librarian_Btn_Click);
            // 
            // panelAdminSubMenu
            // 
            this.panelAdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelAdminSubMenu.Controls.Add(this.adminListBTN);
            this.panelAdminSubMenu.Location = new System.Drawing.Point(3, 425);
            this.panelAdminSubMenu.Name = "panelAdminSubMenu";
            this.panelAdminSubMenu.Size = new System.Drawing.Size(205, 41);
            this.panelAdminSubMenu.TabIndex = 19;
            // 
            // adminListBTN
            // 
            this.adminListBTN.FlatAppearance.BorderSize = 0;
            this.adminListBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminListBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminListBTN.ForeColor = System.Drawing.Color.LightGray;
            this.adminListBTN.Image = ((System.Drawing.Image)(resources.GetObject("adminListBTN.Image")));
            this.adminListBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminListBTN.Location = new System.Drawing.Point(-10, -2);
            this.adminListBTN.Name = "adminListBTN";
            this.adminListBTN.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.adminListBTN.Size = new System.Drawing.Size(209, 38);
            this.adminListBTN.TabIndex = 1;
            this.adminListBTN.Text = "Admin List";
            this.adminListBTN.UseVisualStyleBackColor = true;
            this.adminListBTN.Click += new System.EventHandler(this.adminListBTN_Click);
            // 
            // admin_Panel_BTN
            // 
            this.admin_Panel_BTN.FlatAppearance.BorderSize = 0;
            this.admin_Panel_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_Panel_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Panel_BTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.admin_Panel_BTN.Image = ((System.Drawing.Image)(resources.GetObject("admin_Panel_BTN.Image")));
            this.admin_Panel_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_Panel_BTN.Location = new System.Drawing.Point(9, 376);
            this.admin_Panel_BTN.Name = "admin_Panel_BTN";
            this.admin_Panel_BTN.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.admin_Panel_BTN.Size = new System.Drawing.Size(199, 43);
            this.admin_Panel_BTN.TabIndex = 18;
            this.admin_Panel_BTN.Text = "Admin Panel";
            this.admin_Panel_BTN.UseVisualStyleBackColor = true;
            this.admin_Panel_BTN.Click += new System.EventHandler(this.admin_Panel_BTN_Click);
            // 
            // book_Btn
            // 
            this.book_Btn.FlatAppearance.BorderSize = 0;
            this.book_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_Btn.ForeColor = System.Drawing.Color.White;
            this.book_Btn.Image = ((System.Drawing.Image)(resources.GetObject("book_Btn.Image")));
            this.book_Btn.Location = new System.Drawing.Point(0, 326);
            this.book_Btn.Name = "book_Btn";
            this.book_Btn.Size = new System.Drawing.Size(205, 44);
            this.book_Btn.TabIndex = 24;
            this.book_Btn.Text = "    Book";
            this.book_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_Btn.UseVisualStyleBackColor = true;
            this.book_Btn.Click += new System.EventHandler(this.book_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "(c) 2019 ZR";
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(208, 98);
            this.panelLogo.TabIndex = 17;
            // 
            // borrow_Btn
            // 
            this.borrow_Btn.FlatAppearance.BorderSize = 0;
            this.borrow_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_Btn.ForeColor = System.Drawing.Color.White;
            this.borrow_Btn.Image = ((System.Drawing.Image)(resources.GetObject("borrow_Btn.Image")));
            this.borrow_Btn.Location = new System.Drawing.Point(3, 270);
            this.borrow_Btn.Name = "borrow_Btn";
            this.borrow_Btn.Size = new System.Drawing.Size(191, 40);
            this.borrow_Btn.TabIndex = 23;
            this.borrow_Btn.Text = "    Borrow";
            this.borrow_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.borrow_Btn.UseVisualStyleBackColor = true;
            this.borrow_Btn.Click += new System.EventHandler(this.borrow_Btn_Click);
            // 
            // student_Btn
            // 
            this.student_Btn.FlatAppearance.BorderSize = 0;
            this.student_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Btn.ForeColor = System.Drawing.Color.White;
            this.student_Btn.Image = ((System.Drawing.Image)(resources.GetObject("student_Btn.Image")));
            this.student_Btn.Location = new System.Drawing.Point(0, 223);
            this.student_Btn.Name = "student_Btn";
            this.student_Btn.Size = new System.Drawing.Size(208, 31);
            this.student_Btn.TabIndex = 22;
            this.student_Btn.Text = "   Student";
            this.student_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.student_Btn.UseVisualStyleBackColor = true;
            this.student_Btn.Click += new System.EventHandler(this.student_Btn_Click);
            // 
            // records_Btn
            // 
            this.records_Btn.FlatAppearance.BorderSize = 0;
            this.records_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.records_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_Btn.ForeColor = System.Drawing.Color.White;
            this.records_Btn.Image = ((System.Drawing.Image)(resources.GetObject("records_Btn.Image")));
            this.records_Btn.Location = new System.Drawing.Point(3, 176);
            this.records_Btn.Name = "records_Btn";
            this.records_Btn.Size = new System.Drawing.Size(191, 41);
            this.records_Btn.TabIndex = 21;
            this.records_Btn.Text = "    Records";
            this.records_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.records_Btn.UseVisualStyleBackColor = true;
            this.records_Btn.Click += new System.EventHandler(this.records_Btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(228, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 114);
            this.panel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Library";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Setting";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // welcomeLB
            // 
            this.welcomeLB.AutoSize = true;
            this.welcomeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLB.Location = new System.Drawing.Point(519, 135);
            this.welcomeLB.Name = "welcomeLB";
            this.welcomeLB.Size = new System.Drawing.Size(259, 25);
            this.welcomeLB.TabIndex = 17;
            this.welcomeLB.Text = "WEL-COME TO LIBRARY";
            // 
            // adminPanel1
            // 
            this.adminPanel1.Location = new System.Drawing.Point(208, 121);
            this.adminPanel1.Name = "adminPanel1";
            this.adminPanel1.Size = new System.Drawing.Size(800, 450);
            this.adminPanel1.TabIndex = 16;
            // 
            // book_Control1
            // 
            this.book_Control1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.book_Control1.Location = new System.Drawing.Point(214, 121);
            this.book_Control1.Name = "book_Control1";
            this.book_Control1.Size = new System.Drawing.Size(775, 438);
            this.book_Control1.TabIndex = 15;
            // 
            // studentControl1
            // 
            this.studentControl1.BackColor = System.Drawing.SystemColors.Control;
            this.studentControl1.Location = new System.Drawing.Point(214, 121);
            this.studentControl1.Name = "studentControl1";
            this.studentControl1.Size = new System.Drawing.Size(775, 434);
            this.studentControl1.TabIndex = 14;
            // 
            // Librarian_Control1
            // 
            this.Librarian_Control1.Location = new System.Drawing.Point(214, 121);
            this.Librarian_Control1.Name = "Librarian_Control1";
            this.Librarian_Control1.Size = new System.Drawing.Size(775, 440);
            this.Librarian_Control1.TabIndex = 13;
            // 
            // records1
            // 
            this.records1.Location = new System.Drawing.Point(221, 121);
            this.records1.Name = "records1";
            this.records1.Size = new System.Drawing.Size(790, 427);
            this.records1.TabIndex = 12;
            // 
            // borrowcontrol1
            // 
            this.borrowcontrol1.Location = new System.Drawing.Point(208, 121);
            this.borrowcontrol1.Name = "borrowcontrol1";
            this.borrowcontrol1.Size = new System.Drawing.Size(790, 438);
            this.borrowcontrol1.TabIndex = 10;
            // 
            // Lms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.welcomeLB);
            this.Controls.Add(this.adminPanel1);
            this.Controls.Add(this.book_Control1);
            this.Controls.Add(this.studentControl1);
            this.Controls.Add(this.Librarian_Control1);
            this.Controls.Add(this.records1);
            this.Controls.Add(this.borrowcontrol1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelsidemenu);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.Name = "Lms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Move += new System.EventHandler(this.Moved);
            this.panelsidemenu.ResumeLayout(false);
            this.panelsidemenu.PerformLayout();
            this.panelAdminSubMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelsidemenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private borrowcontrol borrowcontrol1;
        private Records records1;
        private Librarian_Control Librarian_Control1;
        private StudentControl studentControl1;
        private Book_Control book_Control1;
        private AdminPanel adminPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelAdminSubMenu;
        private System.Windows.Forms.Button adminListBTN;
        private System.Windows.Forms.Button admin_Panel_BTN;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button librarian_Btn;
        private System.Windows.Forms.Button book_Btn;
        private System.Windows.Forms.Button borrow_Btn;
        private System.Windows.Forms.Button student_Btn;
        private System.Windows.Forms.Button records_Btn;
        private System.Windows.Forms.Label welcomeLB;
    }
}