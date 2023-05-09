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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.qLGiaPhaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_Gia_PhaDataSet = new GIAO_DIEN_CNPM.QL_Gia_PhaDataSet();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaPhaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_Gia_PhaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // qLGiaPhaDataSetBindingSource
            // 
            this.qLGiaPhaDataSetBindingSource.DataSource = this.qL_Gia_PhaDataSet;
            this.qLGiaPhaDataSetBindingSource.Position = 0;
            // 
            // qL_Gia_PhaDataSet
            // 
            this.qL_Gia_PhaDataSet.DataSetName = "QL_Gia_PhaDataSet";
            this.qL_Gia_PhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnIn.Location = new System.Drawing.Point(593, 111);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(47, 24);
            this.btnIn.TabIndex = 33;
            this.btnIn.Text = "In";
            this.btnIn.UseTransparentBackground = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // rpvBaoCao
            // 
            reportDataSource2.Name = "SLThanhTich";
            reportDataSource2.Value = this.qLGiaPhaDataSetBindingSource;
            this.rpvBaoCao.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "GIAO_DIEN_CNPM.So_luong_TT.rdlc";
            this.rpvBaoCao.Location = new System.Drawing.Point(37, 153);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(633, 271);
            this.rpvBaoCao.TabIndex = 34;
            this.rpvBaoCao.Load += new System.EventHandler(this.rpvBaoCao_Load_1);
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
            this.guna2Button1.Location = new System.Drawing.Point(97, 41);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(481, 58);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "BÁO CÁO SỐ LƯỢNG THÀNH VIÊN";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.rpvBaoCao);
            this.Controls.Add(this.btnIn);
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaPhaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_Gia_PhaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.BindingSource qLGiaPhaDataSetBindingSource;
        private QL_Gia_PhaDataSet qL_Gia_PhaDataSet;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}