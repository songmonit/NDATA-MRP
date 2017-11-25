namespace NDATA_MRP
{
    partial class frmKhachHang
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
            System.Windows.Forms.Label supplier_codeLabel;
            System.Windows.Forms.Label supplier_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label taxLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label supplier_GroupLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.suppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNdataMrp = new NDATA_MRP.dsNdataMrp();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.suppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.supplier_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.supplier_GroupTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.suppliersTableAdapter = new NDATA_MRP.dsNdataMrpTableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new NDATA_MRP.dsNdataMrpTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            supplier_codeLabel = new System.Windows.Forms.Label();
            supplier_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            supplier_GroupLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).BeginInit();
            this.suppliersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNdataMrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplier_codeLabel
            // 
            supplier_codeLabel.AutoSize = true;
            supplier_codeLabel.Location = new System.Drawing.Point(7, 54);
            supplier_codeLabel.Name = "supplier_codeLabel";
            supplier_codeLabel.Size = new System.Drawing.Size(85, 13);
            supplier_codeLabel.TabIndex = 2;
            supplier_codeLabel.Text = "Mã Khách Hàng";
            // 
            // supplier_NameLabel
            // 
            supplier_NameLabel.AutoSize = true;
            supplier_NameLabel.Location = new System.Drawing.Point(6, 80);
            supplier_NameLabel.Name = "supplier_NameLabel";
            supplier_NameLabel.Size = new System.Drawing.Size(86, 13);
            supplier_NameLabel.TabIndex = 4;
            supplier_NameLabel.Text = "Tên khách hàng";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(52, 122);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(40, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Đại chỉ";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(37, 165);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 13);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Điện thoại";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(234, 161);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(24, 13);
            faxLabel.TabIndex = 10;
            faxLabel.Text = "Fax";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new System.Drawing.Point(436, 102);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(28, 13);
            taxLabel.TabIndex = 14;
            taxLabel.Text = "Tax:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(699, 79);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Status:";
            // 
            // supplier_GroupLabel
            // 
            supplier_GroupLabel.AutoSize = true;
            supplier_GroupLabel.Location = new System.Drawing.Point(692, 53);
            supplier_GroupLabel.Name = "supplier_GroupLabel";
            supplier_GroupLabel.Size = new System.Drawing.Size(87, 13);
            supplier_GroupLabel.TabIndex = 22;
            supplier_GroupLabel.Text = "Loại khách hàng";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(436, 50);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(53, 13);
            cityLabel.TabIndex = 26;
            cityLabel.Text = "Tỉnh / TP";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(436, 76);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(50, 13);
            countryLabel.TabIndex = 28;
            countryLabel.Text = "Quốc gia";
            // 
            // suppliersBindingNavigator
            // 
            this.suppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.suppliersBindingNavigator.BindingSource = this.suppliersBindingSource;
            this.suppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.suppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.suppliersBindingNavigatorSaveItem});
            this.suppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliersBindingNavigator.Name = "suppliersBindingNavigator";
            this.suppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliersBindingNavigator.Size = new System.Drawing.Size(1121, 25);
            this.suppliersBindingNavigator.TabIndex = 0;
            this.suppliersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.dsNdataMrp;
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
            // suppliersBindingNavigatorSaveItem
            // 
            this.suppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBindingNavigatorSaveItem.Image")));
            this.suppliersBindingNavigatorSaveItem.Name = "suppliersBindingNavigatorSaveItem";
            this.suppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.suppliersBindingNavigatorSaveItem.Text = "Save Data";
            this.suppliersBindingNavigatorSaveItem.Click += new System.EventHandler(this.suppliersBindingNavigatorSaveItem_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AutoGenerateColumns = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvSupplier.DataSource = this.suppliersBindingSource;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.Location = new System.Drawing.Point(5, 5);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(1090, 390);
            this.dgvSupplier.TabIndex = 1;
            this.dgvSupplier.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellEndEdit);
            this.dgvSupplier.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSupplier_CellValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Supplier_code";
            this.dataGridViewTextBoxColumn1.HeaderText = "MÃ KHÁCH HÀNG";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Supplier_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "TÊN KHÁCH HÀNG";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "ĐỊA CHỈ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "ĐIỆN THOẠI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fax";
            this.dataGridViewTextBoxColumn5.HeaderText = "FAX";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Payment_Term";
            this.dataGridViewTextBoxColumn6.HeaderText = "THANH TOÁN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Tax";
            this.dataGridViewTextBoxColumn7.HeaderText = "THUẾ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "New_Status";
            this.dataGridViewTextBoxColumn9.HeaderText = "New_Status";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn10.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Supplier_Group";
            this.dataGridViewTextBoxColumn11.HeaderText = "NHÓM KH";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Re_Run";
            this.dataGridViewTextBoxColumn12.HeaderText = "Re_Run";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn13.HeaderText = "TỈNH-TP";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn14.HeaderText = "QUỐC GIA";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Supplier_code", true));
            this.txtSupplierCode.Location = new System.Drawing.Point(98, 51);
            this.txtSupplierCode.MaxLength = 12;
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(129, 20);
            this.txtSupplierCode.TabIndex = 3;
            // 
            // supplier_NameTextBox
            // 
            this.supplier_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Supplier_Name", true));
            this.supplier_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_NameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.supplier_NameTextBox.Location = new System.Drawing.Point(98, 77);
            this.supplier_NameTextBox.Name = "supplier_NameTextBox";
            this.supplier_NameTextBox.Size = new System.Drawing.Size(299, 22);
            this.supplier_NameTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(98, 103);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(299, 49);
            this.addressTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(98, 158);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(129, 20);
            this.phoneTextBox.TabIndex = 9;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(263, 158);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(134, 20);
            this.faxTextBox.TabIndex = 11;
            // 
            // taxTextBox
            // 
            this.taxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Tax", true));
            this.taxTextBox.Location = new System.Drawing.Point(522, 99);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(121, 20);
            this.taxTextBox.TabIndex = 15;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(785, 76);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 17;
            // 
            // supplier_GroupTextBox
            // 
            this.supplier_GroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Supplier_Group", true));
            this.supplier_GroupTextBox.Location = new System.Drawing.Point(785, 50);
            this.supplier_GroupTextBox.Name = "supplier_GroupTextBox";
            this.supplier_GroupTextBox.Size = new System.Drawing.Size(121, 20);
            this.supplier_GroupTextBox.TabIndex = 23;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(522, 47);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(121, 20);
            this.cityTextBox.TabIndex = 27;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(522, 73);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(121, 20);
            this.countryTextBox.TabIndex = 29;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.QuyenTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = NDATA_MRP.dsNdataMrpTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.24086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.75914F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSupplier, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 198);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.2449F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 400);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(439, 158);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 42);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(584, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(580, 21);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.Text = "Nhập mã, tên, địa chỉ hoặc số điện thoại khách hàng...";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 604);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(supplier_codeLabel);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(supplier_NameLabel);
            this.Controls.Add(this.supplier_NameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(taxLabel);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(supplier_GroupLabel);
            this.Controls.Add(this.supplier_GroupTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.suppliersBindingNavigator);
            this.Name = "frmKhachHang";
            this.Text = "KHÁCH HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).EndInit();
            this.suppliersBindingNavigator.ResumeLayout(false);
            this.suppliersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNdataMrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsNdataMrp dsNdataMrp;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private dsNdataMrpTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private dsNdataMrpTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator suppliersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton suppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.TextBox supplier_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox supplier_GroupTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}