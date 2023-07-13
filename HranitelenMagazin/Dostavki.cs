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
    public partial class Dostavki : MetroFramework.Forms.MetroForm
    {
        public Dostavki()
        {
            InitializeComponent();
        }

        private void стока_ДоставкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стока_ДоставкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hranitelenMagazinDataSet);

        }

        private void Dostavki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Стоки' table. You can move, or remove it, as needed.
            this.стокиTableAdapter.Fill(this.hranitelenMagazinDataSet.Стоки);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Доставчик' table. You can move, or remove it, as needed.
            this.доставчикTableAdapter.Fill(this.hranitelenMagazinDataSet.Доставчик);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Доставка' table. You can move, or remove it, as needed.
            this.доставкаTableAdapter.Fill(this.hranitelenMagazinDataSet.Доставка);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Стока_Доставка' table. You can move, or remove it, as needed.
            this.стока_ДоставкаTableAdapter.Fill(this.hranitelenMagazinDataSet.Стока_Доставка);

        }
    }
}
