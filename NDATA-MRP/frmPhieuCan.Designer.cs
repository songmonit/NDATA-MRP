namespace NDATA_MRP
{
    partial class frmPhieuCan
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
            System.Windows.Forms.Label phieu_canLabel;
            System.Windows.Forms.Label lan_canLabel;
            System.Windows.Forms.Label trong_luongLabel;
            this.dsNdataMrp = new NDATA_MRP.dsNdataMrp();
            this.dgvPhieuCanChiTiet = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtLanCan = new System.Windows.Forms.TextBox();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCanLai = new System.Windows.Forms.Button();
            this.txtPhieuCan = new System.Windows.Forms.TextBox();
            phieu_canLabel = new System.Windows.Forms.Label();
            lan_canLabel = new System.Windows.Forms.Label();
            trong_luongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsNdataMrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuCanChiTiet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // phieu_canLabel
            // 
            phieu_canLabel.AutoSize = true;
            phieu_canLabel.Location = new System.Drawing.Point(6, 10);
            phieu_canLabel.Name = "phieu_canLabel";
            phieu_canLabel.Size = new System.Drawing.Size(55, 13);
            phieu_canLabel.TabIndex = 0;
            phieu_canLabel.Text = "Phiếu cân";
            // 
            // lan_canLabel
            // 
            lan_canLabel.AutoSize = true;
            lan_canLabel.Location = new System.Drawing.Point(21, 5);
            lan_canLabel.Name = "lan_canLabel";
            lan_canLabel.Size = new System.Drawing.Size(46, 13);
            lan_canLabel.TabIndex = 2;
            lan_canLabel.Text = "Lần cân";
            // 
            // trong_luongLabel
            // 
            trong_luongLabel.AutoSize = true;
            trong_luongLabel.Location = new System.Drawing.Point(99, 5);
            trong_luongLabel.Name = "trong_luongLabel";
            trong_luongLabel.Size = new System.Drawing.Size(64, 13);
            trong_luongLabel.TabIndex = 4;
            trong_luongLabel.Text = "Trọng lượng";
            // 
            // dsNdataMrp
            // 
            this.dsNdataMrp.DataSetName = "dsNdataMrp";
            this.dsNdataMrp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPhieuCanChiTiet
            // 
            this.dgvPhieuCanChiTiet.AllowUserToAddRows = false;
            this.dgvPhieuCanChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuCanChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuCanChiTiet.Location = new System.Drawing.Point(5, 84);
            this.dgvPhieuCanChiTiet.Name = "dgvPhieuCanChiTiet";
            this.dgvPhieuCanChiTiet.Size = new System.Drawing.Size(324, 461);
            this.dgvPhieuCanChiTiet.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvPhieuCanChiTiet, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.13428F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.86572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 621);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Controls.Add(lan_canLabel);
            this.panel1.Controls.Add(this.txtLanCan);
            this.panel1.Controls.Add(trong_luongLabel);
            this.panel1.Controls.Add(this.txtTrongLuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 71);
            this.panel1.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(221, 21);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 43);
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtLanCan
            // 
            this.txtLanCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanCan.Location = new System.Drawing.Point(15, 21);
            this.txtLanCan.Name = "txtLanCan";
            this.txtLanCan.ReadOnly = true;
            this.txtLanCan.Size = new System.Drawing.Size(60, 44);
            this.txtLanCan.TabIndex = 3;
            this.txtLanCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrongLuong.Location = new System.Drawing.Point(81, 21);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(133, 44);
            this.txtTrongLuong.TabIndex = 5;
            this.txtTrongLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 21);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TỔNG TRỌNG LƯỢNG:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCanLai);
            this.panel3.Controls.Add(this.txtPhieuCan);
            this.panel3.Controls.Add(phieu_canLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 34);
            this.panel3.TabIndex = 4;
            // 
            // btnCanLai
            // 
            this.btnCanLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanLai.Location = new System.Drawing.Point(242, 6);
            this.btnCanLai.Name = "btnCanLai";
            this.btnCanLai.Size = new System.Drawing.Size(75, 22);
            this.btnCanLai.TabIndex = 7;
            this.btnCanLai.Text = "Cân lại";
            this.btnCanLai.UseVisualStyleBackColor = true;
            // 
            // txtPhieuCan
            // 
            this.txtPhieuCan.Location = new System.Drawing.Point(63, 7);
            this.txtPhieuCan.Name = "txtPhieuCan";
            this.txtPhieuCan.ReadOnly = true;
            this.txtPhieuCan.Size = new System.Drawing.Size(92, 20);
            this.txtPhieuCan.TabIndex = 1;
            // 
            // frmPhieuCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 626);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmPhieuCan";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 5);
            this.Text = "PHIẾU CÂN HÀNG";
            this.Load += new System.EventHandler(this.frmPhieuCan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNdataMrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuCanChiTiet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsNdataMrp dsNdataMrp;
        private System.Windows.Forms.DataGridView dgvPhieuCanChiTiet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPhieuCan;
        private System.Windows.Forms.TextBox txtLanCan;
        private System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.Button btnCanLai;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}