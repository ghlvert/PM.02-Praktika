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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manufacturer1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturer1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Manufacturer1". При необходимости она может быть перемещена или удалена.
            this.manufacturer1TableAdapter.Fill(this.dataSet1.Manufacturer1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manufacturer1BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manufacturer1BindingSource.EndEdit();
            manufacturer1TableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
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
