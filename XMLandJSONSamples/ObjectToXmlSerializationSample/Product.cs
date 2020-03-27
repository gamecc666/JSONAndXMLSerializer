using System;
using System.Xml;
using System.Xml.Serialization;
/*
 * 详细参考网址：https://docs.microsoft.com/zh-cn/dotnet/api/system.xml.serialization.xmlserializernamespaces?redirectedfrom=MSDN&view=netframework-4.7.2
 * System.Xml.Serialization命名空间下可用的属性：
 *      XmlArrayAttribute:将指定的类成员序列化为XML元素
 *      XmlArrayItemAttribute:可以再序列化数组中放置派生的类型
 *      XmlAttributeAttribute:将类成员序列化为属性
 *      XmlElementAttribute:指示公共字段或属性，在序列化，反序列化对象时表示它的XML元素（即属性）
 *      XmlRootAttribute:控制根目标的序列化
 *      XmlTypeAttribute:控制当属性目标序列化时生成的XML架构
 */
namespace ObjectToXmlSerializationSample
{   
    [XmlRoot]
    public class Product
    {

        [XmlAttribute(AttributeName = "Discount")]
        public int Discount { get; set; }

        [XmlElement]
        public int ProductID { get; set; }

        [XmlElement]
        public string ProductName { get; set; }

        [XmlElement]
        public int SupplierID { get; set; }

        [XmlElement]
        public int CategoryID { get; set; }

        [XmlElement]
        public string QuantityPerUnit { get; set; }

        [XmlElement]
        public Decimal UnitPrice { get; set; }

        [XmlElement]
        public short UnitsInStock { get; set; }

        [XmlElement]
        public short UnitsOnOrder { get; set; }

        [XmlElement]
        public short ReorderLevel { get; set; }

        [XmlElement]
        public bool Discontinued { get; set; }

        public override string ToString() => $"{ProductID} {ProductName} {UnitPrice:C}";
    }

}
