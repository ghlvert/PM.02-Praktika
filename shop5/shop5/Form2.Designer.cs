
namespace shop5
{
    partial class Form2
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
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label sizeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataSet1 = new shop5.dataSet1();
            this.plumbing_products1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plumbing_products1TableAdapter = new shop5.dataSet1TableAdapters.Plumbing_products1TableAdapter();
            this.tableAdapterManager = new shop5.dataSet1TableAdapters.TableAdapterManager();
            this.plumbing_products1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.plumbing_products1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.plumbing_products1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            product_IDLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumbing_products1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumbing_products1BindingNavigator)).BeginInit();
            this.plumbing_products1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plumbing_products1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(31, 272);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(61, 13);
            product_IDLabel.TabIndex = 2;
            product_IDLabel.Text = "Product ID:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(31, 298);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 4;
            product_NameLabel.Text = "Product Name:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(31, 324);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(47, 13);
            materialLabel.TabIndex = 6;
            materialLabel.Text = "Material:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(31, 350);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 8;
            typeLabel.Text = "Type:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(31, 376);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 10;
            sizeLabel.Text = "Size:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plumbing_products1BindingSource
            // 
            this.plumbing_products1BindingSource.DataMember = "Plumbing_products1";
            this.plumbing_products1BindingSource.DataSource = this.dataSet1;
            // 
            // plumbing_products1TableAdapter
            // 
            this.plumbing_products1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_Plumbing_productssTableAdapter = null;
            this.tableAdapterManager.Manufacturer_SupplierTableAdapter = null;
            this.tableAdapterManager.Manufacturer1TableAdapter = null;
            this.tableAdapterManager.Plumbing_products1TableAdapter = this.plumbing_products1TableAdapter;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.Sale_plumbing_productsTableAdapter = null;
            this.tableAdapterManager.Sale1TableAdapter = null;
            this.tableAdapterManager.Supplier_PurchaseTableAdapter = null;
            this.tableAdapterManager.supplierrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shop5.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // plumbing_products1BindingNavigator
            // 
            this.plumbing_products1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plumbing_products1BindingNavigator.BindingSource = this.plumbing_products1BindingSource;
            this.plumbing_products1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plumbing_products1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plumbing_products1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.plumbing_products1BindingNavigatorSaveItem});
            this.plumbing_products1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.plumbing_products1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plumbing_products1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plumbing_products1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plumbing_products1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plumbing_products1BindingNavigator.Name = "plumbing_products1BindingNavigator";
            this.plumbing_products1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plumbing_products1BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.plumbing_products1BindingNavigator.TabIndex = 0;
            this.plumbing_products1BindingNavigator.Text = "bindingNavigator1";
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
            // plumbing_products1BindingNavigatorSaveItem
            // 
            this.plumbing_products1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plumbing_products1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plumbing_products1BindingNavigatorSaveItem.Image")));
            this.plumbing_products1BindingNavigatorSaveItem.Name = "plumbing_products1BindingNavigatorSaveItem";
            this.plumbing_products1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.plumbing_products1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.plumbing_products1BindingNavigatorSaveItem.Click += new System.EventHandler(this.plumbing_products1BindingNavigatorSaveItem_Click);
            // 
            // plumbing_products1DataGridView
            // 
            this.plumbing_products1DataGridView.AutoGenerateColumns = false;
            this.plumbing_products1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plumbing_products1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.plumbing_products1DataGridView.DataSource = this.plumbing_products1BindingSource;
            this.plumbing_products1DataGridView.Location = new System.Drawing.Point(20, 26);
            this.plumbing_products1DataGridView.Name = "plumbing_products1DataGridView";
            this.plumbing_products1DataGridView.Size = new System.Drawing.Size(545, 220);
            this.plumbing_products1DataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn3.HeaderText = "Material";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn5.HeaderText = "Size";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plumbing_products1BindingSource, "Product_ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(115, 269);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_IDTextBox.TabIndex = 3;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plumbing_products1BindingSource, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(115, 295);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_NameTextBox.TabIndex = 5;
            // 
            // materialTextBox
            // 
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plumbing_products1BindingSource, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(115, 321);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialTextBox.TabIndex = 7;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plumbing_products1BindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(115, 347);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 9;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plumbing_products1BindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(115, 373);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "вперед";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDTextBox);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(materialLabel);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.plumbing_products1DataGridView);
            this.Controls.Add(this.plumbing_products1BindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumbing_products1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plumbing_products1BindingNavigator)).EndInit();
            this.plumbing_products1BindingNavigator.ResumeLayout(false);
            this.plumbing_products1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plumbing_products1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource plumbing_products1BindingSource;
        private dataSet1TableAdapters.Plumbing_products1TableAdapter plumbing_products1TableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plumbing_products1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton plumbing_products1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView plumbing_products1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}