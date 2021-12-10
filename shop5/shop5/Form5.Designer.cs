
namespace shop5
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label supplier_NameLabel;
            System.Windows.Forms.Label contact_NumberLabel;
            System.Windows.Forms.Label contact_PersonLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label supplier_IDLabel;
            this.dataSet1 = new shop5.dataSet1();
            this.supplierrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierrTableAdapter = new shop5.dataSet1TableAdapters.supplierrTableAdapter();
            this.tableAdapterManager = new shop5.dataSet1TableAdapters.TableAdapterManager();
            this.supplierrBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.supplierrBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supplierrDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_NameTextBox = new System.Windows.Forms.TextBox();
            this.contact_NumberTextBox = new System.Windows.Forms.TextBox();
            this.contact_PersonTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.supplier_IDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            supplier_NameLabel = new System.Windows.Forms.Label();
            contact_NumberLabel = new System.Windows.Forms.Label();
            contact_PersonLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            supplier_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierrBindingNavigator)).BeginInit();
            this.supplierrBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierrDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierrBindingSource
            // 
            this.supplierrBindingSource.DataMember = "supplierr";
            this.supplierrBindingSource.DataSource = this.dataSet1;
            // 
            // supplierrTableAdapter
            // 
            this.supplierrTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_Plumbing_productssTableAdapter = null;
            this.tableAdapterManager.Manufacturer_SupplierTableAdapter = null;
            this.tableAdapterManager.Manufacturer1TableAdapter = null;
            this.tableAdapterManager.Plumbing_products1TableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.Sale_plumbing_productsTableAdapter = null;
            this.tableAdapterManager.Sale1TableAdapter = null;
            this.tableAdapterManager.Supplier_PurchaseTableAdapter = null;
            this.tableAdapterManager.supplierrTableAdapter = this.supplierrTableAdapter;
            this.tableAdapterManager.UpdateOrder = shop5.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // supplierrBindingNavigator
            // 
            this.supplierrBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplierrBindingNavigator.BindingSource = this.supplierrBindingSource;
            this.supplierrBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplierrBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplierrBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplierrBindingNavigatorSaveItem});
            this.supplierrBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplierrBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplierrBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplierrBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplierrBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplierrBindingNavigator.Name = "supplierrBindingNavigator";
            this.supplierrBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplierrBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.supplierrBindingNavigator.TabIndex = 0;
            this.supplierrBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // supplierrBindingNavigatorSaveItem
            // 
            this.supplierrBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplierrBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierrBindingNavigatorSaveItem.Image")));
            this.supplierrBindingNavigatorSaveItem.Name = "supplierrBindingNavigatorSaveItem";
            this.supplierrBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.supplierrBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.supplierrBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplierrBindingNavigatorSaveItem_Click);
            // 
            // supplierrDataGridView
            // 
            this.supplierrDataGridView.AutoGenerateColumns = false;
            this.supplierrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.supplierrDataGridView.DataSource = this.supplierrBindingSource;
            this.supplierrDataGridView.Location = new System.Drawing.Point(12, 28);
            this.supplierrDataGridView.Name = "supplierrDataGridView";
            this.supplierrDataGridView.Size = new System.Drawing.Size(637, 220);
            this.supplierrDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Supplier_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Supplier_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn4.HeaderText = "Country";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn6.HeaderText = "Street";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn7.HeaderText = "House";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Supplier_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Supplier_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // supplier_NameLabel
            // 
            supplier_NameLabel.AutoSize = true;
            supplier_NameLabel.Location = new System.Drawing.Point(19, 267);
            supplier_NameLabel.Name = "supplier_NameLabel";
            supplier_NameLabel.Size = new System.Drawing.Size(79, 13);
            supplier_NameLabel.TabIndex = 2;
            supplier_NameLabel.Text = "Supplier Name:";
            // 
            // supplier_NameTextBox
            // 
            this.supplier_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "Supplier_Name", true));
            this.supplier_NameTextBox.Location = new System.Drawing.Point(112, 264);
            this.supplier_NameTextBox.Name = "supplier_NameTextBox";
            this.supplier_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplier_NameTextBox.TabIndex = 3;
            // 
            // contact_NumberLabel
            // 
            contact_NumberLabel.AutoSize = true;
            contact_NumberLabel.Location = new System.Drawing.Point(19, 293);
            contact_NumberLabel.Name = "contact_NumberLabel";
            contact_NumberLabel.Size = new System.Drawing.Size(87, 13);
            contact_NumberLabel.TabIndex = 4;
            contact_NumberLabel.Text = "Contact Number:";
            // 
            // contact_NumberTextBox
            // 
            this.contact_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "Contact_Number", true));
            this.contact_NumberTextBox.Location = new System.Drawing.Point(112, 290);
            this.contact_NumberTextBox.Name = "contact_NumberTextBox";
            this.contact_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_NumberTextBox.TabIndex = 5;
            // 
            // contact_PersonLabel
            // 
            contact_PersonLabel.AutoSize = true;
            contact_PersonLabel.Location = new System.Drawing.Point(19, 319);
            contact_PersonLabel.Name = "contact_PersonLabel";
            contact_PersonLabel.Size = new System.Drawing.Size(83, 13);
            contact_PersonLabel.TabIndex = 6;
            contact_PersonLabel.Text = "Contact Person:";
            // 
            // contact_PersonTextBox
            // 
            this.contact_PersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "Contact_Person", true));
            this.contact_PersonTextBox.Location = new System.Drawing.Point(112, 316);
            this.contact_PersonTextBox.Name = "contact_PersonTextBox";
            this.contact_PersonTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_PersonTextBox.TabIndex = 7;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(19, 345);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 8;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(112, 342);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 9;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(19, 371);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 10;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(112, 368);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 11;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(19, 397);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 12;
            streetLabel.Text = "Street:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(112, 394);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 13;
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(19, 423);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(41, 13);
            houseLabel.TabIndex = 14;
            houseLabel.Text = "House:";
            // 
            // houseTextBox
            // 
            this.houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "House", true));
            this.houseTextBox.Location = new System.Drawing.Point(112, 420);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(100, 20);
            this.houseTextBox.TabIndex = 15;
            // 
            // supplier_IDLabel
            // 
            supplier_IDLabel.AutoSize = true;
            supplier_IDLabel.Location = new System.Drawing.Point(19, 449);
            supplier_IDLabel.Name = "supplier_IDLabel";
            supplier_IDLabel.Size = new System.Drawing.Size(62, 13);
            supplier_IDLabel.TabIndex = 16;
            supplier_IDLabel.Text = "Supplier ID:";
            // 
            // supplier_IDTextBox
            // 
            this.supplier_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierrBindingSource, "Supplier_ID", true));
            this.supplier_IDTextBox.Location = new System.Drawing.Point(112, 446);
            this.supplier_IDTextBox.Name = "supplier_IDTextBox";
            this.supplier_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplier_IDTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(491, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "вперед";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(supplier_NameLabel);
            this.Controls.Add(this.supplier_NameTextBox);
            this.Controls.Add(contact_NumberLabel);
            this.Controls.Add(this.contact_NumberTextBox);
            this.Controls.Add(contact_PersonLabel);
            this.Controls.Add(this.contact_PersonTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(houseLabel);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(supplier_IDLabel);
            this.Controls.Add(this.supplier_IDTextBox);
            this.Controls.Add(this.supplierrDataGridView);
            this.Controls.Add(this.supplierrBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierrBindingNavigator)).EndInit();
            this.supplierrBindingNavigator.ResumeLayout(false);
            this.supplierrBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierrDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource supplierrBindingSource;
        private dataSet1TableAdapters.supplierrTableAdapter supplierrTableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplierrBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplierrBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView supplierrDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox supplier_NameTextBox;
        private System.Windows.Forms.TextBox contact_NumberTextBox;
        private System.Windows.Forms.TextBox contact_PersonTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox supplier_IDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}