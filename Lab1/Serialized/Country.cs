using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab1.Models
{
    public partial class Country : IXmlSerializable
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
            writer.WriteStartElement("Cities");
            foreach (var city in Cities.ToList())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(City));
                serializer.Serialize(writer, city);
            }
            writer.WriteEndElement();
        }
    }
}