#region Licence

// WifiCatBuilder - WifiCatBuilder - BrandList.cs
// Created 14.06.2017 19:08
// 
// 
// Wifi Configuration Assist Tool
// Copyright (C) 2017 Bennet Becker <bennet@becker-dd.de>
// 
// This program is free software: you can redistribute it and/or modify 
// it under the terms of the GNU Affero General Public License as published by 
// the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License 
// along with this program. If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Using

using System;
using System.Windows.Forms;

#endregion

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
            while (lb_brands.SelectedItem != null)
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