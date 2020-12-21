namespace SP_Lab7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.genreTb = new System.Windows.Forms.TextBox();
            this.albumTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.authorTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // saveBt
            // 
            this.saveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.saveBt.Location = new System.Drawing.Point(12, 282);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(112, 27);
            this.saveBt.TabIndex = 1;
            this.saveBt.Text = "Save All";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // addBt
            // 
            this.addBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addBt.Location = new System.Drawing.Point(710, 282);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(78, 60);
            this.addBt.TabIndex = 2;
            this.addBt.Text = "Add Music";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // genreTb
            // 
            this.genreTb.Location = new System.Drawing.Point(593, 284);
            this.genreTb.Name = "genreTb";
            this.genreTb.Size = new System.Drawing.Size(100, 22);
            this.genreTb.TabIndex = 3;
            // 
            // albumTb
            // 
            this.albumTb.Location = new System.Drawing.Point(593, 317);
            this.albumTb.Name = "albumTb";
            this.albumTb.Size = new System.Drawing.Size(100, 22);
            this.albumTb.TabIndex = 4;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(399, 283);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 22);
            this.nameTb.TabIndex = 5;
            // 
            // authorTb
            // 
            this.authorTb.Location = new System.Drawing.Point(399, 316);
            this.authorTb.Name = "authorTb";
            this.authorTb.Size = new System.Drawing.Size(100, 22);
            this.authorTb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(324, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(324, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(518, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Genre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(518, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Album:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteBt
            // 
            this.deleteBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.deleteBt.Location = new System.Drawing.Point(12, 315);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(112, 27);
            this.deleteBt.TabIndex = 11;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.albumTb);
            this.Controls.Add(this.genreTb);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.TextBox albumTb;
        private System.Windows.Forms.TextBox authorTb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.TextBox genreTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button saveBt;

        #endregion
    }
}