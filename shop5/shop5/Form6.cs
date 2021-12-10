using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void warehouseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.dataSet1.Warehouse);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            warehouseBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            warehouseBindingSource.EndEdit();
            warehouseTableAdapter.Update(dataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            Hide();
        }
    }
}
