namespace HranitelenMagazin
{
    partial class Slujiteli
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
            System.Windows.Forms.Label код_служителLabel;
            System.Windows.Forms.Label име_на_служителLabel;
            System.Windows.Forms.Label длъжностLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label дата_на_назначаванеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slujiteli));
            this.hranitelenMagazinDataSet = new HranitelenMagazin.HranitelenMagazinDataSet();
            this.служителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.служителиTableAdapter = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.СлужителиTableAdapter();
            this.tableAdapterManager = new HranitelenMagazin.HranitelenMagazinDataSetTableAdapters.TableAdapterManager();
            this.служителиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.служителиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_служителTextBox = new System.Windows.Forms.TextBox();
            this.име_на_служителTextBox = new System.Windows.Forms.TextBox();
            this.длъжностTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.дата_на_назначаванеDateTimePicker = new System.Windows.Forms.DateTimePicker();
            код_служителLabel = new System.Windows.Forms.Label();
            име_на_служителLabel = new System.Windows.Forms.Label();
            длъжностLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            дата_на_назначаванеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingNavigator)).BeginInit();
            this.служителиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_служителLabel
            // 
            код_служителLabel.AutoSize = true;
            код_служителLabel.Location = new System.Drawing.Point(57, 139);
            код_служителLabel.Name = "код_служителLabel";
            код_служителLabel.Size = new System.Drawing.Size(103, 17);
            код_служителLabel.TabIndex = 1;
            код_служителLabel.Text = "Код служител:";
            // 
            // име_на_служителLabel
            // 
            име_на_служителLabel.AutoSize = true;
            име_на_служителLabel.Location = new System.Drawing.Point(57, 179);
            име_на_служителLabel.Name = "име_на_служителLabel";
            име_на_служителLabel.Size = new System.Drawing.Size(125, 17);
            име_на_служителLabel.TabIndex = 3;
            име_на_служителLabel.Text = "Име на служител:";
            // 
            // длъжностLabel
            // 
            длъжностLabel.AutoSize = true;
            длъжностLabel.Location = new System.Drawing.Point(57, 219);
            длъжностLabel.Name = "длъжностLabel";
            длъжностLabel.Size = new System.Drawing.Size(79, 17);
            длъжностLabel.TabIndex = 5;
            длъжностLabel.Text = "Длъжност:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(57, 259);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 7;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(57, 299);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 9;
            телефонLabel.Text = "Телефон:";
            // 
            // дата_на_назначаванеLabel
            // 
            дата_на_назначаванеLabel.AutoSize = true;
            дата_на_назначаванеLabel.Location = new System.Drawing.Point(57, 339);
            дата_на_назначаванеLabel.Name = "дата_на_назначаванеLabel";
            дата_на_назначаванеLabel.Size = new System.Drawing.Size(156, 17);
            дата_на_назначаванеLabel.TabIndex = 11;
            дата_на_назначаванеLabel.Text = "Дата на назначаване:";
            // 
            // hranitelenMagazinDataSet
            // 
            this.hranitelenMagazinDataSet.DataSetName = "HranitelenMagazinDataSet";
            this.hranitelenMagazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // служителиBindingSource
            // 
            this.служителиBindingSource.DataMember = "Служители";
            this.служителиBindingSource.DataSource = this.hranitelenMagazinDataSet;
            // 
            // служителиTableAdapter
            // 
            this.служителиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СлужителиTableAdapter = this.служителиTableAdapter;
            this.tableAdapterManager.Стока_ДоставкаTableAdapter = null;
            this.tableAdapterManager.Стока_ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Стоки_ПродажбиTableAdapter = null;
            this.tableAdapterManager.СтокиTableAdapter = null;
            // 
            // служителиBindingNavigator
            // 
            this.служителиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.служителиBindingNavigator.BindingSource = this.служителиBindingSource;
            this.служителиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.служителиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.служителиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.служителиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.служителиBindingNavigatorSaveItem});
            this.служителиBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.служителиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.служителиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.служителиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.служителиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.служителиBindingNavigator.Name = "служителиBindingNavigator";
            this.служителиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.служителиBindingNavigator.Size = new System.Drawing.Size(760, 27);
            this.служителиBindingNavigator.TabIndex = 0;
            this.служителиBindingNavigator.Text = "bindingNavigator1";
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
            // служителиBindingNavigatorSaveItem
            // 
            this.служителиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.служителиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("служителиBindingNavigatorSaveItem.Image")));
            this.служителиBindingNavigatorSaveItem.Name = "служителиBindingNavigatorSaveItem";
            this.служителиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.служителиBindingNavigatorSaveItem.Text = "Save Data";
            this.служителиBindingNavigatorSaveItem.Click += new System.EventHandler(this.служителиBindingNavigatorSaveItem_Click);
            // 
            // код_служителTextBox
            // 
            this.код_служителTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.служителиBindingSource, "Код_служител", true));
            this.код_служителTextBox.Location = new System.Drawing.Point(243, 136);
            this.код_служителTextBox.Name = "код_служителTextBox";
            this.код_служителTextBox.Size = new System.Drawing.Size(257, 22);
            this.код_служителTextBox.TabIndex = 2;
            // 
            // име_на_служителTextBox
            // 
            this.име_на_служителTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.служителиBindingSource, "Име_на_служител", true));
            this.име_на_служителTextBox.Location = new System.Drawing.Point(243, 176);
            this.име_на_служителTextBox.Name = "име_на_служителTextBox";
            this.име_на_служителTextBox.Size = new System.Drawing.Size(257, 22);
            this.име_на_служителTextBox.TabIndex = 4;
            // 
            // длъжностTextBox
            // 
            this.длъжностTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.служителиBindingSource, "Длъжност", true));
            this.длъжностTextBox.Location = new System.Drawing.Point(243, 216);
            this.длъжностTextBox.Name = "длъжностTextBox";
            this.длъжностTextBox.Size = new System.Drawing.Size(257, 22);
            this.длъжностTextBox.TabIndex = 6;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.служителиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(243, 256);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(257, 22);
            this.адресTextBox.TabIndex = 8;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.служителиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(243, 296);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(257, 22);
            this.телефонTextBox.TabIndex = 10;
            // 
            // дата_на_назначаванеDateTimePicker
            // 
            this.дата_на_назначаванеDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.служителиBindingSource, "Дата_на_назначаване", true));
            this.дата_на_назначаванеDateTimePicker.Location = new System.Drawing.Point(243, 336);
            this.дата_на_назначаванеDateTimePicker.Name = "дата_на_назначаванеDateTimePicker";
            this.дата_на_назначаванеDateTimePicker.Size = new System.Drawing.Size(257, 22);
            this.дата_на_назначаванеDateTimePicker.TabIndex = 12;
            // 
            // Slujiteli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(код_служителLabel);
            this.Controls.Add(this.код_служителTextBox);
            this.Controls.Add(име_на_служителLabel);
            this.Controls.Add(this.име_на_служителTextBox);
            this.Controls.Add(длъжностLabel);
            this.Controls.Add(this.длъжностTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(дата_на_назначаванеLabel);
            this.Controls.Add(this.дата_на_назначаванеDateTimePicker);
            this.Controls.Add(this.служителиBindingNavigator);
            this.Name = "Slujiteli";
            this.Text = "Служители";
            this.Load += new System.EventHandler(this.Slujiteli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hranitelenMagazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.служителиBindingNavigator)).EndInit();
            this.служителиBindingNavigator.ResumeLayout(false);
            this.служителиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HranitelenMagazinDataSet hranitelenMagazinDataSet;
        private System.Windows.Forms.BindingSource служителиBindingSource;
        private HranitelenMagazinDataSetTableAdapters.СлужителиTableAdapter служителиTableAdapter;
        private HranitelenMagazinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator служителиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton служителиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_служителTextBox;
        private System.Windows.Forms.TextBox име_на_служителTextBox;
        private System.Windows.Forms.TextBox длъжностTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DateTimePicker дата_на_назначаванеDateTimePicker;
    }
}