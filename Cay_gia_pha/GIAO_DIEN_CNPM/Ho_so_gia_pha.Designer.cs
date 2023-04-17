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
            this.pcAdd = new System.Windows.Forms.PictureBox();
            this.pcDelete = new System.Windows.Forms.PictureBox();
            this.pcEdit = new System.Windows.Forms.PictureBox();
            this.pcView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcView)).BeginInit();
            this.SuspendLayout();
            // 
            // datathongtin
            // 
            this.datathongtin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datathongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datathongtin.Location = new System.Drawing.Point(106, 40);
            this.datathongtin.Name = "datathongtin";
            this.datathongtin.Size = new System.Drawing.Size(671, 374);
            this.datathongtin.TabIndex = 0;
            // 
            // pcAdd
            // 
            this.pcAdd.Image = ((System.Drawing.Image)(resources.GetObject("pcAdd.Image")));
            this.pcAdd.Location = new System.Drawing.Point(2, 161);
            this.pcAdd.Name = "pcAdd";
            this.pcAdd.Size = new System.Drawing.Size(77, 59);
            this.pcAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAdd.TabIndex = 1;
            this.pcAdd.TabStop = false;
            // 
            // pcDelete
            // 
            this.pcDelete.Image = ((System.Drawing.Image)(resources.GetObject("pcDelete.Image")));
            this.pcDelete.Location = new System.Drawing.Point(2, 291);
            this.pcDelete.Name = "pcDelete";
            this.pcDelete.Size = new System.Drawing.Size(77, 59);
            this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcDelete.TabIndex = 2;
            this.pcDelete.TabStop = false;
            // 
            // pcEdit
            // 
            this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
            this.pcEdit.Location = new System.Drawing.Point(2, 226);
            this.pcEdit.Name = "pcEdit";
            this.pcEdit.Size = new System.Drawing.Size(77, 59);
            this.pcEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEdit.TabIndex = 4;
            this.pcEdit.TabStop = false;
            // 
            // pcView
            // 
            this.pcView.Image = ((System.Drawing.Image)(resources.GetObject("pcView.Image")));
            this.pcView.Location = new System.Drawing.Point(2, 96);
            this.pcView.Name = "pcView";
            this.pcView.Size = new System.Drawing.Size(77, 59);
            this.pcView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcView.TabIndex = 5;
            this.pcView.TabStop = false;
            // 
            // Ho_so_gia_pha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcView);
            this.Controls.Add(this.pcEdit);
            this.Controls.Add(this.pcDelete);
            this.Controls.Add(this.pcAdd);
            this.Controls.Add(this.datathongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ho_so_gia_pha";
            this.Text = "Ho_so_gia_pha";
            ((System.ComponentModel.ISupportInitialize)(this.datathongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datathongtin;
        private System.Windows.Forms.PictureBox pcAdd;
        private System.Windows.Forms.PictureBox pcDelete;
        private System.Windows.Forms.PictureBox pcEdit;
        private System.Windows.Forms.PictureBox pcView;
    }
}