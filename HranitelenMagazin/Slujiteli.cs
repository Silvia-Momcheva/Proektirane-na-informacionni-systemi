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
    public partial class Slujiteli : MetroFramework.Forms.MetroForm
    {
        public Slujiteli()
        {
            InitializeComponent();
        }

        private void служителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.служителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hranitelenMagazinDataSet);

        }

        private void Slujiteli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hranitelenMagazinDataSet.Служители' table. You can move, or remove it, as needed.
            this.служителиTableAdapter.Fill(this.hranitelenMagazinDataSet.Служители);

        }
    }
}
