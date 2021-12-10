
namespace shop5
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label link_to_the_ProductLabel;
            System.Windows.Forms.Label purchase_PriceLabel;
            System.Windows.Forms.Label selling_PriceLabel;
            System.Windows.Forms.Label number_of_Sales_UnitsLabel;
            System.Windows.Forms.Label product_IDLabel;
            this.dataSet1 = new shop5.dataSet1();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new shop5.dataSet1TableAdapters.WarehouseTableAdapter();
            this.tableAdapterManager = new shop5.dataSet1TableAdapters.TableAdapterManager();
            this.warehouseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.warehouseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.warehouseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link_to_the_ProductTextBox = new System.Windows.Forms.TextBox();
            this.purchase_PriceTextBox = new System.Windows.Forms.TextBox();
            this.selling_PriceTextBox = new System.Windows.Forms.TextBox();
            this.number_of_Sales_UnitsTextBox = new System.Windows.Forms.TextBox();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            link_to_the_ProductLabel = new System.Windows.Forms.Label();
            purchase_PriceLabel = new System.Windows.Forms.Label();
            selling_PriceLabel = new System.Windows.Forms.Label();
            number_of_Sales_UnitsLabel = new System.Windows.Forms.Label();
            product_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingNavigator)).BeginInit();
            this.warehouseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.dataSet1;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.supplierrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shop5.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseTableAdapter = this.warehouseTableAdapter;
            // 
            // warehouseBindingNavigator
            // 
            this.warehouseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.warehouseBindingNavigator.BindingSource = this.warehouseBindingSource;
            this.warehouseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.warehouseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.warehouseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.warehouseBindingNavigatorSaveItem});
            this.warehouseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.warehouseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.warehouseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.warehouseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.warehouseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.warehouseBindingNavigator.Name = "warehouseBindingNavigator";
            this.warehouseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.warehouseBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.warehouseBindingNavigator.TabIndex = 0;
            this.warehouseBindingNavigator.Text = "bindingNavigator1";
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
            // warehouseBindingNavigatorSaveItem
            // 
            this.warehouseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.warehouseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("warehouseBindingNavigatorSaveItem.Image")));
            this.warehouseBindingNavigatorSaveItem.Name = "warehouseBindingNavigatorSaveItem";
            this.warehouseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.warehouseBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.warehouseBindingNavigatorSaveItem.Click += new System.EventHandler(this.warehouseBindingNavigatorSaveItem_Click);
            // 
            // warehouseDataGridView
            // 
            this.warehouseDataGridView.AutoGenerateColumns = false;
            this.warehouseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.warehouseDataGridView.DataSource = this.warehouseBindingSource;
            this.warehouseDataGridView.Location = new System.Drawing.Point(19, 27);
            this.warehouseDataGridView.Name = "warehouseDataGridView";
            this.warehouseDataGridView.Size = new System.Drawing.Size(549, 220);
            this.warehouseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Link_to_the_Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "Link_to_the_Product";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Purchase_Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Purchase_Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Selling_Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Selling_Price";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // link_to_the_ProductLabel
            // 
            link_to_the_ProductLabel.AutoSize = true;
            link_to_the_ProductLabel.Location = new System.Drawing.Point(25, 272);
            link_to_the_ProductLabel.Name = "link_to_the_ProductLabel";
            link_to_the_ProductLabel.Size = new System.Drawing.Size(100, 13);
            link_to_the_ProductLabel.TabIndex = 2;
            link_to_the_ProductLabel.Text = "Link to the Product:";
            // 
            // link_to_the_ProductTextBox
            // 
            this.link_to_the_ProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehouseBindingSource, "Link_to_the_Product", true));
            this.link_to_the_ProductTextBox.Location = new System.Drawing.Point(146, 269);
            this.link_to_the_ProductTextBox.Name = "link_to_the_ProductTextBox";
            this.link_to_the_ProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.link_to_the_ProductTextBox.TabIndex = 3;
            // 
            // purchase_PriceLabel
            // 
            purchase_PriceLabel.AutoSize = true;
            purchase_PriceLabel.Location = new System.Drawing.Point(25, 298);
            purchase_PriceLabel.Name = "purchase_PriceLabel";
            purchase_PriceLabel.Size = new System.Drawing.Size(82, 13);
            purchase_PriceLabel.TabIndex = 4;
            purchase_PriceLabel.Text = "Purchase Price:";
            // 
            // purchase_PriceTextBox
            // 
            this.purchase_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehouseBindingSource, "Purchase_Price", true));
            this.purchase_PriceTextBox.Location = new System.Drawing.Point(146, 295);
            this.purchase_PriceTextBox.Name = "purchase_PriceTextBox";
            this.purchase_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchase_PriceTextBox.TabIndex = 5;
            // 
            // selling_PriceLabel
            // 
            selling_PriceLabel.AutoSize = true;
            selling_PriceLabel.Location = new System.Drawing.Point(25, 324);
            selling_PriceLabel.Name = "selling_PriceLabel";
            selling_PriceLabel.Size = new System.Drawing.Size(68, 13);
            selling_PriceLabel.TabIndex = 6;
            selling_PriceLabel.Text = "Selling Price:";
            // 
            // selling_PriceTextBox
            // 
            this.selling_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehouseBindingSource, "Selling_Price", true));
            this.selling_PriceTextBox.Location = new System.Drawing.Point(146, 321);
            this.selling_PriceTextBox.Name = "selling_PriceTextBox";
            this.selling_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.selling_PriceTextBox.TabIndex = 7;
            // 
            // number_of_Sales_UnitsLabel
            // 
            number_of_Sales_UnitsLabel.AutoSize = true;
            number_of_Sales_UnitsLabel.Location = new System.Drawing.Point(25, 350);
            number_of_Sales_UnitsLabel.Name = "number_of_Sales_UnitsLabel";
            number_of_Sales_UnitsLabel.Size = new System.Drawing.Size(115, 13);
            number_of_Sales_UnitsLabel.TabIndex = 8;
            number_of_Sales_UnitsLabel.Text = "Number of Sales Units:";
            // 
            // number_of_Sales_UnitsTextBox
            // 
            this.number_of_Sales_UnitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehouseBindingSource, "Number_of_Sales_Units", true));
            this.number_of_Sales_UnitsTextBox.Location = new System.Drawing.Point(146, 347);
            this.number_of_Sales_UnitsTextBox.Name = "number_of_Sales_UnitsTextBox";
            this.number_of_Sales_UnitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.number_of_Sales_UnitsTextBox.TabIndex = 9;
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(25, 376);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(61, 13);
            product_IDLabel.TabIndex = 10;
            product_IDLabel.Text = "Product ID:";
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehouseBindingSource, "Product_ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(146, 373);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_IDTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(469, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "вперед";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(link_to_the_ProductLabel);
            this.Controls.Add(this.link_to_the_ProductTextBox);
            this.Controls.Add(purchase_PriceLabel);
            this.Controls.Add(this.purchase_PriceTextBox);
            this.Controls.Add(selling_PriceLabel);
            this.Controls.Add(this.selling_PriceTextBox);
            this.Controls.Add(number_of_Sales_UnitsLabel);
            this.Controls.Add(this.number_of_Sales_UnitsTextBox);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDTextBox);
            this.Controls.Add(this.warehouseDataGridView);
            this.Controls.Add(this.warehouseBindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingNavigator)).EndInit();
            this.warehouseBindingNavigator.ResumeLayout(false);
            this.warehouseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private dataSet1TableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator warehouseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton warehouseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView warehouseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox link_to_the_ProductTextBox;
        private System.Windows.Forms.TextBox purchase_PriceTextBox;
        private System.Windows.Forms.TextBox selling_PriceTextBox;
        private System.Windows.Forms.TextBox number_of_Sales_UnitsTextBox;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}