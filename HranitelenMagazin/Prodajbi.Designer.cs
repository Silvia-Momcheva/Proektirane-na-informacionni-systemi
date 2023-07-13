namespace HranitelenMagazin
{
    partial class Prodajbi
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
            System.Windows.Forms.Label код_на_служителLabel;
            System.Windows.Forms.Label дата_на_продажбаLabel;
            System.Windows.Forms.Label код_на_продажбаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prodajbi));
            this.hranitelenMagazinDataSet = new HranitelenMagazin.HranitelenMagazinDataSet();
            this.стоки_ПродажбиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоки_ПродажбиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.Стоки_ПродажбиTableAdapter();
            this.tableAdapterManager = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.TableAdapterManager();
            this.продажбиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.ПродажбиTableAdapter();
            this.служителиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.СлужителиTableAdapter();
            this.стокиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.СтокиTableAdapter();
            this.стоки_ПродажбиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.продажбиBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.стоки_ПродажбиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.дата_на_продажбаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоки_ПродажбиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.служителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hranitelenMagazinDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоки_ПродажбиDataGridView = new System.Windows.Forms.DataGridView();
            this.код_на_продажбаTextBox = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_на_служителLabel = new System.Windows.Forms.Label();
            дата_на_продажбаLabel = new System.Windows.Forms.Label();
            код_на_продажбаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиBindingNavigator)).BeginInit();
            this.стоки_ПродажбиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажбиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_на_служителLabel
            // 
            код_на_служителLabel.AutoSize = true;
            код_на_служителLabel.Location = new System.Drawing.Point(23, 170);
            код_на_служителLabel.Name = "код_на_служителLabel";
            код_на_служителLabel.Size = new System.Drawing.Size(125, 17);
            код_на_служителLabel.TabIndex = 3;
            код_на_служителLabel.Text = "Име на служител:";
            // 
            // дата_на_продажбаLabel
            // 
            дата_на_продажбаLabel.AutoSize = true;
            дата_на_продажбаLabel.Location = new System.Drawing.Point(23, 208);
            дата_на_продажбаLabel.Name = "дата_на_продажбаLabel";
            дата_на_продажбаLabel.Size = new System.Drawing.Size(135, 17);
            дата_на_продажбаLabel.TabIndex = 5;
            дата_на_продажбаLabel.Text = "Дата на продажба:";
            // 
            // код_на_продажбаLabel
            // 
            код_на_продажбаLabel.AutoSize = true;
            код_на_продажбаLabel.Location = new System.Drawing.Point(23, 132);
            код_на_продажбаLabel.Name = "код_на_продажбаLabel";
            код_на_продажбаLabel.Size = new System.Drawing.Size(126, 17);
            код_на_продажбаLabel.TabIndex = 16;
            код_на_продажбаLabel.Text = "Код на продажба:";
            // 
            // hranitelenMagazinDataSet
            // 
            this.hranitelenMagazinDataSet.DataSetName = "HranitelenMagazinDataSet";
            this.hranitelenMagazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // стоки_ПродажбиBindingSource
            // 
            this.стоки_ПродажбиBindingSource.DataMember = "Стоки_Продажби";
            this.стоки_ПродажбиBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // стоки_ПродажбиTableAdapter
            // 
            this.стоки_ПродажбиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПродажбиTableAdapter = this.продажбиTableAdapter;
            this.tableAdapterManager.СлужителиTableAdapter = this.служителиTableAdapter;
            this.tableAdapterManager.Стока_ДоставкаTableAdapter = null;
            this.tableAdapterManager.Стока_ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Стоки_ПродажбиTableAdapter = this.стоки_ПродажбиTableAdapter;
            this.tableAdapterManager.СтокиTableAdapter = this.стокиTableAdapter;
            // 
            // продажбиTableAdapter
            // 
            this.продажбиTableAdapter.ClearBeforeFill = true;
            // 
            // служителиTableAdapter
            // 
            this.служителиTableAdapter.ClearBeforeFill = true;
            // 
            // стокиTableAdapter
            // 
            this.стокиTableAdapter.ClearBeforeFill = true;
            // 
            // стоки_ПродажбиBindingNavigator
            // 
            this.стоки_ПродажбиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.стоки_ПродажбиBindingNavigator.BindingSource = this.продажбиBindingSource;
            this.стоки_ПродажбиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.стоки_ПродажбиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.стоки_ПродажбиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.стоки_ПродажбиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.стоки_ПродажбиBindingNavigatorSaveItem});
            this.стоки_ПродажбиBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.стоки_ПродажбиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.стоки_ПродажбиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.стоки_ПродажбиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.стоки_ПродажбиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.стоки_ПродажбиBindingNavigator.Name = "стоки_ПродажбиBindingNavigator";
            this.стоки_ПродажбиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.стоки_ПродажбиBindingNavigator.Size = new System.Drawing.Size(760, 27);
            this.стоки_ПродажбиBindingNavigator.TabIndex = 0;
            this.стоки_ПродажбиBindingNavigator.Text = "bindingNavigator1";
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
            // продажбиBindingSource
            // 
            this.продажбиBindingSource.DataMember = "Продажби";
            this.продажбиBindingSource.DataSource = this.hranitelenMagazinDataSet;
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
            // стоки_ПродажбиBindingNavigatorSaveItem
            // 
            this.стоки_ПродажбиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.стоки_ПродажбиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("стоки_ПродажбиBindingNavigatorSaveItem.Image")));
            this.стоки_ПродажбиBindingNavigatorSaveItem.Name = "стоки_ПродажбиBindingNavigatorSaveItem";
            this.стоки_ПродажбиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.стоки_ПродажбиBindingNavigatorSaveItem.Text = "Save Data";
            this.стоки_ПродажбиBindingNavigatorSaveItem.Click += new System.EventHandler(this.стоки_ПродажбиBindingNavigatorSaveItem_Click);
            // 
            // дата_на_продажбаDateTimePicker
            // 
            this.дата_на_продажбаDateTimePicker.AllowDrop = true;
            this.дата_на_продажбаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.продажбиBindingSource, "Дата_на_продажба", true));
            this.дата_на_продажбаDateTimePicker.Location = new System.Drawing.Point(189, 205);
            this.дата_на_продажбаDateTimePicker.Name = "дата_на_продажбаDateTimePicker";
            this.дата_на_продажбаDateTimePicker.ShowUpDown = true;
            this.дата_на_продажбаDateTimePicker.Size = new System.Drawing.Size(281, 22);
            this.дата_на_продажбаDateTimePicker.TabIndex = 6;
            this.дата_на_продажбаDateTimePicker.ValueChanged += new System.EventHandler(this.дата_на_продажбаDateTimePicker_ValueChanged);
            // 
            // стоки_ПродажбиBindingSource1
            // 
            this.стоки_ПродажбиBindingSource1.DataMember = "FK_Стоки_Продажби_Продажби";
            this.стоки_ПродажбиBindingSource1.DataSource = this.продажбиBindingSource;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.продажбиBindingSource, "Код_на_служител", true));
            this.metroComboBox1.DataSource = this.служителиBindingSource;
            this.metroComboBox1.DisplayMember = "Име_на_служител";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(189, 163);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(281, 30);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Код_служител";
            // 
            // служителиBindingSource
            // 
            this.служителиBindingSource.DataMember = "Служители";
            this.служителиBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // стокиBindingSource
            // 
            this.стокиBindingSource.DataMember = "Стоки";
            this.стокиBindingSource.DataSource = this.hranitelenMagazinDataSetBindingSource;
            // 
            // hranitelenMagazinDataSetBindingSource
            // 
            this.hranitelenMagazinDataSetBindingSource.DataSource = this.hranitelenMagazinDataSet;
            this.hranitelenMagazinDataSetBindingSource.Position = 0;
            // 
            // стоки_ПродажбиDataGridView
            // 
            this.стоки_ПродажбиDataGridView.AutoGenerateColumns = false;
            this.стоки_ПродажбиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.стоки_ПродажбиDataGridView.ColumnHeadersVisible = false;
            this.стоки_ПродажбиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.стоки_ПродажбиDataGridView.DataSource = this.стоки_ПродажбиBindingSource1;
            this.стоки_ПродажбиDataGridView.Location = new System.Drawing.Point(23, 281);
            this.стоки_ПродажбиDataGridView.Name = "стоки_ПродажбиDataGridView";
            this.стоки_ПродажбиDataGridView.RowHeadersWidth = 51;
            this.стоки_ПродажбиDataGridView.RowTemplate.Height = 24;
            this.стоки_ПродажбиDataGridView.Size = new System.Drawing.Size(664, 220);
            this.стоки_ПродажбиDataGridView.TabIndex = 16;
            this.стоки_ПродажбиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.стоки_ПродажбиDataGridView_CellContentClick);
            // 
            // код_на_продажбаTextBox
            // 
            this.код_на_продажбаTextBox.AllowDrop = true;
            this.код_на_продажбаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажбиBindingSource, "Код_на_продажба", true));
            this.код_на_продажбаTextBox.Location = new System.Drawing.Point(189, 129);
            this.код_на_продажбаTextBox.Name = "код_на_продажбаTextBox";
            this.код_на_продажбаTextBox.Size = new System.Drawing.Size(281, 22);
            this.код_на_продажбаTextBox.TabIndex = 17;
            this.код_на_продажбаTextBox.SizeChanged += new System.EventHandler(this.дата_на_продажбаDateTimePicker_ValueChanged);
            this.код_на_продажбаTextBox.TextChanged += new System.EventHandler(this.код_на_продажбаTextBox_TextChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Код_на_продажба";
            this.Column1.HeaderText = "Код на продажба";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_на_стока";
            this.dataGridViewTextBoxColumn2.DataSource = this.стокиBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Име_на_стока";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име на стока";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Код_стока";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Брой";
            this.dataGridViewTextBoxColumn3.FillWeight = 60F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Брой";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Prodajbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(код_на_продажбаLabel);
            this.Controls.Add(this.код_на_продажбаTextBox);
            this.Controls.Add(this.стоки_ПродажбиDataGridView);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(код_на_служителLabel);
            this.Controls.Add(дата_на_продажбаLabel);
            this.Controls.Add(this.дата_на_продажбаDateTimePicker);
            this.Controls.Add(this.стоки_ПродажбиBindingNavigator);
            this.Name = "Prodajbi";
            this.Text = "Продажби";
            this.Load += new System.EventHandler(this.Prodajbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиBindingNavigator)).EndInit();
            this.стоки_ПродажбиBindingNavigator.ResumeLayout(false);
            this.стоки_ПродажбиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажбиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стокиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоки_ПродажбиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HranitelenMagazinDataSet hranitelenMagazinDataSet;
        private System.Windows.Forms.BindingSource стоки_ПродажбиBindingSource;
        private HranitelenMagazinDataSetTableAdapters.Стоки_ПродажбиTableAdapter стоки_ПродажбиTableAdapter;
        private HranitelenMagazinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator стоки_ПродажбиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton стоки_ПродажбиBindingNavigatorSaveItem;
        private HranitelenMagazinDataSetTableAdapters.ПродажбиTableAdapter продажбиTableAdapter;
        private System.Windows.Forms.BindingSource продажбиBindingSource;
        private System.Windows.Forms.DateTimePicker дата_на_продажбаDateTimePicker;
        private System.Windows.Forms.BindingSource стоки_ПродажбиBindingSource1;
        private HranitelenMagazinDataSetTableAdapters.СлужителиTableAdapter служителиTableAdapter;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource служителиBindingSource;
        private HranitelenMagazinDataSetTableAdapters.СтокиTableAdapter стокиTableAdapter;
        private System.Windows.Forms.BindingSource hranitelenMagazinDataSetBindingSource;
        private System.Windows.Forms.BindingSource стокиBindingSource;
        private System.Windows.Forms.DataGridView стоки_ПродажбиDataGridView;
        private System.Windows.Forms.TextBox код_на_продажбаTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}