using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QuanLyNongSan.Model
{
    class HoaDon
    {
        XMLFile XmlFile = new XMLFile();
        String taoMaHoaDon(XmlDocument XDoc) {
     
            XmlNodeList temp = XDoc.SelectNodes("/HoaDonNhapXuats/HoaDonNhapXuat[last()]");

            String maHD = temp[0].ChildNodes[0].InnerText;
            maHD = ("000000" + (int.Parse(maHD.Substring(2))+1).ToString());
            maHD = "HD"+maHD.Substring(maHD.Length - 5);
            Console.WriteLine(maHD);
         

            return maHD;
        }

        public Boolean add(XmlDocument XDocCTHD,List<XmlNode> nodeList,String maKhachHang,String l) {
            try {
                XmlDocument XDoc = XmlFile.getXmlDocument("HoaDonNhapXuats.xml");
                String maHD_new = taoMaHoaDon(XDoc);
                String maNV = Form1.form2.maNV;
                String maKH = maKhachHang;
                String loai = l;
                
                XmlFile.themHoaDon(XDoc,maHD_new,maNV,maKH,loai);
                foreach (XmlNode x in nodeList) {
                    XmlNode maHoaDon = XDocCTHD.CreateElement("maHD");
                    maHoaDon.InnerText = maHD_new;
                    x.InsertBefore(maHoaDon,x.FirstChild);
                    XDocCTHD.DocumentElement.AppendChild(x);
                }
                XDocCTHD.Save("ChiTietHoaDons.xml");

            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
