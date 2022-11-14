namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.downright = new System.Windows.Forms.Button();
            this.downmid = new System.Windows.Forms.Button();
            this.downleft = new System.Windows.Forms.Button();
            this.midright = new System.Windows.Forms.Button();
            this.midmid = new System.Windows.Forms.Button();
            this.midleft = new System.Windows.Forms.Button();
            this.topright = new System.Windows.Forms.Button();
            this.topmid = new System.Windows.Forms.Button();
            this.topleft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.downright, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.downmid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.downleft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.midright, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.midmid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.midleft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.topright, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.topmid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.topleft, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(293, 154);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // downright
            // 
            this.downright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downright.Location = new System.Drawing.Point(147, 107);
            this.downright.Name = "downright";
            this.downright.Size = new System.Drawing.Size(67, 48);
            this.downright.TabIndex = 8;
            this.downright.UseVisualStyleBackColor = true;
            this.downright.Click += new System.EventHandler(this.Mark);
            // 
            // downmid
            // 
            this.downmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downmid.Location = new System.Drawing.Point(75, 107);
            this.downmid.Name = "downmid";
            this.downmid.Size = new System.Drawing.Size(66, 48);
            this.downmid.TabIndex = 7;
            this.downmid.UseVisualStyleBackColor = true;
            this.downmid.Click += new System.EventHandler(this.Mark);
            // 
            // downleft
            // 
            this.downleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downleft.Location = new System.Drawing.Point(3, 107);
            this.downleft.Name = "downleft";
            this.downleft.Size = new System.Drawing.Size(66, 48);
            this.downleft.TabIndex = 6;
            this.downleft.UseVisualStyleBackColor = true;
            this.downleft.Click += new System.EventHandler(this.Mark);
            // 
            // midright
            // 
            this.midright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midright.Location = new System.Drawing.Point(147, 55);
            this.midright.Name = "midright";
            this.midright.Size = new System.Drawing.Size(67, 46);
            this.midright.TabIndex = 5;
            this.midright.UseVisualStyleBackColor = true;
            this.midright.Click += new System.EventHandler(this.Mark);
            // 
            // midmid
            // 
            this.midmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midmid.Location = new System.Drawing.Point(75, 55);
            this.midmid.Name = "midmid";
            this.midmid.Size = new System.Drawing.Size(66, 46);
            this.midmid.TabIndex = 4;
            this.midmid.UseVisualStyleBackColor = true;
            this.midmid.Click += new System.EventHandler(this.Mark);
            // 
            // midleft
            // 
            this.midleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midleft.Location = new System.Drawing.Point(3, 55);
            this.midleft.Name = "midleft";
            this.midleft.Size = new System.Drawing.Size(66, 46);
            this.midleft.TabIndex = 3;
            this.midleft.UseVisualStyleBackColor = true;
            this.midleft.Click += new System.EventHandler(this.Mark);
            // 
            // topright
            // 
            this.topright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topright.Location = new System.Drawing.Point(147, 3);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(67, 46);
            this.topright.TabIndex = 2;
            this.topright.UseVisualStyleBackColor = true;
            this.topright.Click += new System.EventHandler(this.Mark);
            // 
            // topmid
            // 
            this.topmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topmid.Location = new System.Drawing.Point(75, 3);
            this.topmid.Name = "topmid";
            this.topmid.Size = new System.Drawing.Size(66, 46);
            this.topmid.TabIndex = 1;
            this.topmid.UseVisualStyleBackColor = true;
            this.topmid.Click += new System.EventHandler(this.Mark);
            // 
            // topleft
            // 
            this.topleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topleft.Location = new System.Drawing.Point(3, 3);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(66, 46);
            this.topleft.TabIndex = 0;
            this.topleft.UseVisualStyleBackColor = true;
            this.topleft.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny ruch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button downright;
        private Button downmid;
        private Button downleft;
        private Button midright;
        private Button midmid;
        private Button midleft;
        private Button topright;
        private Button topmid;
        private Button topleft;
        private Label label1;
        private Label label2;
    }
}