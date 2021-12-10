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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void plumbing_products1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plumbing_products1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Plumbing_products1". При необходимости она может быть перемещена или удалена.
            this.plumbing_products1TableAdapter.Fill(this.dataSet1.Plumbing_products1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plumbing_products1BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plumbing_products1BindingSource.EndEdit();
            plumbing_products1TableAdapter.Update(dataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }
    }
}
