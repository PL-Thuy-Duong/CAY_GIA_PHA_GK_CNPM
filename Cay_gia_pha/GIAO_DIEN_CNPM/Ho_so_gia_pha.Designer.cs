namespace GIAO_DIEN_CNPM
{
    partial class Ho_so_gia_pha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ho_so_gia_pha));
            this.datathongtin = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.pcTimKiem = new System.Windows.Forms.PictureBox();
            this.pcEdit = new System.Windows.Forms.PictureBox();
            this.pcAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // datathongtin
            // 
            this.datathongtin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datathongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.datathongtin.Location = new System.Drawing.Point(0, 0);
            this.datathongtin.Name = "datathongtin";
            this.datathongtin.Size = new System.Drawing.Size(799, 326);
            this.datathongtin.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(133, 340);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm tại đây";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(231, 28);
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_keypress);
            // 
            // pcTimKiem
            // 
            this.pcTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("pcTimKiem.Image")));
            this.pcTimKiem.Location = new System.Drawing.Point(381, 332);
            this.pcTimKiem.Name = "pcTimKiem";
            this.pcTimKiem.Size = new System.Drawing.Size(40, 36);
            this.pcTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTimKiem.TabIndex = 10;
            this.pcTimKiem.TabStop = false;
            this.pcTimKiem.Click += new System.EventHandler(this.pcTimKiem_Click);
            // 
            // pcEdit
            // 
            this.pcEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
            this.pcEdit.Location = new System.Drawing.Point(453, 332);
            this.pcEdit.Name = "pcEdit";
            this.pcEdit.Size = new System.Drawing.Size(40, 36);
            this.pcEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEdit.TabIndex = 9;
            this.pcEdit.TabStop = false;
            this.pcEdit.Click += new System.EventHandler(this.pcEdit_Click_1);
            // 
            // pcAdd
            // 
            this.pcAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcAdd.Image = ((System.Drawing.Image)(resources.GetObject("pcAdd.Image")));
            this.pcAdd.Location = new System.Drawing.Point(682, 332);
            this.pcAdd.Name = "pcAdd";
            this.pcAdd.Size = new System.Drawing.Size(40, 36);
            this.pcAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAdd.TabIndex = 7;
            this.pcAdd.TabStop = false;
            this.pcAdd.Click += new System.EventHandler(this.pcAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thêm TV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chỉnh sửa";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Xem DS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::GIAO_DIEN_CNPM.Properties.Resources.achieve;
            this.pictureBox1.Location = new System.Drawing.Point(535, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::GIAO_DIEN_CNPM.Properties.Resources.die_gr;
            this.pictureBox3.Location = new System.Drawing.Point(609, 332);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Thành tích";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Người mất";
            // 
            // Ho_so_gia_pha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(799, 399);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.pcTimKiem);
            this.Controls.Add(this.pcEdit);
            this.Controls.Add(this.pcAdd);
            this.Controls.Add(this.datathongtin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ho_so_gia_pha";
            this.Text = "Ho_so_gia_pha";
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datathongtin;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pcTimKiem;
        private System.Windows.Forms.PictureBox pcEdit;
        private System.Windows.Forms.PictureBox pcAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}