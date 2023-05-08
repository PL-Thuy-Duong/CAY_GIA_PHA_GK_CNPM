namespace GIAO_DIEN_CNPM
{
    partial class Bao_cao
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkbsltt = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkbsltv = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grbbc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grbbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(5, 113);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(869, 325);
            this.reportViewer1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến năm";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 4;
            // 
            // chkbsltt
            // 
            this.chkbsltt.AutoSize = true;
            this.chkbsltt.BackColor = System.Drawing.Color.White;
            this.chkbsltt.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkbsltt.CheckedState.BorderRadius = 0;
            this.chkbsltt.CheckedState.BorderThickness = 0;
            this.chkbsltt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkbsltt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbsltt.Location = new System.Drawing.Point(436, 51);
            this.chkbsltt.Name = "chkbsltt";
            this.chkbsltt.Size = new System.Drawing.Size(221, 25);
            this.chkbsltt.TabIndex = 1;
            this.chkbsltt.Text = "Báo cáo số lượng thành tích";
            this.chkbsltt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkbsltt.UncheckedState.BorderRadius = 0;
            this.chkbsltt.UncheckedState.BorderThickness = 0;
            this.chkbsltt.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkbsltt.UseVisualStyleBackColor = false;
            // 
            // chkbsltv
            // 
            this.chkbsltv.AutoSize = true;
            this.chkbsltv.BackColor = System.Drawing.Color.White;
            this.chkbsltv.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkbsltv.CheckedState.BorderRadius = 0;
            this.chkbsltv.CheckedState.BorderThickness = 0;
            this.chkbsltv.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkbsltv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbsltv.Location = new System.Drawing.Point(154, 51);
            this.chkbsltv.Name = "chkbsltv";
            this.chkbsltv.Size = new System.Drawing.Size(234, 25);
            this.chkbsltv.TabIndex = 0;
            this.chkbsltv.Text = "Báo cáo tăng giảm thành viên";
            this.chkbsltv.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkbsltv.UncheckedState.BorderRadius = 0;
            this.chkbsltv.UncheckedState.BorderThickness = 0;
            this.chkbsltv.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkbsltv.UseVisualStyleBackColor = false;
            this.chkbsltv.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // grbbc
            // 
            this.grbbc.BackColor = System.Drawing.Color.ForestGreen;
            this.grbbc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbbc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.grbbc.Controls.Add(this.chkbsltv);
            this.grbbc.Controls.Add(this.chkbsltt);
            this.grbbc.CustomBorderColor = System.Drawing.Color.ForestGreen;
            this.grbbc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbc.ForeColor = System.Drawing.Color.Black;
            this.grbbc.Location = new System.Drawing.Point(-1, 0);
            this.grbbc.Name = "grbbc";
            this.grbbc.Size = new System.Drawing.Size(886, 87);
            this.grbbc.TabIndex = 2;
            this.grbbc.Text = "Tùy chọn báo cáo";
            this.grbbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bao_cao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.grbbc);
            this.Name = "Bao_cao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.Bc_tang_giam_tv_Load);
            this.grbbc.ResumeLayout(false);
            this.grbbc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2CheckBox chkbsltt;
        private Guna.UI2.WinForms.Guna2CheckBox chkbsltv;
        private Guna.UI2.WinForms.Guna2GroupBox grbbc;
    }
}