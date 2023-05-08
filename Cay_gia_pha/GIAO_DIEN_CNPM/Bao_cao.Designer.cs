namespace GIAO_DIEN_CNPM
{
    partial class frmBaoCao
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
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbbc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.slttich = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdtgtvien = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpTu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.grbbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Location = new System.Drawing.Point(14, 123);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(674, 324);
            this.rpvBaoCao.TabIndex = 3;
            this.rpvBaoCao.Load += new System.EventHandler(this.rpvBaoCao_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ";
            // 
            // grbbc
            // 
            this.grbbc.BackColor = System.Drawing.Color.ForestGreen;
            this.grbbc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbbc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.grbbc.Controls.Add(this.slttich);
            this.grbbc.Controls.Add(this.rdtgtvien);
            this.grbbc.CustomBorderColor = System.Drawing.Color.ForestGreen;
            this.grbbc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbc.ForeColor = System.Drawing.Color.Black;
            this.grbbc.Location = new System.Drawing.Point(-1, 0);
            this.grbbc.Name = "grbbc";
            this.grbbc.Size = new System.Drawing.Size(712, 78);
            this.grbbc.TabIndex = 2;
            this.grbbc.Text = "Tùy chọn báo cáo";
            this.grbbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // slttich
            // 
            this.slttich.AutoSize = true;
            this.slttich.BackColor = System.Drawing.Color.Ivory;
            this.slttich.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slttich.CheckedState.BorderThickness = 0;
            this.slttich.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.slttich.CheckedState.InnerColor = System.Drawing.Color.White;
            this.slttich.CheckedState.InnerOffset = -4;
            this.slttich.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slttich.Location = new System.Drawing.Point(372, 43);
            this.slttich.Name = "slttich";
            this.slttich.Size = new System.Drawing.Size(220, 25);
            this.slttich.TabIndex = 3;
            this.slttich.Text = "Báo cáo số lượng thành tích";
            this.slttich.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.slttich.UncheckedState.BorderThickness = 2;
            this.slttich.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.slttich.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.slttich.UseVisualStyleBackColor = false;
            this.slttich.CheckedChanged += new System.EventHandler(this.slttich_CheckedChanged);
            // 
            // rdtgtvien
            // 
            this.rdtgtvien.AutoSize = true;
            this.rdtgtvien.BackColor = System.Drawing.Color.Ivory;
            this.rdtgtvien.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdtgtvien.CheckedState.BorderThickness = 0;
            this.rdtgtvien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdtgtvien.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdtgtvien.CheckedState.InnerOffset = -4;
            this.rdtgtvien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdtgtvien.Location = new System.Drawing.Point(107, 43);
            this.rdtgtvien.Name = "rdtgtvien";
            this.rdtgtvien.Size = new System.Drawing.Size(233, 25);
            this.rdtgtvien.TabIndex = 2;
            this.rdtgtvien.Text = "Báo cáo tăng giảm thành viên";
            this.rdtgtvien.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdtgtvien.UncheckedState.BorderThickness = 2;
            this.rdtgtvien.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdtgtvien.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdtgtvien.UseVisualStyleBackColor = false;
            // 
            // dtpTu
            // 
            this.dtpTu.Checked = true;
            this.dtpTu.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpTu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(197, 88);
            this.dtpTu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(101, 18);
            this.dtpTu.TabIndex = 2;
            this.dtpTu.Value = new System.DateTime(2023, 5, 8, 23, 45, 34, 996);
            // 
            // dtpDen
            // 
            this.dtpDen.Checked = true;
            this.dtpDen.FillColor = System.Drawing.Color.White;
            this.dtpDen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(336, 88);
            this.dtpDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(101, 18);
            this.dtpDen.TabIndex = 8;
            this.dtpDen.Value = new System.DateTime(2023, 5, 8, 23, 45, 34, 996);
            // 
            // btnIn
            // 
            this.btnIn.Animated = true;
            this.btnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnIn.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnIn.BorderRadius = 5;
            this.btnIn.BorderThickness = 1;
            this.btnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(142)))), ((int)(((byte)(68)))));
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnIn.Location = new System.Drawing.Point(455, 83);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(47, 24);
            this.btnIn.TabIndex = 33;
            this.btnIn.Text = "In";
            this.btnIn.UseTransparentBackground = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvBaoCao);
            this.Controls.Add(this.grbbc);
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.grbbc.ResumeLayout(false);
            this.grbbc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox grbbc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDen;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private Guna.UI2.WinForms.Guna2RadioButton slttich;
        private Guna.UI2.WinForms.Guna2RadioButton rdtgtvien;
    }
}