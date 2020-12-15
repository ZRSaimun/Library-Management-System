namespace App
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.label1 = new System.Windows.Forms.Label();
            this.RecordsTableDG = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.searchRecordsTB = new System.Windows.Forms.TextBox();
            this.viewDetailsBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTableDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count  :";
            // 
            // RecordsTableDG
            // 
            this.RecordsTableDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsTableDG.Location = new System.Drawing.Point(0, 50);
            this.RecordsTableDG.Name = "RecordsTableDG";
            this.RecordsTableDG.Size = new System.Drawing.Size(742, 330);
            this.RecordsTableDG.TabIndex = 1;
            this.RecordsTableDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Count";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(720, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 21);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // searchRecordsTB
            // 
            this.searchRecordsTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchRecordsTB.Location = new System.Drawing.Point(458, 0);
            this.searchRecordsTB.Name = "searchRecordsTB";
            this.searchRecordsTB.Size = new System.Drawing.Size(263, 20);
            this.searchRecordsTB.TabIndex = 23;
            this.searchRecordsTB.Text = "Search Here";
            this.searchRecordsTB.TextChanged += new System.EventHandler(this.searchRecordsTBTextChanged);
            this.searchRecordsTB.Enter += new System.EventHandler(this.searchRecordsTBEnter);
            this.searchRecordsTB.Leave += new System.EventHandler(this.searchRecordsTBLeave);
            // 
            // viewDetailsBTN
            // 
            this.viewDetailsBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.viewDetailsBTN.ForeColor = System.Drawing.Color.White;
            this.viewDetailsBTN.Location = new System.Drawing.Point(584, 386);
            this.viewDetailsBTN.Name = "viewDetailsBTN";
            this.viewDetailsBTN.Size = new System.Drawing.Size(158, 40);
            this.viewDetailsBTN.TabIndex = 37;
            this.viewDetailsBTN.Text = "View Details";
            this.viewDetailsBTN.UseVisualStyleBackColor = false;
            this.viewDetailsBTN.Visible = false;
            this.viewDetailsBTN.Click += new System.EventHandler(this.viewDetailsBTN_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewDetailsBTN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchRecordsTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecordsTableDG);
            this.Controls.Add(this.label1);
            this.Name = "Records";
            this.Size = new System.Drawing.Size(790, 434);
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTableDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RecordsTableDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchRecordsTB;
        private System.Windows.Forms.Button viewDetailsBTN;
    }
}
