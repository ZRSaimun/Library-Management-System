namespace App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Forgot_btn = new System.Windows.Forms.LinkLabel();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Forgot_btn
            // 
            this.Forgot_btn.AutoSize = true;
            this.Forgot_btn.Location = new System.Drawing.Point(301, 283);
            this.Forgot_btn.Name = "Forgot_btn";
            this.Forgot_btn.Size = new System.Drawing.Size(103, 13);
            this.Forgot_btn.TabIndex = 14;
            this.Forgot_btn.TabStop = true;
            this.Forgot_btn.Text = "Forgotten account? ";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(254, 178);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(170, 22);
            this.PasswordBox.TabIndex = 13;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox.Location = new System.Drawing.Point(254, 124);
            this.UserNameBox.Multiline = true;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(170, 23);
            this.UserNameBox.TabIndex = 12;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(173, 186);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(61, 15);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(166, 132);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(70, 15);
            this.UserName.TabIndex = 10;
            this.UserName.Text = "User Name";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_btn.Location = new System.Drawing.Point(304, 240);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(98, 40);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Button_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_btn.Location = new System.Drawing.Point(201, 240);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(98, 40);
            this.Login_btn.TabIndex = 8;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Button_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "username.png");
            this.imageList1.Images.SetKeyName(1, "username.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(181)))), ((int)(((byte)(194)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 11);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(0, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 10);
            this.panel2.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(623, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Forgot_btn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Login_btn);
            this.Name = "Form1";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Forgot_btn;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

