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
    public partial class Стоки : MetroFramework.Forms.MetroForm
    {
        public Стоки()
        {
            InitializeComponent();
        }

        private void стокиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стокиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hranitelenMagazinDataSet);

        }

        private void Стоки_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Марка' table. You can move, or remove it, as needed.
            this.маркаTableAdapter.Fill(this.hranitelenMagazinDataSet.Марка);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Категория_стоки' table. You can move, or remove it, as needed.
            this.категория_стокиTableAdapter.Fill(this.hranitelenMagazinDataSet.Категория_стоки);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Доставка' table. You can move, or remove it, as needed.
            this.доставкаTableAdapter.Fill(this.hranitelenMagazinDataSet.Доставка);
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Стоки' table. You can move, or remove it, as needed.
            this.стокиTableAdapter.Fill(this.hranitelenMagazinDataSet.Стоки);

        }
    }
}
