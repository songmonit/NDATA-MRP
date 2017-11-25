namespace NDATA_MRP
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label boPhanLabel;
            System.Windows.Forms.Label chucVuLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nhanVienBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNdataMrp = new NDATA_MRP.dsNdataMrp();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cmbStatus = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nhanVienBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblMsgDel = new System.Windows.Forms.ToolStripLabel();
            this.lblMsgAdd = new System.Windows.Forms.ToolStripLabel();
            this.nhanVienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maNVTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhCheckBox = new System.Windows.Forms.CheckBox();
            this.hinhAnhPictureBox = new System.Windows.Forms.PictureBox();
            this.boPhanTextBox = new System.Windows.Forms.TextBox();
            this.chucVuTextBox = new System.Windows.Forms.TextBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.dienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.nhanVienTableAdapter = new NDATA_MRP.dsNdataMrpTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new NDATA_MRP.dsNdataMrpTableAdapters.TableAdapterManager();
            this.chkChangeMaNV = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boPhanLabel2 = new System.Windows.Forms.Label();
            this.dienThoaiLabel2 = new System.Windows.Forms.Label();
            this.hoTenLabel2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            maNVLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            boPhanLabel = new System.Windows.Forms.Label();
            chucVuLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).BeginInit();
            this.nhanVienBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNdataMrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(19, 32);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(75, 13);
            maNVLabel.TabIndex = 2;
            maNVLabel.Text = "Mã nhân viên:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(48, 57);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(42, 13);
            hoTenLabel.TabIndex = 4;
            hoTenLabel.Text = "Họ tên:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(42, 176);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(50, 13);
            gioiTinhLabel.TabIndex = 8;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // boPhanLabel
            // 
            boPhanLabel.AutoSize = true;
            boPhanLabel.Location = new System.Drawing.Point(28, 115);
            boPhanLabel.Name = "boPhanLabel";
            boPhanLabel.Size = new System.Drawing.Size(67, 13);
            boPhanLabel.TabIndex = 12;
            boPhanLabel.Text = "Bộ phận CT:";
            // 
            // chucVuLabel
            // 
            chucVuLabel.AutoSize = true;
            chucVuLabel.Location = new System.Drawing.Point(45, 146);
            chucVuLabel.Name = "chucVuLabel";
            chucVuLabel.Size = new System.Drawing.Size(50, 13);
            chucVuLabel.TabIndex = 14;
            chucVuLabel.Text = "Chức vụ:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(41, 207);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Status:";
            statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(34, 85);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(58, 13);
            dienThoaiLabel.TabIndex = 20;
            dienThoaiLabel.Text = "Điện thoại:";
            // 
            // nhanVienBindingNavigator
            // 
            this.nhanVienBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhanVienBindingNavigator.BindingSource = this.nhanVienBindingSource;
            this.nhanVienBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhanVienBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhanVienBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbStatus,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nhanVienBindingNavigatorSaveItem,
            this.lblMsgDel,
            this.lblMsgAdd});
            this.nhanVienBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nhanVienBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhanVienBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhanVienBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhanVienBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhanVienBindingNavigator.Name = "nhanVienBindingNavigator";
            this.nhanVienBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhanVienBindingNavigator.Size = new System.Drawing.Size(1004, 25);
            this.nhanVienBindingNavigator.TabIndex = 0;
            this.nhanVienBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dsNdataMrp;
            // 
            // dsNdataMrp
            // 
            this.dsNdataMrp.DataSetName = "dsNdataMrp";
            this.dsNdataMrp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownWidth = 150;
            this.cmbStatus.Items.AddRange(new object[] {
            "Nhân viên đang lam",
            "Tất cả nhân viên"});
            this.cmbStatus.MaxLength = 150;
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(130, 25);
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nhanVienBindingNavigatorSaveItem
            // 
            this.nhanVienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhanVienBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanVienBindingNavigatorSaveItem.Image")));
            this.nhanVienBindingNavigatorSaveItem.Name = "nhanVienBindingNavigatorSaveItem";
            this.nhanVienBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nhanVienBindingNavigatorSaveItem.Text = "Save Data";
            this.nhanVienBindingNavigatorSaveItem.Click += new System.EventHandler(this.nhanVienBindingNavigatorSaveItem_Click);
            // 
            // lblMsgDel
            // 
            this.lblMsgDel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblMsgDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgDel.ForeColor = System.Drawing.Color.Red;
            this.lblMsgDel.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.lblMsgDel.Name = "lblMsgDel";
            this.lblMsgDel.Size = new System.Drawing.Size(30, 22);
            this.lblMsgDel.Text = "Xóa:";
            // 
            // lblMsgAdd
            // 
            this.lblMsgAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblMsgAdd.ForeColor = System.Drawing.Color.Blue;
            this.lblMsgAdd.Name = "lblMsgAdd";
            this.lblMsgAdd.Size = new System.Drawing.Size(41, 22);
            this.lblMsgAdd.Text = "Thêm:";
            // 
            // nhanVienDataGridView
            // 
            this.nhanVienDataGridView.AllowUserToAddRows = false;
            this.nhanVienDataGridView.AllowUserToOrderColumns = true;
            this.nhanVienDataGridView.AutoGenerateColumns = false;
            this.nhanVienDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.nhanVienDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.nhanVienDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nhanVienDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.nhanVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn2});
            this.nhanVienDataGridView.DataSource = this.nhanVienBindingSource;
            this.nhanVienDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVienDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.nhanVienDataGridView.Location = new System.Drawing.Point(5, 49);
            this.nhanVienDataGridView.Name = "nhanVienDataGridView";
            this.nhanVienDataGridView.Size = new System.Drawing.Size(659, 462);
            this.nhanVienDataGridView.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "HinhAnh";
            this.dataGridViewImageColumn1.HeaderText = "ẢNH";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MÃ NV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "HỌ TÊN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "GioiTinh";
            this.dataGridViewCheckBoxColumn1.HeaderText = "GIỚI TÍNH";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn5.HeaderText = "CHỨC VỤ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BoPhan";
            this.dataGridViewTextBoxColumn4.HeaderText = "BỘ PHẬN CT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DienThoai";
            this.dataGridViewTextBoxColumn7.HeaderText = "ĐIỆN THOẠI";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 91;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Status";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 47;
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNV", true));
            this.maNVTextBox.Enabled = false;
            this.maNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maNVTextBox.Location = new System.Drawing.Point(96, 22);
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(88, 24);
            this.maNVTextBox.TabIndex = 3;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "HoTen", true));
            this.hoTenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hoTenTextBox.Location = new System.Drawing.Point(96, 52);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(175, 24);
            this.hoTenTextBox.TabIndex = 5;
            this.hoTenTextBox.TextChanged += new System.EventHandler(this.hoTenTextBox_TextChanged);
            // 
            // gioiTinhCheckBox
            // 
            this.gioiTinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "GioiTinh", true));
            this.gioiTinhCheckBox.Location = new System.Drawing.Point(96, 172);
            this.gioiTinhCheckBox.Name = "gioiTinhCheckBox";
            this.gioiTinhCheckBox.Size = new System.Drawing.Size(131, 24);
            this.gioiTinhCheckBox.TabIndex = 9;
            this.gioiTinhCheckBox.Text = "Nam";
            this.gioiTinhCheckBox.UseVisualStyleBackColor = true;
            // 
            // hinhAnhPictureBox
            // 
            this.hinhAnhPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hinhAnhPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.nhanVienBindingSource, "HinhAnh", true));
            this.hinhAnhPictureBox.Location = new System.Drawing.Point(12, 0);
            this.hinhAnhPictureBox.Name = "hinhAnhPictureBox";
            this.hinhAnhPictureBox.Size = new System.Drawing.Size(104, 111);
            this.hinhAnhPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhAnhPictureBox.TabIndex = 11;
            this.hinhAnhPictureBox.TabStop = false;
            // 
            // boPhanTextBox
            // 
            this.boPhanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "BoPhan", true));
            this.boPhanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boPhanTextBox.Location = new System.Drawing.Point(96, 112);
            this.boPhanTextBox.Name = "boPhanTextBox";
            this.boPhanTextBox.Size = new System.Drawing.Size(90, 24);
            this.boPhanTextBox.TabIndex = 13;
            // 
            // chucVuTextBox
            // 
            this.chucVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "ChucVu", true));
            this.chucVuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucVuTextBox.Location = new System.Drawing.Point(96, 142);
            this.chucVuTextBox.Name = "chucVuTextBox";
            this.chucVuTextBox.Size = new System.Drawing.Size(90, 24);
            this.chucVuTextBox.TabIndex = 15;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "Status", true));
            this.statusCheckBox.Location = new System.Drawing.Point(96, 202);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(164, 24);
            this.statusCheckBox.TabIndex = 17;
            this.statusCheckBox.Text = "Đang làm";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // dienThoaiTextBox
            // 
            this.dienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DienThoai", true));
            this.dienThoaiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienThoaiTextBox.Location = new System.Drawing.Point(96, 82);
            this.dienThoaiTextBox.Name = "dienThoaiTextBox";
            this.dienThoaiTextBox.Size = new System.Drawing.Size(121, 24);
            this.dienThoaiTextBox.TabIndex = 21;
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(11, 112);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(105, 23);
            this.btnPic.TabIndex = 22;
            this.btnPic.Text = "Chọn ảnh NV";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.QuyenTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NDATA_MRP.dsNdataMrpTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // chkChangeMaNV
            // 
            this.chkChangeMaNV.AutoSize = true;
            this.chkChangeMaNV.Location = new System.Drawing.Point(190, 28);
            this.chkChangeMaNV.Name = "chkChangeMaNV";
            this.chkChangeMaNV.Size = new System.Drawing.Size(80, 17);
            this.chkChangeMaNV.TabIndex = 23;
            this.chkChangeMaNV.Text = "Sửa mã VN";
            this.chkChangeMaNV.UseVisualStyleBackColor = true;
            this.chkChangeMaNV.CheckedChanged += new System.EventHandler(this.chkChangeMaNV_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.hinhAnhPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.boPhanLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.dienThoaiLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.btnPic);
            this.splitContainer1.Panel1.Controls.Add(this.hoTenLabel2);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 516);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hoTenTextBox);
            this.panel1.Controls.Add(statusLabel);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.statusCheckBox);
            this.panel1.Controls.Add(hoTenLabel);
            this.panel1.Controls.Add(this.gioiTinhCheckBox);
            this.panel1.Controls.Add(this.maNVTextBox);
            this.panel1.Controls.Add(chucVuLabel);
            this.panel1.Controls.Add(boPhanLabel);
            this.panel1.Controls.Add(this.chucVuTextBox);
            this.panel1.Controls.Add(this.chkChangeMaNV);
            this.panel1.Controls.Add(this.boPhanTextBox);
            this.panel1.Controls.Add(maNVLabel);
            this.panel1.Controls.Add(this.dienThoaiTextBox);
            this.panel1.Controls.Add(dienThoaiLabel);
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 349);
            this.panel1.TabIndex = 29;
            // 
            // boPhanLabel2
            // 
            this.boPhanLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "BoPhan", true));
            this.boPhanLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boPhanLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.boPhanLabel2.Location = new System.Drawing.Point(123, 36);
            this.boPhanLabel2.Name = "boPhanLabel2";
            this.boPhanLabel2.Size = new System.Drawing.Size(100, 23);
            this.boPhanLabel2.TabIndex = 28;
            this.boPhanLabel2.Text = "Bộ phận";
            // 
            // dienThoaiLabel2
            // 
            this.dienThoaiLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DienThoai", true));
            this.dienThoaiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienThoaiLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dienThoaiLabel2.Location = new System.Drawing.Point(123, 88);
            this.dienThoaiLabel2.Name = "dienThoaiLabel2";
            this.dienThoaiLabel2.Size = new System.Drawing.Size(100, 23);
            this.dienThoaiLabel2.TabIndex = 27;
            this.dienThoaiLabel2.Text = "Điện thoại";
            // 
            // hoTenLabel2
            // 
            this.hoTenLabel2.AutoSize = true;
            this.hoTenLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "HoTen", true));
            this.hoTenLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.hoTenLabel2.Location = new System.Drawing.Point(122, 10);
            this.hoTenLabel2.Name = "hoTenLabel2";
            this.hoTenLabel2.Size = new System.Drawing.Size(74, 24);
            this.hoTenLabel2.TabIndex = 26;
            this.hoTenLabel2.Text = "Ho Ten";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nhanVienDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.365759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.63424F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 36);
            this.panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(584, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(275, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Nhập tên hoặc mã nhân viên ...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 570);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.nhanVienBindingNavigator);
            this.Name = "frmNhanVien";
            this.Text = "NHÂN VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).EndInit();
            this.nhanVienBindingNavigator.ResumeLayout(false);
            this.nhanVienBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNdataMrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsNdataMrp dsNdataMrp;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private dsNdataMrpTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private dsNdataMrpTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nhanVienBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nhanVienBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nhanVienDataGridView;
        private System.Windows.Forms.TextBox maNVTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.CheckBox gioiTinhCheckBox;
        private System.Windows.Forms.PictureBox hinhAnhPictureBox;
        private System.Windows.Forms.TextBox boPhanTextBox;
        private System.Windows.Forms.TextBox chucVuTextBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.TextBox dienThoaiTextBox;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.ToolStripComboBox cmbStatus;
        private System.Windows.Forms.CheckBox chkChangeMaNV;
        private System.Windows.Forms.ToolStripLabel lblMsgDel;
        private System.Windows.Forms.ToolStripLabel lblMsgAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dienThoaiLabel2;
        private System.Windows.Forms.Label hoTenLabel2;
        private System.Windows.Forms.Label boPhanLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}