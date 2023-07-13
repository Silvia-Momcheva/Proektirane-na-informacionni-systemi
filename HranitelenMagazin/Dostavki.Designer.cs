namespace HranitelenMagazin
{
    partial class Dostavki
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
            System.Windows.Forms.Label код_на_доставкаLabel;
            System.Windows.Forms.Label код_на_доставчикLabel;
            System.Windows.Forms.Label дата_на_доставкаLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dostavki));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hranitelenMagazinDataSet = new HranitelenMagazin.HranitelenMagazinDataSet();
            this.стока_ДоставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стока_ДоставкаTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.Стока_ДоставкаTableAdapter();
            this.tableAdapterManager = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.TableAdapterManager();
            this.доставкаTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.ДоставкаTableAdapter();
            this.доставчикTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.ДоставчикTableAdapter();
            this.стока_ДоставкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.стока_ДоставкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стокаДоставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.доставчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_на_доставкаDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.стока_ДоставкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.стока_ДоставкаDataGridView = new System.Windows.Forms.DataGridView();
            this.стокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стокиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.СтокиTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_на_доставкаLabel = new System.Windows.Forms.Label();
            код_на_доставчикLabel = new System.Windows.Forms.Label();
            дата_на_доставкаLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаBindingNavigator)).BeginInit();
            this.стока_ДоставкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокаДоставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_на_доставкаLabel
            // 
            код_на_доставкаLabel.AutoSize = true;
            код_на_доставкаLabel.Location = new System.Drawing.Point(99, 134);
            код_на_доставкаLabel.Name = "код_на_доставкаLabel";
            код_на_доставкаLabel.Size = new System.Drawing.Size(121, 17);
            код_на_доставкаLabel.TabIndex = 2;
            код_на_доставкаLabel.Text = "Код на доставка:";
            // 
            // код_на_доставчикLabel
            // 
            код_на_доставчикLabel.AutoSize = true;
            код_на_доставчикLabel.Location = new System.Drawing.Point(99, 175);
            код_на_доставчикLabel.Name = "код_на_доставчикLabel";
            код_на_доставчикLabel.Size = new System.Drawing.Size(131, 17);
            код_на_доставчикLabel.TabIndex = 4;
            код_на_доставчикLabel.Text = "Име на доставчик:";
            // 
            // дата_на_доставкаLabel1
            // 
            дата_на_доставкаLabel1.AutoSize = true;
            дата_на_доставкаLabel1.Location = new System.Drawing.Point(99, 216);
            дата_на_доставкаLabel1.Name = "дата_на_доставкаLabel1";
            дата_на_доставкаLabel1.Size = new System.Drawing.Size(130, 17);
            дата_на_доставкаLabel1.TabIndex = 9;
            дата_на_доставкаLabel1.Text = "Дата на доставка:";
            // 
            // hranitelenMagazinDataSet
            // 
            this.hranitelenMagazinDataSet.DataSetName = "HranitelenMagazinDataSet";
            this.hranitelenMagazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стока_ДоставкаBindingSource
            // 
            this.стока_ДоставкаBindingSource.DataMember = "Стока_Доставка";
            this.стока_ДоставкаBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // стока_ДоставкаTableAdapter
            // 
            this.стока_ДоставкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоставкаTableAdapter = this.доставкаTableAdapter;
            this.tableAdapterManager.ДоставчикTableAdapter = this.доставчикTableAdapter;
            this.tableAdapterManager.Заявка_към_доставчикTableAdapter = null;
            this.tableAdapterManager.Категория_стокиTableAdapter = null;
            this.tableAdapterManager.МаркаTableAdapter = null;
            this.tableAdapterManager.ПродажбиTableAdapter = null;
            this.tableAdapterManager.СлужителиTableAdapter = null;
            this.tableAdapterManager.Стока_ДоставкаTableAdapter = this.стока_ДоставкаTableAdapter;
            this.tableAdapterManager.Стока_ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Стоки_ПродажбиTableAdapter = null;
            this.tableAdapterManager.СтокиTableAdapter = null;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // доставчикTableAdapter
            // 
            this.доставчикTableAdapter.ClearBeforeFill = true;
            // 
            // стока_ДоставкаBindingNavigator
            // 
            this.стока_ДоставкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.стока_ДоставкаBindingNavigator.BindingSource = this.стока_ДоставкаBindingSource;
            this.стока_ДоставкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.стока_ДоставкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.стока_ДоставкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.стока_ДоставкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.стока_ДоставкаBindingNavigatorSaveItem});
            this.стока_ДоставкаBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.стока_ДоставкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.стока_ДоставкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.стока_ДоставкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.стока_ДоставкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.стока_ДоставкаBindingNavigator.Name = "стока_ДоставкаBindingNavigator";
            this.стока_ДоставкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.стока_ДоставкаBindingNavigator.Size = new System.Drawing.Size(860, 27);
            this.стока_ДоставкаBindingNavigator.TabIndex = 0;
            this.стока_ДоставкаBindingNavigator.Text = "bindingNavigator1";
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
            // стока_ДоставкаBindingNavigatorSaveItem
            // 
            this.стока_ДоставкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.стока_ДоставкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("стока_ДоставкаBindingNavigatorSaveItem.Image")));
            this.стока_ДоставкаBindingNavigatorSaveItem.Name = "стока_ДоставкаBindingNavigatorSaveItem";
            this.стока_ДоставкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.стока_ДоставкаBindingNavigatorSaveItem.Text = "Save Data";
            this.стока_ДоставкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.стока_ДоставкаBindingNavigatorSaveItem_Click);
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // стокаДоставкаBindingSource
            // 
            this.стокаДоставкаBindingSource.DataMember = "Стока_Доставка";
            this.стокаДоставкаBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.стока_ДоставкаBindingSource, "Код_доставка", true));
            this.metroComboBox1.DataSource = this.доставкаBindingSource;
            this.metroComboBox1.DisplayMember = "Код_на_доставка";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(268, 127);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(200, 30);
            this.metroComboBox1.TabIndex = 8;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Код_на_доставка";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.доставкаBindingSource, "Код_на_доставчик", true));
            this.metroComboBox2.DataSource = this.доставчикBindingSource;
            this.metroComboBox2.DisplayMember = "Наименование";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Location = new System.Drawing.Point(268, 168);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(200, 30);
            this.metroComboBox2.TabIndex = 9;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.ValueMember = "Код_доставчик";
            // 
            // доставчикBindingSource
            // 
            this.доставчикBindingSource.DataMember = "Доставчик";
            this.доставчикBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // дата_на_доставкаDateTimePicker1
            // 
            this.дата_на_доставкаDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.доставкаBindingSource, "Дата_на_доставка", true));
            this.дата_на_доставкаDateTimePicker1.Location = new System.Drawing.Point(268, 213);
            this.дата_на_доставкаDateTimePicker1.Name = "дата_на_доставкаDateTimePicker1";
            this.дата_на_доставкаDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.дата_на_доставкаDateTimePicker1.TabIndex = 10;
            // 
            // стока_ДоставкаBindingSource1
            // 
            this.стока_ДоставкаBindingSource1.DataMember = "FK_Стока_Доставка_Доставка";
            this.стока_ДоставкаBindingSource1.DataSource = this.доставкаBindingSource;
            // 
            // стока_ДоставкаDataGridView
            // 
            this.стока_ДоставкаDataGridView.AutoGenerateColumns = false;
            this.стока_ДоставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.стока_ДоставкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.стока_ДоставкаDataGridView.DataSource = this.стока_ДоставкаBindingSource1;
            this.стока_ДоставкаDataGridView.Location = new System.Drawing.Point(37, 292);
            this.стока_ДоставкаDataGridView.Name = "стока_ДоставкаDataGridView";
            this.стока_ДоставкаDataGridView.RowHeadersWidth = 51;
            this.стока_ДоставкаDataGridView.RowTemplate.Height = 24;
            this.стока_ДоставкаDataGridView.Size = new System.Drawing.Size(733, 220);
            this.стока_ДоставкаDataGridView.TabIndex = 10;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_доставка";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_доставка";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_стока";
            this.dataGridViewTextBoxColumn1.DataSource = this.стокиBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Име_на_стока";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_стока";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "Код_стока";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Брой";
            this.dataGridViewTextBoxColumn3.HeaderText = "Брой";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Цена";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Dostavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.стока_ДоставкаDataGridView);
            this.Controls.Add(дата_на_доставкаLabel1);
            this.Controls.Add(this.дата_на_доставкаDateTimePicker1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(код_на_доставчикLabel);
            this.Controls.Add(код_на_доставкаLabel);
            this.Controls.Add(this.стока_ДоставкаBindingNavigator);
            this.Name = "Dostavki";
            this.Text = "Доставки";
            this.Load += new System.EventHandler(this.Dostavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаBindingNavigator)).EndInit();
            this.стока_ДоставкаBindingNavigator.ResumeLayout(false);
            this.стока_ДоставкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокаДоставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стока_ДоставкаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HranitelenMagazinDataSet hranitelenMagazinDataSet;
        private System.Windows.Forms.BindingSource стока_ДоставкаBindingSource;
        private HranitelenMagazinDataSetTableAdapters.Стока_ДоставкаTableAdapter стока_ДоставкаTableAdapter;
        private HranitelenMagazinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator стока_ДоставкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton стока_ДоставкаBindingNavigatorSaveItem;
        private HranitelenMagazinDataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private System.Windows.Forms.BindingSource стокаДоставкаBindingSource;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private HranitelenMagazinDataSetTableAdapters.ДоставчикTableAdapter доставчикTableAdapter;
        private System.Windows.Forms.BindingSource доставчикBindingSource;
        private System.Windows.Forms.DateTimePicker дата_на_доставкаDateTimePicker1;
        private System.Windows.Forms.BindingSource стока_ДоставкаBindingSource1;
        private System.Windows.Forms.DataGridView стока_ДоставкаDataGridView;
        private System.Windows.Forms.BindingSource стокиBindingSource;
        private HranitelenMagazinDataSetTableAdapters.СтокиTableAdapter стокиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}