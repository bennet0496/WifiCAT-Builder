#region Licence

// WifiCatBuilder - WifiCatBuilder - Form1.cs
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
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using WifiCatBuilder.Properties;

#endregion

namespace WifiCatBuilder
{
    public partial class Form1 : Form
    {
        private string[] _brandsStrings;
        private X509Certificate2 _caCertificate;
        private X509Certificate2 _sigingCertificate;

        public Form1()
        {
            InitializeComponent();
        }

        private void ofd_cacert_FileOk(object sender, CancelEventArgs e)
        {
            _caCertificate = new X509Certificate2(ofd_cacert.FileName);
            tt_cacert.SetToolTip(tb_cacert, _caCertificate.Subject);
            tb_cacert.Text = ofd_cacert.FileName;
        }

        private void b_cacert_Click(object sender, EventArgs e)
        {
            ofd_cacert.ShowDialog();
        }

        private void l_edit_brand_list_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var brands = new BrandList();
            if (brands.ShowDialog() == DialogResult.OK)
            {
                _brandsStrings = brands.lb_brands.Items.Cast<string>().ToArray();
            }
            brands.Dispose();
        }

        private void b_color_primary_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                p_color_primary.BackColor = colorDialog.Color;
            }
        }

        private void b_color_primary_dark_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                p_color_primary_dark.BackColor = colorDialog.Color;
            }
        }

        private void b_color_accent_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                p_color_accent.BackColor = colorDialog.Color;
            }
        }

        private void c_req_brand_CheckedChanged(object sender, EventArgs e)
        {
            l_edit_brand_list.Enabled = c_req_brand.Checked;
        }

        private void ofd_siging_cert_FileOk(object sender, CancelEventArgs e)
        {
            var succ = false;
            var password = "";
            while (!succ)
            {
                try
                {
                    _sigingCertificate = new X509Certificate2(ofd_siging_cert.FileName, password);
                    succ = true;
                }
                catch (CryptographicException cerr)
                {
                    var pwBox = new PasswordPromt();
                    if (pwBox.ShowDialog() == DialogResult.OK)
                    {
                        password = pwBox.tb_password.Text;
                        pwBox.Dispose();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            if (!_sigingCertificate.HasPrivateKey)
            {
                MessageBox.Show(
                    Resources
                        .Form1_ofd_siging_cert_FileOk_This_Certificate_does_not_contains_a_Private_Key__therefore_it_is_intended_to_be_used_here_,
                    Resources.Form1_ofd_siging_cert_FileOk_Error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new CryptographicException("no private key");
            }
            //TODO Check keyUsage
            /*var keyUsages = (from oidCollection in 
                                (from x509Extension in _sigingCertificate.Extensions.Cast<X509Extension>()
                                 where x509Extension.GetType() == typeof(X509EnhancedKeyUsageExtension)
                                 select ((X509EnhancedKeyUsageExtension) x509Extension).EnhancedKeyUsages)
                            where oidCollection.GetType() == typeof(OidCollection) select oidCollection);*/
            l_signing_cert_cn.Text = _sigingCertificate.Subject;
        }

        private void b_signing_cert_Click(object sender, EventArgs e)
        {
            ofd_siging_cert.ShowDialog();
        }

        private void b_build_Click(object sender, EventArgs e)
        {
        }
    }
}