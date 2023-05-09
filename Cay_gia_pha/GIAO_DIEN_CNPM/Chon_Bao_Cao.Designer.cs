namespace GIAO_DIEN_CNPM
{
    partial class Chon_Bao_Cao
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
            this.gpbbaocao = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSLTT = new Guna.UI2.WinForms.Guna2Button();
            this.btnTGTV = new Guna.UI2.WinForms.Guna2Button();
            this.gpbbaocao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbbaocao
            // 
            this.gpbbaocao.BackColor = System.Drawing.Color.White;
            this.gpbbaocao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gpbbaocao.Controls.Add(this.btnSLTT);
            this.gpbbaocao.Controls.Add(this.btnTGTV);
            this.gpbbaocao.CustomBorderColor = System.Drawing.Color.Green;
            this.gpbbaocao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.gpbbaocao.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.gpbbaocao.ForeColor = System.Drawing.Color.White;
            this.gpbbaocao.Location = new System.Drawing.Point(79, 57);
            this.gpbbaocao.Name = "gpbbaocao";
            this.gpbbaocao.Size = new System.Drawing.Size(596, 233);
            this.gpbbaocao.TabIndex = 0;
            this.gpbbaocao.Text = "BÁO CÁO HÀNG NĂM";
            this.gpbbaocao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSLTT
            // 
            this.btnSLTT.BackColor = System.Drawing.Color.Transparent;
            this.btnSLTT.BorderRadius = 5;
            this.btnSLTT.BorderThickness = 1;
            this.btnSLTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSLTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSLTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSLTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSLTT.FillColor = System.Drawing.Color.White;
            this.btnSLTT.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSLTT.ForeColor = System.Drawing.Color.Green;
            this.btnSLTT.Location = new System.Drawing.Point(119, 136);
            this.btnSLTT.Name = "btnSLTT";
            this.btnSLTT.Size = new System.Drawing.Size(374, 46);
            this.btnSLTT.TabIndex = 4;
            this.btnSLTT.Text = "Báo cáo số lượng thành tích";
            this.btnSLTT.Click += new System.EventHandler(this.btnSLTT_Click);
            // 
            // btnTGTV
            // 
            this.btnTGTV.BackColor = System.Drawing.Color.Transparent;
            this.btnTGTV.BorderRadius = 5;
            this.btnTGTV.BorderThickness = 1;
            this.btnTGTV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTGTV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTGTV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTGTV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTGTV.FillColor = System.Drawing.Color.White;
            this.btnTGTV.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnTGTV.ForeColor = System.Drawing.Color.Green;
            this.btnTGTV.Location = new System.Drawing.Point(119, 85);
            this.btnTGTV.Name = "btnTGTV";
            this.btnTGTV.Size = new System.Drawing.Size(374, 46);
            this.btnTGTV.TabIndex = 3;
            this.btnTGTV.Text = "Báo cáo tăng giảm số lượng thành viên";
            this.btnTGTV.Click += new System.EventHandler(this.btnTGTV_Click);
            // 
            // Chon_Bao_Cao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(783, 354);
            this.Controls.Add(this.gpbbaocao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chon_Bao_Cao";
            this.Text = "Chon_Bao_Cao";
            this.Load += new System.EventHandler(this.Chon_Bao_Cao_Load);
            this.gpbbaocao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gpbbaocao;
        private Guna.UI2.WinForms.Guna2Button btnSLTT;
        private Guna.UI2.WinForms.Guna2Button btnTGTV;
    }
}