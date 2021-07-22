using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QuanLyNongSan.Model
{
    class ChiTietNongSan
    {

        XMLFile XmlFile = new XMLFile();
        public XmlNodeList getListName() {
            
            XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietNongSans.xml");

            return XDoc.SelectNodes("/ChiTietNongSans/ChiTietNongSan");
        }

    }
}
