
namespace shop5
{
    partial class Form3
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
            System.Windows.Forms.Label supplier_NameLabel;
            System.Windows.Forms.Label purchase_NumberLabel;
            System.Windows.Forms.Label delivery_MethodLabel;
            System.Windows.Forms.Label purchase_PriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataSet1 = new shop5.dataSet1();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTableAdapter = new shop5.dataSet1TableAdapters.PurchaseTableAdapter();
            this.tableAdapterManager = new shop5.dataSet1TableAdapters.TableAdapterManager();
            this.purchaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.supplier_NameTextBox = new System.Windows.Forms.TextBox();
            this.purchase_NumberTextBox = new System.Windows.Forms.TextBox();
            this.delivery_MethodTextBox = new System.Windows.Forms.TextBox();
            this.purchase_PriceTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            supplier_NameLabel = new System.Windows.Forms.Label();
            purchase_NumberLabel = new System.Windows.Forms.Label();
            delivery_MethodLabel = new System.Windows.Forms.Label();
            purchase_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).BeginInit();
            this.purchaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_NameLabel
            // 
            supplier_NameLabel.AutoSize = true;
            supplier_NameLabel.Location = new System.Drawing.Point(35, 274);
            supplier_NameLabel.Name = "supplier_NameLabel";
            supplier_NameLabel.Size = new System.Drawing.Size(79, 13);
            supplier_NameLabel.TabIndex = 4;
            supplier_NameLabel.Text = "Supplier Name:";
            // 
            // purchase_NumberLabel
            // 
            purchase_NumberLabel.AutoSize = true;
            purchase_NumberLabel.Location = new System.Drawing.Point(35, 300);
            purchase_NumberLabel.Name = "purchase_NumberLabel";
            purchase_NumberLabel.Size = new System.Drawing.Size(95, 13);
            purchase_NumberLabel.TabIndex = 6;
            purchase_NumberLabel.Text = "Purchase Number:";
            // 
            // delivery_MethodLabel
            // 
            delivery_MethodLabel.AutoSize = true;
            delivery_MethodLabel.Location = new System.Drawing.Point(35, 326);
            delivery_MethodLabel.Name = "delivery_MethodLabel";
            delivery_MethodLabel.Size = new System.Drawing.Size(87, 13);
            delivery_MethodLabel.TabIndex = 8;
            delivery_MethodLabel.Text = "Delivery Method:";
            // 
            // purchase_PriceLabel
            // 
            purchase_PriceLabel.AutoSize = true;
            purchase_PriceLabel.Location = new System.Drawing.Point(35, 352);
            purchase_PriceLabel.Name = "purchase_PriceLabel";
            purchase_PriceLabel.Size = new System.Drawing.Size(82, 13);
            purchase_PriceLabel.TabIndex = 10;
            purchase_PriceLabel.Text = "Purchase Price:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.dataSet1;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_Plumbing_productssTableAdapter = null;
            this.tableAdapterManager.Manufacturer_SupplierTableAdapter = null;
            this.tableAdapterManager.Manufacturer1TableAdapter = null;
            this.tableAdapterManager.Plumbing_products1TableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = this.purchaseTableAdapter;
            this.tableAdapterManager.Sale_plumbing_productsTableAdapter = null;
            this.tableAdapterManager.Sale1TableAdapter = null;
            this.tableAdapterManager.Supplier_PurchaseTableAdapter = null;
            this.tableAdapterManager.supplierrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shop5.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // purchaseBindingNavigator
            // 
            this.purchaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseBindingNavigator.BindingSource = this.purchaseBindingSource;
            this.purchaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseBindingNavigatorSaveItem});
            this.purchaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseBindingNavigator.Name = "purchaseBindingNavigator";
            this.purchaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.purchaseBindingNavigator.TabIndex = 0;
            this.purchaseBindingNavigator.Text = "bindingNavigator1";
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
            // purchaseBindingNavigatorSaveItem
            // 
            this.purchaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseBindingNavigatorSaveItem.Image")));
            this.purchaseBindingNavigatorSaveItem.Name = "purchaseBindingNavigatorSaveItem";
            this.purchaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purchaseBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.purchaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseBindingNavigatorSaveItem_Click);
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AutoGenerateColumns = false;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.purchaseDataGridView.DataSource = this.purchaseBindingSource;
            this.purchaseDataGridView.Location = new System.Drawing.Point(12, 28);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(455, 220);
            this.purchaseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Supplier_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Supplier_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Purchase_Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Purchase_Number";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Purchase_Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Purchase_Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // supplier_NameTextBox
            // 
            this.supplier_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Supplier_Name", true));
            this.supplier_NameTextBox.Location = new System.Drawing.Point(136, 271);
            this.supplier_NameTextBox.Name = "supplier_NameTextBox";
            this.supplier_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplier_NameTextBox.TabIndex = 5;
            // 
            // purchase_NumberTextBox
            // 
            this.purchase_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Purchase_Number", true));
            this.purchase_NumberTextBox.Location = new System.Drawing.Point(136, 297);
            this.purchase_NumberTextBox.Name = "purchase_NumberTextBox";
            this.purchase_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchase_NumberTextBox.TabIndex = 7;
            // 
            // delivery_MethodTextBox
            // 
            this.delivery_MethodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Delivery_Method", true));
            this.delivery_MethodTextBox.Location = new System.Drawing.Point(136, 323);
            this.delivery_MethodTextBox.Name = "delivery_MethodTextBox";
            this.delivery_MethodTextBox.Size = new System.Drawing.Size(100, 20);
            this.delivery_MethodTextBox.TabIndex = 9;
            // 
            // purchase_PriceTextBox
            // 
            this.purchase_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "Purchase_Price", true));
            this.purchase_PriceTextBox.Location = new System.Drawing.Point(136, 349);
            this.purchase_PriceTextBox.Name = "purchase_PriceTextBox";
            this.purchase_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchase_PriceTextBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(376, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "вперед";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(supplier_NameLabel);
            this.Controls.Add(this.supplier_NameTextBox);
            this.Controls.Add(purchase_NumberLabel);
            this.Controls.Add(this.purchase_NumberTextBox);
            this.Controls.Add(delivery_MethodLabel);
            this.Controls.Add(this.delivery_MethodTextBox);
            this.Controls.Add(purchase_PriceLabel);
            this.Controls.Add(this.purchase_PriceTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.purchaseBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).EndInit();
            this.purchaseBindingNavigator.ResumeLayout(false);
            this.purchaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private dataSet1TableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox supplier_NameTextBox;
        private System.Windows.Forms.TextBox purchase_NumberTextBox;
        private System.Windows.Forms.TextBox delivery_MethodTextBox;
        private System.Windows.Forms.TextBox purchase_PriceTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}