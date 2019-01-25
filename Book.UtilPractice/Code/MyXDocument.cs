using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace Book.UtilPractice.Code
{
    public class MyXDocument
    {
        public void M1()
        {
            var document = XDocument.Parse("<?xml version=\"1.0\" ?><Student><Name>孙小双</Name></Student>");
            document.Save(Path.Combine(Environment.CurrentDirectory, "Data", "Save", $"{DateTime.Now:yyyyMMddHHmmss}.xml"));
        }

        public void M2()
        {
            var company = new XElement("Company",
                new XElement("Name", "简单猫"),
                new XElement("Code", "20863255211421"),
                new XElement("Address", 
                    new XElement("Province", "湖北省"),
                    new XElement("City", "武汉市"),
                    new XElement("Area", "汉阳区"),
                    new XElement("Detail", "龙阳时代B座1103"),
                    new XAttribute("PostCode", "420100")),
                new XComment("地址没问题"),
                new XElement("StaffList", 
                    new XElement("Staff", 
                        new XElement("Name", "孙小双"),
                        new XElement("Age", 30)),
                    new XElement("Staff",
                        new XElement("Name", "华天晓"),
                        new XElement("Age", 29)),
                    new XElement("Staff",
                        new XElement("Name", "孙远杰"),
                        new XElement("Age", 23))));
            var document = XDocument.Parse(company.ToString());
            Save(document);
        }

        public void M3()
        {
            var document = Load("1.xml");
            var eles = document.Descendants("Staff");
            foreach (var item in eles)
            {
                Console.WriteLine($"{item.Name}:{item.Descendants("Name").FirstOrDefault().Value},{item.Descendants("Age").FirstOrDefault().Value}");
            }
        }

        private void Save(XDocument document)
        {
            document.Save(Path.Combine(Environment.CurrentDirectory, "Data", "Save", $"{DateTime.Now:yyyyMMddHHmmss}.xml"));
        }

        private XDocument Load(string filename)
        {
            return XDocument.Load(Path.Combine(Environment.CurrentDirectory, "Data", "From", filename));
        }

    }
}
