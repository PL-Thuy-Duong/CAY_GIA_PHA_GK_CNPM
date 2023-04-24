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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pcView = new System.Windows.Forms.PictureBox();
            this.pcEdit = new System.Windows.Forms.PictureBox();
            this.pcDelete = new System.Windows.Forms.PictureBox();
            this.pcAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // datathongtin
            // 
            this.datathongtin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datathongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.datathongtin.Location = new System.Drawing.Point(0, 0);
            this.datathongtin.Name = "datathongtin";
            this.datathongtin.Size = new System.Drawing.Size(694, 309);
            this.datathongtin.TabIndex = 0;
            this.datathongtin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datathongtin_CellContentClick);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(296, 323);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(219, 28);
            this.guna2TextBox1.TabIndex = 11;
            // 
            // pcView
            // 
            this.pcView.Image = ((System.Drawing.Image)(resources.GetObject("pcView.Image")));
            this.pcView.Location = new System.Drawing.Point(531, 315);
            this.pcView.Name = "pcView";
            this.pcView.Size = new System.Drawing.Size(50, 41);
            this.pcView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcView.TabIndex = 10;
            this.pcView.TabStop = false;
            // 
            // pcEdit
            // 
            this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
            this.pcEdit.Location = new System.Drawing.Point(153, 315);
            this.pcEdit.Name = "pcEdit";
            this.pcEdit.Size = new System.Drawing.Size(50, 41);
            this.pcEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEdit.TabIndex = 9;
            this.pcEdit.TabStop = false;
            // 
            // pcDelete
            // 
            this.pcDelete.Image = ((System.Drawing.Image)(resources.GetObject("pcDelete.Image")));
            this.pcDelete.Location = new System.Drawing.Point(224, 315);
            this.pcDelete.Name = "pcDelete";
            this.pcDelete.Size = new System.Drawing.Size(50, 41);
            this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcDelete.TabIndex = 8;
            this.pcDelete.TabStop = false;
            // 
            // pcAdd
            // 
            this.pcAdd.Image = ((System.Drawing.Image)(resources.GetObject("pcAdd.Image")));
            this.pcAdd.Location = new System.Drawing.Point(81, 315);
            this.pcAdd.Name = "pcAdd";
            this.pcAdd.Size = new System.Drawing.Size(50, 41);
            this.pcAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAdd.TabIndex = 7;
            this.pcAdd.TabStop = false;
            // 
            // Ho_so_gia_pha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(694, 356);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.pcView);
            this.Controls.Add(this.pcEdit);
            this.Controls.Add(this.pcDelete);
            this.Controls.Add(this.pcAdd);
            this.Controls.Add(this.datathongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ho_so_gia_pha";
            this.Text = "Ho_so_gia_pha";
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datathongtin;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.PictureBox pcView;
        private System.Windows.Forms.PictureBox pcEdit;
        private System.Windows.Forms.PictureBox pcDelete;
        private System.Windows.Forms.PictureBox pcAdd;
    }
}