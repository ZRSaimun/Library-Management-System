namespace App
{
    partial class Change_Password
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
            this.Change_ch_btn = new System.Windows.Forms.Button();
            this.Change_ca_btn = new System.Windows.Forms.Button();
            this.Change_p_box = new System.Windows.Forms.TextBox();
            this.Change_op_box = new System.Windows.Forms.TextBox();
            this.Change_un_box = new System.Windows.Forms.TextBox();
            this.Change_p_label = new System.Windows.Forms.Label();
            this.Change_op_label = new System.Windows.Forms.Label();
            this.Change_un_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Change_ch_btn
            // 
            this.Change_ch_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Change_ch_btn.ForeColor = System.Drawing.Color.White;
            this.Change_ch_btn.Location = new System.Drawing.Point(473, 248);
            this.Change_ch_btn.Name = "Change_ch_btn";
            this.Change_ch_btn.Size = new System.Drawing.Size(100, 38);
            this.Change_ch_btn.TabIndex = 15;
            this.Change_ch_btn.Text = "Change";
            this.Change_ch_btn.UseVisualStyleBackColor = false;
            // 
            // Change_ca_btn
            // 
            this.Change_ca_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.Change_ca_btn.ForeColor = System.Drawing.Color.White;
            this.Change_ca_btn.Location = new System.Drawing.Point(331, 248);
            this.Change_ca_btn.Name = "Change_ca_btn";
            this.Change_ca_btn.Size = new System.Drawing.Size(108, 38);
            this.Change_ca_btn.TabIndex = 14;
            this.Change_ca_btn.Text = "Cancel";
            this.Change_ca_btn.UseVisualStyleBackColor = false;
            // 
            // Change_p_box
            // 
            this.Change_p_box.Location = new System.Drawing.Point(302, 195);
            this.Change_p_box.Multiline = true;
            this.Change_p_box.Name = "Change_p_box";
            this.Change_p_box.Size = new System.Drawing.Size(299, 25);
            this.Change_p_box.TabIndex = 13;
            // 
            // Change_op_box
            // 
            this.Change_op_box.Location = new System.Drawing.Point(302, 153);
            this.Change_op_box.Multiline = true;
            this.Change_op_box.Name = "Change_op_box";
            this.Change_op_box.Size = new System.Drawing.Size(299, 25);
            this.Change_op_box.TabIndex = 12;
            // 
            // Change_un_box
            // 
            this.Change_un_box.Location = new System.Drawing.Point(302, 110);
            this.Change_un_box.Multiline = true;
            this.Change_un_box.Name = "Change_un_box";
            this.Change_un_box.Size = new System.Drawing.Size(299, 25);
            this.Change_un_box.TabIndex = 11;
            // 
            // Change_p_label
            // 
            this.Change_p_label.AutoSize = true;
            this.Change_p_label.Location = new System.Drawing.Point(197, 195);
            this.Change_p_label.Name = "Change_p_label";
            this.Change_p_label.Size = new System.Drawing.Size(83, 13);
            this.Change_p_label.TabIndex = 10;
            this.Change_p_label.Text = "Password         :";
            // 
            // Change_op_label
            // 
            this.Change_op_label.AutoSize = true;
            this.Change_op_label.Location = new System.Drawing.Point(197, 160);
            this.Change_op_label.Name = "Change_op_label";
            this.Change_op_label.Size = new System.Drawing.Size(81, 13);
            this.Change_op_label.TabIndex = 9;
            this.Change_op_label.Text = "Old Password  :";
            // 
            // Change_un_label
            // 
            this.Change_un_label.AutoSize = true;
            this.Change_un_label.Location = new System.Drawing.Point(197, 122);
            this.Change_un_label.Name = "Change_un_label";
            this.Change_un_label.Size = new System.Drawing.Size(78, 13);
            this.Change_un_label.TabIndex = 8;
            this.Change_un_label.Text = "User Name     :";
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.Change_ch_btn);
            this.Controls.Add(this.Change_ca_btn);
            this.Controls.Add(this.Change_p_box);
            this.Controls.Add(this.Change_op_box);
            this.Controls.Add(this.Change_un_box);
            this.Controls.Add(this.Change_p_label);
            this.Controls.Add(this.Change_op_label);
            this.Controls.Add(this.Change_un_label);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Change_ch_btn;
        private System.Windows.Forms.Button Change_ca_btn;
        private System.Windows.Forms.TextBox Change_p_box;
        private System.Windows.Forms.TextBox Change_op_box;
        private System.Windows.Forms.TextBox Change_un_box;
        private System.Windows.Forms.Label Change_p_label;
        private System.Windows.Forms.Label Change_op_label;
        private System.Windows.Forms.Label Change_un_label;
    }
}