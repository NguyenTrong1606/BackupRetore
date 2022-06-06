namespace frmmain
{
    partial class frmmain
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DS1 = new BackupRetore.DS();
            this.bdsDatabases = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter1 = new BackupRetore.DSTableAdapters.databasesTableAdapter();
            this.tableAdapterTenDB = new BackupRetore.DSTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.bdsSP_STT_BACKUP = new System.Windows.Forms.BindingSource(this.components);
            this.Menu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.cbThamSoPhucHoiTheoTG = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaoDeviceSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XoaBK = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.txtNameDB = new DevExpress.XtraEditors.TextEdit();
            this.SP_STT_BACKUPTableAdapter = new BackupRetore.DSTableAdapters.SP_STT_BACKUPTableAdapter();
            this.sP_STT_BACKUPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.pcDateTime = new DevExpress.XtraEditors.PanelControl();
            this.edTime = new DevExpress.XtraEditors.TimeEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.edDate = new DevExpress.XtraEditors.DateEdit();
            this.bdsBackupset = new System.Windows.Forms.BindingSource(this.components);
            this.taBackupset = new BackupRetore.DSTableAdapters.backupsetTableAdapter();
            this.bdsRestore_id = new System.Windows.Forms.BindingSource(this.components);
            this.taRestore_id = new BackupRetore.DSTableAdapters.restore_idTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_STT_BACKUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDateTime)).BeginInit();
            this.pcDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRestore_id)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(22, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(192, 23);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Tên Cơ Sở Dữ Liệu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(354, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(246, 17);
            label1.TabIndex = 44;
            label1.Text = "Ngày giờ để phục hồi về thời điểm đó: ";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // colname
            // 
            this.colname.Name = "colname";
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDatabases
            // 
            this.bdsDatabases.DataMember = "databases";
            this.bdsDatabases.DataSource = this.DS1;
            // 
            // databasesTableAdapter1
            // 
            this.databasesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterTenDB
            // 
            this.tableAdapterTenDB.BackupDataSetBeforeUpdate = false;
            this.tableAdapterTenDB.Connection = null;
            this.tableAdapterTenDB.UpdateOrder = BackupRetore.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtPosition);
            this.panelControl1.Controls.Add(this.progress);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.txtNameDB);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(216, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1375, 65);
            this.panelControl1.TabIndex = 18;
            // 
            // txtPosition
            // 
            this.txtPosition.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSP_STT_BACKUP, "position", true));
            this.txtPosition.Location = new System.Drawing.Point(406, 12);
            this.txtPosition.MenuManager = this.Menu;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Properties.Appearance.Options.UseFont = true;
            this.txtPosition.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPosition.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPosition.Properties.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(116, 28);
            this.txtPosition.TabIndex = 5;
            // 
            // bdsSP_STT_BACKUP
            // 
            this.bdsSP_STT_BACKUP.DataMember = "SP_STT_BACKUP";
            this.bdsSP_STT_BACKUP.DataSource = this.DS1;
            // 
            // Menu
            // 
            this.Menu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.Menu.DockControls.Add(this.barDockControlTop);
            this.Menu.DockControls.Add(this.barDockControlBottom);
            this.Menu.DockControls.Add(this.barDockControlLeft);
            this.Menu.DockControls.Add(this.barDockControlRight);
            this.Menu.Form = this;
            this.Menu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.cbThamSoPhucHoiTheoTG,
            this.btnTaoDeviceSaoLuu,
            this.btnThoat,
            this.btn_XoaBK});
            this.Menu.MainMenu = this.bar2;
            this.Menu.MaxItemId = 6;
            this.Menu.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaoLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cbThamSoPhucHoiTheoTG, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoDeviceSaoLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_XoaBK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao Lưu";
            this.btnSaoLuu.Id = 0;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 1;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // cbThamSoPhucHoiTheoTG
            // 
            this.cbThamSoPhucHoiTheoTG.Caption = "Tham Số Phục Hồi Theo Thời Gian";
            this.cbThamSoPhucHoiTheoTG.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.cbThamSoPhucHoiTheoTG.Id = 2;
            this.cbThamSoPhucHoiTheoTG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbThamSoPhucHoiTheoTG.ImageOptions.Image")));
            this.cbThamSoPhucHoiTheoTG.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cbThamSoPhucHoiTheoTG.ImageOptions.LargeImage")));
            this.cbThamSoPhucHoiTheoTG.Name = "cbThamSoPhucHoiTheoTG";
            this.cbThamSoPhucHoiTheoTG.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.cbThamSoPhucHoiTheoTG_CheckedChanged);
            // 
            // btnTaoDeviceSaoLuu
            // 
            this.btnTaoDeviceSaoLuu.Caption = "Tạo DEVICE Sao Lưu";
            this.btnTaoDeviceSaoLuu.Id = 3;
            this.btnTaoDeviceSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoDeviceSaoLuu.ImageOptions.Image")));
            this.btnTaoDeviceSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoDeviceSaoLuu.ImageOptions.LargeImage")));
            this.btnTaoDeviceSaoLuu.Name = "btnTaoDeviceSaoLuu";
            this.btnTaoDeviceSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDeviceSaoLuu_ItemClick);
            // 
            // btn_XoaBK
            // 
            this.btn_XoaBK.Caption = "Xóa Backup";
            this.btn_XoaBK.Id = 5;
            this.btn_XoaBK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaBK.ImageOptions.Image")));
            this.btn_XoaBK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XoaBK.ImageOptions.LargeImage")));
            this.btn_XoaBK.Name = "btn_XoaBK";
            this.btn_XoaBK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XoaBK_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.Menu;
            this.barDockControlTop.Size = new System.Drawing.Size(1591, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1045);
            this.barDockControlBottom.Manager = this.Menu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1591, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.Menu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1020);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1591, 25);
            this.barDockControlRight.Manager = this.Menu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1020);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(665, 15);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(565, 25);
            this.progress.TabIndex = 4;
            this.progress.Visible = false;
            // 
            // txtNameDB
            // 
            this.txtNameDB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatabases, "name", true));
            this.txtNameDB.Location = new System.Drawing.Point(220, 12);
            this.txtNameDB.Name = "txtNameDB";
            this.txtNameDB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDB.Properties.Appearance.Options.UseFont = true;
            this.txtNameDB.Properties.ReadOnly = true;
            this.txtNameDB.Size = new System.Drawing.Size(164, 28);
            this.txtNameDB.TabIndex = 1;
            this.txtNameDB.EditValueChanged += new System.EventHandler(this.txtNameDB_EditValueChanged);
            // 
            // SP_STT_BACKUPTableAdapter
            // 
            this.SP_STT_BACKUPTableAdapter.ClearBeforeFill = true;
            // 
            // sP_STT_BACKUPGridControl
            // 
            this.sP_STT_BACKUPGridControl.DataSource = this.bdsSP_STT_BACKUP;
            this.sP_STT_BACKUPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_STT_BACKUPGridControl.Location = new System.Drawing.Point(216, 90);
            this.sP_STT_BACKUPGridControl.MainView = this.gridView3;
            this.sP_STT_BACKUPGridControl.Name = "sP_STT_BACKUPGridControl";
            this.sP_STT_BACKUPGridControl.Size = new System.Drawing.Size(1375, 220);
            this.sP_STT_BACKUPGridControl.TabIndex = 26;
            this.sP_STT_BACKUPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname2,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView3.GridControl = this.sP_STT_BACKUPGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // colposition
            // 
            this.colposition.Caption = "Bản Sao Lưu Thứ #";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 22;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.ReadOnly = true;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 83;
            // 
            // colname2
            // 
            this.colname2.Caption = "Diễn Giải";
            this.colname2.FieldName = "name";
            this.colname2.MinWidth = 22;
            this.colname2.Name = "colname2";
            this.colname2.OptionsColumn.ReadOnly = true;
            this.colname2.Visible = true;
            this.colname2.VisibleIndex = 1;
            this.colname2.Width = 83;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Ngày Giờ Sao Lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "HH:mm:ss  dd/MM/yyyy";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.GroupFormat.FormatString = "HH:mm:ss  dd/MM/yyyy";
            this.colbackup_start_date.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.MinWidth = 22;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.ReadOnly = true;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 83;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "User Sao Lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 22;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.ReadOnly = true;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 83;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(664, 336);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(309, 18);
            this.cbDelete.TabIndex = 27;
            this.cbDelete.Text = "Xóa tất cả bản sao lưu cũ trước khi sao lưu bản mới";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname1});
            this.gridView2.GridControl = this.databasesGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colname1
            // 
            this.colname1.Caption = "Cơ Sở Dữ Liệu";
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 22;
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.ReadOnly = true;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 0;
            this.colname1.Width = 83;
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.bdsDatabases;
            this.databasesGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.databasesGridControl.Location = new System.Drawing.Point(0, 25);
            this.databasesGridControl.MainView = this.gridView2;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(216, 1020);
            this.databasesGridControl.TabIndex = 9;
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.databasesGridControl.Click += new System.EventHandler(this.databasesGridControl_Click);
            // 
            // pcDateTime
            // 
            this.pcDateTime.Controls.Add(this.edTime);
            this.pcDateTime.Controls.Add(this.textBox1);
            this.pcDateTime.Controls.Add(this.edDate);
            this.pcDateTime.Controls.Add(label1);
            this.pcDateTime.Location = new System.Drawing.Point(216, 381);
            this.pcDateTime.Name = "pcDateTime";
            this.pcDateTime.Size = new System.Drawing.Size(1375, 664);
            this.pcDateTime.TabIndex = 48;
            this.pcDateTime.Visible = false;
            // 
            // edTime
            // 
            this.edTime.EditValue = new System.DateTime(2022, 4, 25, 0, 0, 0, 0);
            this.edTime.Location = new System.Drawing.Point(742, 42);
            this.edTime.MenuManager = this.Menu;
            this.edTime.Name = "edTime";
            this.edTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edTime.Size = new System.Drawing.Size(110, 22);
            this.edTime.TabIndex = 49;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(357, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 62);
            this.textBox1.TabIndex = 47;
            this.textBox1.Text = "Hướng Dẫn: Ngày giờ ta nhập vào là thời điểm ta muốn phục hồi cơ sở dữ liệu về đó" +
    ". Thời điểm này phải sau thời điểm của bản sao lưu đã chọn trên lưới và trước th" +
    "ời điểm hiện tại";
            // 
            // edDate
            // 
            this.edDate.EditValue = null;
            this.edDate.Location = new System.Drawing.Point(606, 43);
            this.edDate.Name = "edDate";
            this.edDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDate.Size = new System.Drawing.Size(130, 20);
            this.edDate.TabIndex = 45;
            // 
            // bdsBackupset
            // 
            this.bdsBackupset.DataMember = "backupset";
            this.bdsBackupset.DataSource = this.DS1;
            // 
            // taBackupset
            // 
            this.taBackupset.ClearBeforeFill = true;
            // 
            // bdsRestore_id
            // 
            this.bdsRestore_id.DataMember = "restore_id";
            this.bdsRestore_id.DataSource = this.DS1;
            // 
            // taRestore_id
            // 
            this.taRestore_id.ClearBeforeFill = true;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1591, 1065);
            this.Controls.Add(this.pcDateTime);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.sP_STT_BACKUPGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.databasesGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmmain";
            this.Text = "Sao Lưu - Phục hồi cơ sở dữ liệu trong SQL SERVER";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_STT_BACKUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDateTime)).EndInit();
            this.pcDateTime.ResumeLayout(false);
            this.pcDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackupset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRestore_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BackupRetore.DS dS;
        private BackupRetore.DSTableAdapters.databasesTableAdapter databasesTableAdapter;
        private BackupRetore.DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private System.Windows.Forms.BindingSource bdsDatabases;
        private BackupRetore.DS DS1;
        private BackupRetore.DSTableAdapters.databasesTableAdapter databasesTableAdapter1;
        private BackupRetore.DSTableAdapters.TableAdapterManager tableAdapterTenDB;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtNameDB;
        private System.Windows.Forms.BindingSource bdsSP_STT_BACKUP;
        private BackupRetore.DSTableAdapters.SP_STT_BACKUPTableAdapter SP_STT_BACKUPTableAdapter;
        private System.Windows.Forms.CheckBox cbDelete;
        private DevExpress.XtraGrid.GridControl sP_STT_BACKUPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname2;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraBars.BarManager Menu;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem cbThamSoPhucHoiTheoTG;
        private DevExpress.XtraBars.BarButtonItem btnTaoDeviceSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ProgressBar progress;
        private DevExpress.XtraEditors.PanelControl pcDateTime;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.DateEdit edDate;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.TimeEdit edTime;
        private DevExpress.XtraBars.BarButtonItem btn_XoaBK;
        private System.Windows.Forms.BindingSource bdsBackupset;
        private BackupRetore.DSTableAdapters.backupsetTableAdapter taBackupset;
        private System.Windows.Forms.BindingSource bdsRestore_id;
        private BackupRetore.DSTableAdapters.restore_idTableAdapter taRestore_id;
    }
}