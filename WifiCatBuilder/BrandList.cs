using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiCatBuilder
{
    public partial class BrandList : Form
    {
        public BrandList()
        {
            InitializeComponent();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            /*foreach (var selectedItem in lb_brands.SelectedItems)
            {
                lb_brands.Items.Remove(selectedItem);
            }*/
            while(lb_brands.SelectedItem != null)
                lb_brands.Items.Remove(lb_brands.SelectedItem);

        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            lb_brands.Items.Clear();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            var addF = new BrandList_add();
            if (addF.ShowDialog() == DialogResult.OK)
            {
                foreach (var line in addF.textBox1.Lines)
                {
                    lb_brands.Items.Add(line);
                }
            }
            addF.Dispose();
        }
    }
}
