
namespace shop5
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label sales_NumberLabel;
            System.Windows.Forms.Label delivery_MethodLabel;
            System.Windows.Forms.Label number_of_Sales_UnitsLabel;
            System.Windows.Forms.Label selling_PriceLabel;
            System.Windows.Forms.Label name_of_ShopLabel;
            this.dataSet1 = new shop5.dataSet1();
            this.sale1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale1TableAdapter = new shop5.dataSet1TableAdapters.Sale1TableAdapter();
            this.tableAdapterManager = new shop5.dataSet1TableAdapters.TableAdapterManager();
            this.sale1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sale1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sale1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.sales_NumberTextBox = new System.Windows.Forms.TextBox();
            this.delivery_MethodTextBox = new System.Windows.Forms.TextBox();
            this.number_of_Sales_UnitsTextBox = new System.Windows.Forms.TextBox();
            this.selling_PriceTextBox = new System.Windows.Forms.TextBox();
            this.name_of_ShopTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            product_NameLabel = new System.Windows.Forms.Label();
            sales_NumberLabel = new System.Windows.Forms.Label();
            delivery_MethodLabel = new System.Windows.Forms.Label();
            number_of_Sales_UnitsLabel = new System.Windows.Forms.Label();
            selling_PriceLabel = new System.Windows.Forms.Label();
            name_of_ShopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingNavigator)).BeginInit();
            this.sale1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sale1BindingSource
            // 
            this.sale1BindingSource.DataMember = "Sale1";
            this.sale1BindingSource.DataSource = this.dataSet1;
            // 
            // sale1TableAdapter
            // 
            this.sale1TableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Sale1TableAdapter = this.sale1TableAdapter;
            this.tableAdapterManager.Supplier_PurchaseTableAdapter = null;
            this.tableAdapterManager.supplierrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shop5.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // sale1BindingNavigator
            // 
            this.sale1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sale1BindingNavigator.BindingSource = this.sale1BindingSource;
            this.sale1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sale1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sale1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sale1BindingNavigatorSaveItem});
            this.sale1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sale1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sale1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sale1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sale1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sale1BindingNavigator.Name = "sale1BindingNavigator";
            this.sale1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sale1BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.sale1BindingNavigator.TabIndex = 0;
            this.sale1BindingNavigator.Text = "bindingNavigator1";
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
            // sale1BindingNavigatorSaveItem
            // 
            this.sale1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sale1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sale1BindingNavigatorSaveItem.Image")));
            this.sale1BindingNavigatorSaveItem.Name = "sale1BindingNavigatorSaveItem";
            this.sale1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sale1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sale1BindingNavigatorSaveItem.Click += new System.EventHandler(this.sale1BindingNavigatorSaveItem_Click);
            // 
            // sale1DataGridView
            // 
            this.sale1DataGridView.AutoGenerateColumns = false;
            this.sale1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sale1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sale1DataGridView.DataSource = this.sale1BindingSource;
            this.sale1DataGridView.Location = new System.Drawing.Point(35, 30);
            this.sale1DataGridView.Name = "sale1DataGridView";
            this.sale1DataGridView.Size = new System.Drawing.Size(541, 220);
            this.sale1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Sales_Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sales_Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Delivery_Method";
            this.dataGridViewTextBoxColumn3.HeaderText = "Delivery_Method";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Number_of_Sales_Units";
            this.dataGridViewTextBoxColumn4.HeaderText = "Number_of_Sales_Units";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Selling_Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Selling_Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name_of_Shop";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name_of_Shop";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(39, 277);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 2;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale1BindingSource, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(160, 274);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_NameTextBox.TabIndex = 3;
            // 
            // sales_NumberLabel
            // 
            sales_NumberLabel.AutoSize = true;
            sales_NumberLabel.Location = new System.Drawing.Point(39, 303);
            sales_NumberLabel.Name = "sales_NumberLabel";
            sales_NumberLabel.Size = new System.Drawing.Size(76, 13);
            sales_NumberLabel.TabIndex = 4;
            sales_NumberLabel.Text = "Sales Number:";
            // 
            // sales_NumberTextBox
            // 
            this.sales_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale1BindingSource, "Sales_Number", true));
            this.sales_NumberTextBox.Location = new System.Drawing.Point(160, 300);
            this.sales_NumberTextBox.Name = "sales_NumberTextBox";
            this.sales_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.sales_NumberTextBox.TabIndex = 5;
            // 
            // delivery_MethodLabel
            // 
            delivery_MethodLabel.AutoSize = true;
            delivery_MethodLabel.Location = new System.Drawing.Point(39, 329);
            delivery_MethodLabel.Name = "delivery_MethodLabel";
            delivery_MethodLabel.Size = new System.Drawing.Size(87, 13);
            delivery_MethodLabel.TabIndex = 6;
            delivery_MethodLabel.Text = "Delivery Method:";
            // 
            // delivery_MethodTextBox
            // 
            this.delivery_MethodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale1BindingSource, "Delivery_Method", true));
            this.delivery_MethodTextBox.Location = new System.Drawing.Point(160, 326);
            this.delivery_MethodTextBox.Name = "delivery_MethodTextBox";
            this.delivery_MethodTextBox.Size = new System.Drawing.Size(100, 20);
            this.delivery_MethodTextBox.TabIndex = 7;
            // 
            // number_of_Sales_UnitsLabel
            // 
            number_of_Sales_UnitsLabel.AutoSize = true;
            number_of_Sales_UnitsLabel.Location = new System.Drawing.Point(39, 355);
            number_of_Sales_UnitsLabel.Name = "number_of_Sales_UnitsLabel";
            number_of_Sales_UnitsLabel.Size = new System.Drawing.Size(115, 13);
            number_of_Sales_UnitsLabel.TabIndex = 8;
            number_of_Sales_UnitsLabel.Text = "Number of Sales Units:";
            // 
            // number_of_Sales_UnitsTextBox
            // 
            this.number_of_Sales_UnitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale1BindingSource, "Number_of_Sales_Units", true));
            this.number_of_Sales_UnitsTextBox.Location = new System.Drawing.Point(160, 352);
            this.number_of_Sales_UnitsTextBox.Name = "number_of_Sales_UnitsTextBox";
            this.number_of_Sales_UnitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.number_of_Sales_UnitsTextBox.TabIndex = 9;
            // 
            // selling_PriceLabel
            // 
            selling_PriceLabel.AutoSize = true;
            selling_PriceLabel.Location = new System.Drawing.Point(39, 381);
            selling_PriceLabel.Name = "selling_PriceLabel";
            selling_PriceLabel.Size = new System.Drawing.Size(68, 13);
            selling_PriceLabel.TabIndex = 10;
            selling_PriceLabel.Text = "Selling Price:";
            // 
            // selling_PriceTextBox
            // 
            this.selling_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale1BindingSource, "Selling_Price", true));
            this.selling_PriceTextBox.Location = new System.Drawing.Point(160, 378);
            this.selling_PriceTextBox.Name = "selling_PriceTextBox";
            this.selling_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.selling_PriceTextBox.TabIndex = 11;
            // 
            // name_of_ShopLabel
            // 
            name_of_ShopLabel.AutoSize = true;
            name_of_ShopLabel.Location = new System.Drawing.Point(39, 407);
            name_of_ShopLabel.Name = "name_of_ShopLabel";
            name_of_ShopLabel.Size = new System.Drawing.Size(78, 13);
            name_of_ShopLabel.TabIndex = 12;
            name_of_ShopLabel.Text = "Name of Shop:";
            // 
            // name_of_ShopTextBox
            // 
            this.name_of_ShopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale1BindingSource, "Name_of_Shop", true));
            this.name_of_ShopTextBox.Location = new System.Drawing.Point(160, 404);
            this.name_of_ShopTextBox.Name = "name_of_ShopTextBox";
            this.name_of_ShopTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_of_ShopTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "вперед";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(sales_NumberLabel);
            this.Controls.Add(this.sales_NumberTextBox);
            this.Controls.Add(delivery_MethodLabel);
            this.Controls.Add(this.delivery_MethodTextBox);
            this.Controls.Add(number_of_Sales_UnitsLabel);
            this.Controls.Add(this.number_of_Sales_UnitsTextBox);
            this.Controls.Add(selling_PriceLabel);
            this.Controls.Add(this.selling_PriceTextBox);
            this.Controls.Add(name_of_ShopLabel);
            this.Controls.Add(this.name_of_ShopTextBox);
            this.Controls.Add(this.sale1DataGridView);
            this.Controls.Add(this.sale1BindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1BindingNavigator)).EndInit();
            this.sale1BindingNavigator.ResumeLayout(false);
            this.sale1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sale1BindingSource;
        private dataSet1TableAdapters.Sale1TableAdapter sale1TableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sale1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sale1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sale1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox sales_NumberTextBox;
        private System.Windows.Forms.TextBox delivery_MethodTextBox;
        private System.Windows.Forms.TextBox number_of_Sales_UnitsTextBox;
        private System.Windows.Forms.TextBox selling_PriceTextBox;
        private System.Windows.Forms.TextBox name_of_ShopTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}