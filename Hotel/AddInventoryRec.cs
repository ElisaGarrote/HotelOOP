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
    public partial class AddInventoryRec : Form
    {
        public AddInventoryRec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddInventoryRec2 itemIn = new AddInventoryRec2();
            itemIn.FormClosed += new FormClosedEventHandler(InventoryItemInsert_FormClosed);
            itemIn.Show();
            this.Hide();
        }

        private void InventoryItemInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
