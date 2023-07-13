using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HranitelenMagazin
{
    public partial class Prodajbi : MetroFramework.Forms.MetroForm
    {
        public Prodajbi()
        {
            InitializeComponent();
        }

        private void стоки_ПродажбиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стоки_ПродажбиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hranitelenMagazinDataSet);

        }

        private void Prodajbi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Стоки' table. You can move, or remove it, as needed.
            this.стокиTableAdapter.Fill(this.hranitelenMagazinDataSet.Стоки);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.hranitelenMagazinDataSet.Служители);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Продажби' table. You can move, or remove it, as needed.
            this.продажбиTableAdapter.Fill(this.hranitelenMagazinDataSet.Продажби);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Стоки_Продажби' table. You can move, or remove it, as needed.
            this.стоки_ПродажбиTableAdapter.Fill(this.hranitelenMagazinDataSet.Стоки_Продажби);

        }

        private void стоки_ПродажбиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void дата_на_продажбаDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void код_на_продажбаTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
