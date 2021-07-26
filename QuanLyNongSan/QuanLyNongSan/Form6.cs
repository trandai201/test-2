using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNongSan
{
    public partial class FormSaoLuuData : Form
    {
        public FormSaoLuuData()
        {
            InitializeComponent();
        }

        private void buttonXML_SQL_Click(object sender, EventArgs e)
        {
            BackUp bk = new BackUp();
            bk.BackUpData();
        }

        private void buttonKhoiPhuc_Click(object sender, EventArgs e)
        {
            Restore rs = new Restore();
            rs.RestoreData();
        }
    }
}
