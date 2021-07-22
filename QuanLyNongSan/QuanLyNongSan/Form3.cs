using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using QuanLyNongSan.Model;

namespace QuanLyNongSan
{
    public partial class Form3 : Form
    {
        XMLFile XmlFile = new XMLFile();
        XmlNodeList nodeListDM;
        XmlNodeList nodeListCTNS;
        int stt = 0;
        public Form3()
        {
            InitializeComponent();
        }



        private void buttonInHoaDon_Click(object sender, EventArgs e)
        {
            List<XmlNode> nodeList = new List<XmlNode>();
                       XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietHoaDons.xml");
            for(int i = 0; i<dataGridView1.Rows.Count-1;i++){
                String temp = "";
                XmlElement node = XDoc.CreateElement("ChiTietHoaDon");
      
                XmlElement maNS = XDoc.CreateElement("maNS");
                temp = dataGridView1.Rows[i].Cells[5].Value.ToString();
                Console.WriteLine(temp);
                 maNS.InnerText = dataGridView1.Rows[i].Cells[5].Value.ToString();
                XmlElement soLuong = XDoc.CreateElement("soLuong");
                Console.WriteLine(dataGridView1.Rows[i].Cells[6].Value.ToString());
                soLuong.InnerText = dataGridView1.Rows[i].Cells[3].Value.ToString();
                XmlElement donGia = XDoc.CreateElement("DonGia");
                donGia.InnerText = dataGridView1.Rows[i].Cells[4].Value.ToString(); ;

                node.AppendChild(maNS);
                node.AppendChild(soLuong);
                node.AppendChild(donGia);
                nodeList.Add(node);
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.add(XDoc, nodeList, textBoxNhaCungCap.Text, "N");
            MessageBox.Show("Thêm Nông Sản Thành Công", "Thông Báo");
            dataGridView1.Rows.Clear();


        }

        private void Form3_Load(object sender, EventArgs e)
        {   
            DanhMucNongSan DMNS = new DanhMucNongSan();
            nodeListDM = DMNS.getListMD();
            foreach (XmlNode x in nodeListDM)
            {
                comboBoxLoaiNS.Items.Add(x.ChildNodes[1].InnerText);
            
            }
        }

        private void comboBoxTenNongSan_SelectedIndexChanged(object sender, EventArgs e)
        {
   

        }

        private void comboBoxLoaiNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChiTietNongSan CTNS = new ChiTietNongSan();
                nodeListCTNS = CTNS.getListName();
                String maNS = "";
                comboBoxTenNongSan.Items.Clear();
                foreach (XmlNode x in nodeListDM)
                {
                    if (x.ChildNodes[1].InnerText.Equals(comboBoxLoaiNS.SelectedItem.ToString()))
                        maNS = x.ChildNodes[0].InnerText;
                }

                foreach (XmlNode x in nodeListCTNS)
                {
                    if (x.ChildNodes[4].InnerText.Equals(maNS))
                        comboBoxTenNongSan.Items.Add(x.ChildNodes[1].InnerText+" "+x.ChildNodes[0].InnerText);
                }
            }
            catch { }
          
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            comboBoxLoaiNS.SelectedIndex = comboBoxLoaiNS.Items.IndexOf(dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString());
            comboBoxTenNongSan.SelectedIndex = comboBoxTenNongSan.Items.IndexOf(dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString() + dataGridView1.CurrentRow.Cells[6].FormattedValue.ToString());
            textBoxDonGia.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
            textBoxDonGia.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNhaCungCap.Text.Equals(""))
                {
                    int a = int.Parse(textBoxNhaCungCap.Text);
                }
                int soLuong = int.Parse(textBoxSoLuong.Text);
                int donGia = int.Parse(textBoxDonGia.Text);
                int tong = soLuong * donGia;
                dataGridView1.Rows.Add(++stt, comboBoxTenNongSan.SelectedItem.ToString().Substring(0, comboBoxTenNongSan.SelectedItem.ToString().Length - 7), comboBoxLoaiNS.SelectedItem.ToString(), soLuong, donGia, tong,
                 
                   comboBoxTenNongSan.SelectedItem.ToString().Substring(comboBoxTenNongSan.SelectedItem.ToString().Length-7));
                textBoxSoLuong.Text = "";
                textBoxDonGia.Text = "";
            }
            catch {

                MessageBox.Show("Thêm Nông Sản Thất Bại", "Thông Báo");
            }
       
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

   
    }
}
