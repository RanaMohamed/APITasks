using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab1.Models
{
    public partial class City : IXmlSerializable
    {
        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Id", Id.ToString());
            writer.WriteElementString("Name", Name);
            writer.WriteElementString("Country_Id", Country_Id.ToString());
            writer.WriteElementString("Country", Country.Name);
        }
    }
}