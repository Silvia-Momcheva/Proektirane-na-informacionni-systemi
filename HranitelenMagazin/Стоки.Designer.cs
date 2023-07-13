namespace HranitelenMagazin
{
    partial class Стоки
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
            System.Windows.Forms.Label код_стокаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Стоки));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hranitelenMagazinDataSet = new HranitelenMagazin.HranitelenMagazinDataSet();
            this.стокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стокиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.СтокиTableAdapter();
            this.tableAdapterManager = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.TableAdapterManager();
            this.стокиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.стокиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.стокиMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.доставкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.категориястокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маркаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.име_на_стокаTextBox = new System.Windows.Forms.TextBox();
            this.доставкаTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.ДоставкаTableAdapter();
            this.категория_стокиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.Категория_стокиTableAdapter();
            this.маркаTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.МаркаTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_доставка = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_стокаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingNavigator)).BeginInit();
            this.стокиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.стокиMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориястокиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маркаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_стокаLabel
            // 
            код_стокаLabel.AutoSize = true;
            код_стокаLabel.Location = new System.Drawing.Point(71, 137);
            код_стокаLabel.Name = "код_стокаLabel";
            код_стокаLabel.Size = new System.Drawing.Size(100, 17);
            код_стокаLabel.TabIndex = 5;
            код_стокаLabel.Text = "Име на стока:";
            // 
            // hranitelenMagazinDataSet
            // 
            this.hranitelenMagazinDataSet.DataSetName = "HranitelenMagazinDataSet";
            this.hranitelenMagazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стокиBindingSource
            // 
            this.стокиBindingSource.DataMember = "Стоки";
            this.стокиBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // стокиTableAdapter
            // 
            this.стокиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоставкаTableAdapter = null;
            this.tableAdapterManager.ДоставчикTableAdapter = null;
            this.tableAdapterManager.Заявка_към_доставчикTableAdapter = null;
            this.tableAdapterManager.Категория_стокиTableAdapter = null;
            this.tableAdapterManager.МаркаTableAdapter = null;
            this.tableAdapterManager.ПродажбиTableAdapter = null;
            this.tableAdapterManager.СлужителиTableAdapter = null;
            this.tableAdapterManager.Стока_ДоставкаTableAdapter = null;
            this.tableAdapterManager.Стока_ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Стоки_ПродажбиTableAdapter = null;
            this.tableAdapterManager.СтокиTableAdapter = this.стокиTableAdapter;
            // 
            // стокиBindingNavigator
            // 
            this.стокиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.стокиBindingNavigator.BindingSource = this.стокиBindingSource;
            this.стокиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.стокиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.стокиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.стокиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.стокиBindingNavigatorSaveItem});
            this.стокиBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.стокиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.стокиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.стокиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.стокиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.стокиBindingNavigator.Name = "стокиBindingNavigator";
            this.стокиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.стокиBindingNavigator.Size = new System.Drawing.Size(884, 27);
            this.стокиBindingNavigator.TabIndex = 0;
            this.стокиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // стокиBindingNavigatorSaveItem
            // 
            this.стокиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.стокиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("стокиBindingNavigatorSaveItem.Image")));
            this.стокиBindingNavigatorSaveItem.Name = "стокиBindingNavigatorSaveItem";
            this.стокиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.стокиBindingNavigatorSaveItem.Text = "Save Data";
            this.стокиBindingNavigatorSaveItem.Click += new System.EventHandler(this.стокиBindingNavigatorSaveItem_Click);
            // 
            // стокиMetroGrid
            // 
            this.стокиMetroGrid.AllowUserToResizeRows = false;
            this.стокиMetroGrid.AutoGenerateColumns = false;
            this.стокиMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.стокиMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.стокиMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.стокиMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.стокиMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.стокиMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.стокиMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Код_доставка,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.стокиMetroGrid.DataSource = this.стокиBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.стокиMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.стокиMetroGrid.EnableHeadersVisualStyles = false;
            this.стокиMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.стокиMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.стокиMetroGrid.Location = new System.Drawing.Point(20, 227);
            this.стокиMetroGrid.Name = "стокиMetroGrid";
            this.стокиMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.стокиMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.стокиMetroGrid.RowHeadersWidth = 51;
            this.стокиMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.стокиMetroGrid.RowTemplate.Height = 24;
            this.стокиMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.стокиMetroGrid.Size = new System.Drawing.Size(860, 220);
            this.стокиMetroGrid.TabIndex = 3;
            // 
            // доставкаBindingSource1
            // 
            this.доставкаBindingSource1.DataMember = "Доставка";
            this.доставкаBindingSource1.DataSource = this.hranitelenMagazinDataSet;
            // 
            // категориястокиBindingSource
            // 
            this.категориястокиBindingSource.DataMember = "Категория_стоки";
            this.категориястокиBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // маркаBindingSource
            // 
            this.маркаBindingSource.DataMember = "Марка";
            this.маркаBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // име_на_стокаTextBox
            // 
            this.име_на_стокаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.стокиBindingSource, "Име_на_стока", true));
            this.име_на_стокаTextBox.Location = new System.Drawing.Point(193, 134);
            this.име_на_стокаTextBox.Name = "име_на_стокаTextBox";
            this.име_на_стокаTextBox.Size = new System.Drawing.Size(201, 22);
            this.име_на_стокаTextBox.TabIndex = 7;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // категория_стокиTableAdapter
            // 
            this.категория_стокиTableAdapter.ClearBeforeFill = true;
            // 
            // маркаTableAdapter
            // 
            this.маркаTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Код_стока";
            this.Column1.HeaderText = "Код на стока";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 184;
            // 
            // Код_доставка
            // 
            this.Код_доставка.DataPropertyName = "Код_доставка";
            this.Код_доставка.DataSource = this.доставкаBindingSource1;
            this.Код_доставка.DisplayMember = "Код_на_доставка";
            this.Код_доставка.HeaderText = "Код_доставка";
            this.Код_доставка.MinimumWidth = 6;
            this.Код_доставка.Name = "Код_доставка";
            this.Код_доставка.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Код_доставка.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Код_доставка.ValueMember = "Код_на_доставка";
            this.Код_доставка.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn4.DataSource = this.категориястокиBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Име_на_категория";
            this.dataGridViewTextBoxColumn4.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Код_категория";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn5.DataSource = this.маркаBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn5.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Код_на_марка";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ед_цена";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ед_цена";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Наличност";
            this.dataGridViewTextBoxColumn7.HeaderText = "Наличност";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // Стоки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 490);
            this.Controls.Add(this.име_на_стокаTextBox);
            this.Controls.Add(код_стокаLabel);
            this.Controls.Add(this.стокиMetroGrid);
            this.Controls.Add(this.стокиBindingNavigator);
            this.Name = "Стоки";
            this.Text = "Стоки";
            this.Load += new System.EventHandler(this.Стоки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingNavigator)).EndInit();
            this.стокиBindingNavigator.ResumeLayout(false);
            this.стокиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.стокиMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориястокиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маркаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HranitelenMagazinDataSet hranitelenMagazinDataSet;
        private System.Windows.Forms.BindingSource стокиBindingSource;
        private HranitelenMagazinDataSetTableAdapters.СтокиTableAdapter стокиTableAdapter;
        private HranitelenMagazinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator стокиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton стокиBindingNavigatorSaveItem;
        private MetroFramework.Controls.MetroGrid стокиMetroGrid;
        private System.Windows.Forms.TextBox име_на_стокаTextBox;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private HranitelenMagazinDataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.BindingSource категориястокиBindingSource;
        private HranitelenMagazinDataSetTableAdapters.Категория_стокиTableAdapter категория_стокиTableAdapter;
        private System.Windows.Forms.BindingSource маркаBindingSource;
        private HranitelenMagazinDataSetTableAdapters.МаркаTableAdapter маркаTableAdapter;
        private System.Windows.Forms.BindingSource доставкаBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Код_доставка;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}