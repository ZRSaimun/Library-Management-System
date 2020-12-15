namespace App
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.adminDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.register_Btn = new System.Windows.Forms.Button();
            this.changePass_Btn = new System.Windows.Forms.Button();
            this.adminSearch = new System.Windows.Forms.TextBox();
            this.adminSearchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Count  :";
            // 
            // adminDGV
            // 
            this.adminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDGV.Location = new System.Drawing.Point(28, 68);
            this.adminDGV.Name = "adminDGV";
            this.adminDGV.Size = new System.Drawing.Size(742, 322);
            this.adminDGV.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Count";
            // 
            // register_Btn
            // 
            this.register_Btn.BackColor = System.Drawing.Color.DarkCyan;
            this.register_Btn.ForeColor = System.Drawing.Color.White;
            this.register_Btn.Location = new System.Drawing.Point(565, 396);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.Size = new System.Drawing.Size(205, 40);
            this.register_Btn.TabIndex = 37;
            this.register_Btn.Text = "Register";
            this.register_Btn.UseVisualStyleBackColor = false;
            this.register_Btn.Click += new System.EventHandler(this.register_Btn_Click);
            // 
            // changePass_Btn
            // 
            this.changePass_Btn.BackColor = System.Drawing.Color.DarkCyan;
            this.changePass_Btn.ForeColor = System.Drawing.Color.White;
            this.changePass_Btn.Location = new System.Drawing.Point(392, 396);
            this.changePass_Btn.Name = "changePass_Btn";
            this.changePass_Btn.Size = new System.Drawing.Size(167, 40);
            this.changePass_Btn.TabIndex = 38;
            this.changePass_Btn.Text = "Change Password";
            this.changePass_Btn.UseVisualStyleBackColor = false;
            this.changePass_Btn.Visible = false;
            // 
            // adminSearch
            // 
            this.adminSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.adminSearch.Location = new System.Drawing.Point(486, 15);
            this.adminSearch.Name = "adminSearch";
            this.adminSearch.Size = new System.Drawing.Size(263, 20);
            this.adminSearch.TabIndex = 35;
            this.adminSearch.Text = "Search Admin";
            this.adminSearch.TextChanged += new System.EventHandler(this.adminSearchTextChanged);
            this.adminSearch.Enter += new System.EventHandler(this.adminSearchEnter);
            this.adminSearch.Leave += new System.EventHandler(this.adminSearchLeave);
            // 
            // adminSearchBTN
            // 
            this.adminSearchBTN.Image = ((System.Drawing.Image)(resources.GetObject("adminSearchBTN.Image")));
            this.adminSearchBTN.Location = new System.Drawing.Point(748, 14);
            this.adminSearchBTN.Name = "adminSearchBTN";
            this.adminSearchBTN.Size = new System.Drawing.Size(25, 21);
            this.adminSearchBTN.TabIndex = 36;
            this.adminSearchBTN.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changePass_Btn);
            this.Controls.Add(this.register_Btn);
            this.Controls.Add(this.adminSearchBTN);
            this.Controls.Add(this.adminSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminDGV);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView adminDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_Btn;
        private System.Windows.Forms.Button changePass_Btn;
        private System.Windows.Forms.TextBox adminSearch;
        private System.Windows.Forms.Button adminSearchBTN;


    }
}
