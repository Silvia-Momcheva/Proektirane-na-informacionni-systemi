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
    public partial class Zaqvki : MetroFramework.Forms.MetroForm
    {
        public Zaqvki()
        {
            InitializeComponent();
        }

        private void заявка_към_доставчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявка_към_доставчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hranitelenMagazinDataSet);

        }

        private void Zaqvki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Стоки' table. You can move, or remove it, as needed.
            this.стокиTableAdapter.Fill(this.hranitelenMagazinDataSet.Стоки);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.hranitelenMagazinDataSet.Служители);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Доставчик' table. You can move, or remove it, as needed.
            this.доставчикTableAdapter.Fill(this.hranitelenMagazinDataSet.Доставчик);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Стока_Заявка' table. You can move, or remove it, as needed.
            this.стока_ЗаявкаTableAdapter.Fill(this.hranitelenMagazinDataSet.Стока_Заявка);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Заявка_към_доставчик' table. You can move, or remove it, as needed.
            this.заявка_към_доставчикTableAdapter.Fill(this.hranitelenMagazinDataSet.Заявка_към_доставчик);

        }

        private void стока_ЗаявкаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
