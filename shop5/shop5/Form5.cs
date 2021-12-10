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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void supplierrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierrBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.supplierr". При необходимости она может быть перемещена или удалена.
            this.supplierrTableAdapter.Fill(this.dataSet1.supplierr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplierrBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supplierrBindingSource.EndEdit();
            supplierrTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
            Hide();
        }
    }
}
