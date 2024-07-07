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
    public partial class AddRoomRec : Form
    {
        public AddRoomRec()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRoomRec_Load(object sender, EventArgs e)
        {

        }

        private void adminInventory1_Load(object sender, EventArgs e)
        {

        }

        private void add_inventorybut_Click(object sender, EventArgs e)
        {
            AddInventoryRec addIn = new AddInventoryRec();
            addIn.FormClosed += new FormClosedEventHandler(InventoryAdd_FormClosed);
            addIn.Show();
            this.Hide();
        }

        private void InventoryAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
