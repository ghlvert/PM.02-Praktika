
namespace shop5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label contact_NumberLabel;
            System.Windows.Forms.Label contact_PersonLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label manufacturer_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new shop5.dataSet1();
            this.manufacturer1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturer1TableAdapter = new shop5.dataSet1TableAdapters.Manufacturer1TableAdapter();
            this.tableAdapterManager = new shop5.dataSet1TableAdapters.TableAdapterManager();
            this.manufacturer1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.manufacturer1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.manufacturer1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.contact_NumberTextBox = new System.Windows.Forms.TextBox();
            this.contact_PersonTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.manufacturer_NameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            product_IDLabel = new System.Windows.Forms.Label();
            contact_NumberLabel = new System.Windows.Forms.Label();
            contact_PersonLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            manufacturer_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer1BindingNavigator)).BeginInit();
            this.manufacturer1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(39, 273);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(61, 13);
            product_IDLabel.TabIndex = 2;
            product_IDLabel.Text = "Product ID:";
            // 
            // contact_NumberLabel
            // 
            contact_NumberLabel.AutoSize = true;
            contact_NumberLabel.Location = new System.Drawing.Point(39, 299);
            contact_NumberLabel.Name = "contact_NumberLabel";
            contact_NumberLabel.Size = new System.Drawing.Size(87, 13);
            contact_NumberLabel.TabIndex = 4;
            contact_NumberLabel.Text = "Contact Number:";
            // 
            // contact_PersonLabel
            // 
            contact_PersonLabel.AutoSize = true;
            contact_PersonLabel.Location = new System.Drawing.Point(39, 325);
            contact_PersonLabel.Name = "contact_PersonLabel";
            contact_PersonLabel.Size = new System.Drawing.Size(83, 13);
            contact_PersonLabel.TabIndex = 6;
            contact_PersonLabel.Text = "Contact Person:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(39, 351);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 8;
            product_NameLabel.Text = "Product Name:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(39, 377);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 10;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(39, 403);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 12;
            cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(39, 429);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 14;
            streetLabel.Text = "Street:";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(39, 455);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(41, 13);
            houseLabel.TabIndex = 16;
            houseLabel.Text = "House:";
            // 
            // manufacturer_NameLabel
            // 
            manufacturer_NameLabel.AutoSize = true;
            manufacturer_NameLabel.Location = new System.Drawing.Point(39, 481);
            manufacturer_NameLabel.Name = "manufacturer_NameLabel";
            manufacturer_NameLabel.Size = new System.Drawing.Size(104, 13);
            manufacturer_NameLabel.TabIndex = 18;
            manufacturer_NameLabel.Text = "Manufacturer Name:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturer1BindingSource
            // 
            this.manufacturer1BindingSource.DataMember = "Manufacturer1";
            this.manufacturer1BindingSource.DataSource = this.dataSet1;
            // 
            // manufacturer1TableAdapter
            // 
            this.manufacturer1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_Plumbing_productssTableAdapter = null;
            this.tableAdapterManager.Manufacturer_SupplierTableAdapter = null;
            this.tableAdapterManager.Manufacturer1TableAdapter = this.manufacturer1TableAdapter;
            this.tableAdapterManager.Plumbing_products1TableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.Sale_plumbing_productsTableAdapter = null;
            this.tableAdapterManager.Sale1TableAdapter = null;
            this.tableAdapterManager.Supplier_PurchaseTableAdapter = null;
            this.tableAdapterManager.supplierrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shop5.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // manufacturer1BindingNavigator
            // 
            this.manufacturer1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manufacturer1BindingNavigator.BindingSource = this.manufacturer1BindingSource;
            this.manufacturer1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manufacturer1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manufacturer1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.manufacturer1BindingNavigatorSaveItem});
            this.manufacturer1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manufacturer1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manufacturer1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manufacturer1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manufacturer1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manufacturer1BindingNavigator.Name = "manufacturer1BindingNavigator";
            this.manufacturer1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manufacturer1BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.manufacturer1BindingNavigator.TabIndex = 0;
            this.manufacturer1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // manufacturer1BindingNavigatorSaveItem
            // 
            this.manufacturer1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manufacturer1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manufacturer1BindingNavigatorSaveItem.Image")));
            this.manufacturer1BindingNavigatorSaveItem.Name = "manufacturer1BindingNavigatorSaveItem";
            this.manufacturer1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.manufacturer1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.manufacturer1BindingNavigatorSaveItem.Click += new System.EventHandler(this.manufacturer1BindingNavigatorSaveItem_Click);
            // 
            // manufacturer1DataGridView
            // 
            this.manufacturer1DataGridView.AutoGenerateColumns = false;
            this.manufacturer1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturer1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.manufacturer1DataGridView.DataSource = this.manufacturer1BindingSource;
            this.manufacturer1DataGridView.Location = new System.Drawing.Point(12, 28);
            this.manufacturer1DataGridView.Name = "manufacturer1DataGridView";
            this.manufacturer1DataGridView.Size = new System.Drawing.Size(635, 207);
            this.manufacturer1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Contact_Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Contact_Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Contact_Person";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contact_Person";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn5.HeaderText = "Country";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn7.HeaderText = "Street";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn8.HeaderText = "House";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Manufacturer_Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Manufacturer_Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "Product_ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(149, 270);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_IDTextBox.TabIndex = 3;
            // 
            // contact_NumberTextBox
            // 
            this.contact_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "Contact_Number", true));
            this.contact_NumberTextBox.Location = new System.Drawing.Point(149, 296);
            this.contact_NumberTextBox.Name = "contact_NumberTextBox";
            this.contact_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_NumberTextBox.TabIndex = 5;
            // 
            // contact_PersonTextBox
            // 
            this.contact_PersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "Contact_Person", true));
            this.contact_PersonTextBox.Location = new System.Drawing.Point(149, 322);
            this.contact_PersonTextBox.Name = "contact_PersonTextBox";
            this.contact_PersonTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_PersonTextBox.TabIndex = 7;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(149, 348);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_NameTextBox.TabIndex = 9;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(149, 374);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 11;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(149, 400);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 13;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(149, 426);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 15;
            // 
            // houseTextBox
            // 
            this.houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "House", true));
            this.houseTextBox.Location = new System.Drawing.Point(149, 452);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(100, 20);
            this.houseTextBox.TabIndex = 17;
            // 
            // manufacturer_NameTextBox
            // 
            this.manufacturer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer1BindingSource, "Manufacturer_Name", true));
            this.manufacturer_NameTextBox.Location = new System.Drawing.Point(149, 478);
            this.manufacturer_NameTextBox.Name = "manufacturer_NameTextBox";
            this.manufacturer_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturer_NameTextBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "вперед";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDTextBox);
            this.Controls.Add(contact_NumberLabel);
            this.Controls.Add(this.contact_NumberTextBox);
            this.Controls.Add(contact_PersonLabel);
            this.Controls.Add(this.contact_PersonTextBox);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(houseLabel);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(manufacturer_NameLabel);
            this.Controls.Add(this.manufacturer_NameTextBox);
            this.Controls.Add(this.manufacturer1DataGridView);
            this.Controls.Add(this.manufacturer1BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer1BindingNavigator)).EndInit();
            this.manufacturer1BindingNavigator.ResumeLayout(false);
            this.manufacturer1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource manufacturer1BindingSource;
        private dataSet1TableAdapters.Manufacturer1TableAdapter manufacturer1TableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manufacturer1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton manufacturer1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView manufacturer1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox contact_NumberTextBox;
        private System.Windows.Forms.TextBox contact_PersonTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox manufacturer_NameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

