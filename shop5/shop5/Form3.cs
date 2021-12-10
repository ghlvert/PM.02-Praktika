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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void purchaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.dataSet1.Purchase);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchaseBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            purchaseBindingSource.EndEdit();
            purchaseTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            Hide();
        }
    }
}
