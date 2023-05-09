namespace GIAO_DIEN_CNPM
{
    partial class Bao_Cao_SLTT_1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 17.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(106, 26);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(481, 50);
            this.guna2Button1.TabIndex = 38;
            this.guna2Button1.Text = "BÁO CÁO SỐ LƯỢNG THÀNH TÍCH";
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "SLThanhTich";
            reportDataSource1.Value = null;
            this.rpvBaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "GIAO_DIEN_CNPM.So_luong_TT.rdlc";
            this.rpvBaoCao.Location = new System.Drawing.Point(12, 94);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(687, 344);
            this.rpvBaoCao.TabIndex = 37;
            // 
            // btnIn
            // 
            this.btnIn.Animated = true;
            this.btnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnIn.BorderRadius = 5;
            this.btnIn.BorderThickness = 1;
            this.btnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIn.FillColor = System.Drawing.Color.White;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.Green;
            this.btnIn.Location = new System.Drawing.Point(603, 60);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(54, 28);
            this.btnIn.TabIndex = 36;
            this.btnIn.Text = "In";
            this.btnIn.UseTransparentBackground = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // Bao_Cao_SLTT_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.rpvBaoCao);
            this.Controls.Add(this.btnIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Bao_Cao_SLTT_1";
            this.Text = "Báo cáo số lượng thành tích";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnIn;
    }
}