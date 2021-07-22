using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace QuanLyNongSan.Model
{
    class DangNhap
    {
        XMLFile XmlFile = new XMLFile();

       public  Boolean Login(String userName,string password) {
           XmlDocument XDoc = XmlFile.getXmlDocument("NhanViens.xml");
           XmlNodeList nodeList = XDoc.SelectNodes("/NhanViens/NhanVien[tenDN = '"+userName+"']");
         
           if (nodeList.Count != 0)
               if (nodeList[0].ChildNodes[3].InnerText.Equals(password))
               {  
                   return true;
               }

               else { 
                  return false;
               }
           return false;
                
         
           

        
        }
    }
}
