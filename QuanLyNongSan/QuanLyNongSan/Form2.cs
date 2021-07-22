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
    public partial class Form2 : Form
    {
        static public Form3 form3;
        public static String nameEmployee;
        public Form2()
        {
            InitializeComponent();
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonNhapNS_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();

        }
    }
}
