using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class InventoryAdd : Form
    {
        public InventoryAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItem_btn1_Click(object sender, EventArgs e)
        {
            InventoryItemInsert itemIn = new InventoryItemInsert();
            itemIn.FormClosed += new FormClosedEventHandler(InventoryItemInsert_FormClosed);
            itemIn.Show();
            this.Hide();
            this.addItem_btn1.BackColor = Color.Gray;
        }

        private void InventoryItemInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
