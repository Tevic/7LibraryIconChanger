using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;

namespace CSharpHelperLibrary
{
    class XmlInsert
    {
        //========================================创建 XML  类  ===========================================================
        #region InsertNode
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, string ChildNode, string Element, string Content)
        {
            //插入一节点和此节点的一子节点。
            //XmlNode objRootNode = objXmlDoc.SelectSingleNode(mainNode);
            XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
            XmlNode objRootNode = xmlNodeList.Item(0);
            XmlElement objChildNode = objXmlDoc.CreateElement(ChildNode);
            objRootNode.AppendChild(objChildNode);//插入节点
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objChildNode.AppendChild(objElement);//插入子节点
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, string Element, string Attrib, string AttribContent, string Content)
        {
            //插入一个节点，带一属性。
            //XmlNode objNode = objXmlDoc.SelectSingleNode(mainNode);
            XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
            XmlNode objNode = xmlNodeList.Item(0);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.SetAttribute(Attrib, AttribContent);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, string Element, string Content)
        {
            //插入一个节点，不带属性。
            //XmlNode objNode = objXmlDoc.SelectSingleNode(mainNode);
            XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
            XmlNode objNode = xmlNodeList.Item(0);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, string[] Element, string[] Content)
        {
            //插入一个节点，不带属性。
            //XmlNode objNode = objXmlDoc.SelectSingleNode(mainNode);
            XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
            XmlNode objNode = xmlNodeList.Item(0);
            for (int i = 0; i < Element.Length; i++)
            {
                XmlElement objElement = objXmlDoc.CreateElement(Element[i]);
                objElement.InnerText = Content[i];
                objNode.AppendChild(objElement);
            }
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, List<ArrayList> listElement)
        {
            //插入一个节点，不带属性。
            //XmlNode objNode = objXmlDoc.SelectSingleNode(mainNode);
            XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
            XmlNode objNode = xmlNodeList.Item(0);
            for (int i = 0; i < listElement[0].Count; i++)
            {
                XmlElement objElement = objXmlDoc.CreateElement(listElement[0][i].ToString());
                objElement.InnerText = listElement[1][i].ToString();
                objNode.AppendChild(objElement);
            }
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, string elementName, string[] Element, string[] Content)
        {
            //插入一个节点，不带属性。
            //XmlNode objNode = objXmlDoc.SelectSingleNode(mainNode);
            XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
            XmlNode objNode = xmlNodeList.Item(0);
            XmlElement xmlElement = objXmlDoc.CreateElement(elementName);
            for (int i = 0; i < Element.Length; i++)
            {
                XmlElement objElement = objXmlDoc.CreateElement(Element[i]);
                objElement.InnerText = Content[i];
                xmlElement.AppendChild(objElement);
            }
            objNode.AppendChild(xmlElement);
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, string elementName, List<ArrayList> listElement)
        {
            //插入一个节点，不带属性。
            if (listElement.Count > 0)
            {
                XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
                XmlNode objNode = xmlNodeList.Item(0);
                XmlElement xmlElement = objXmlDoc.CreateElement(elementName);
                for (int i = 0; i < listElement[0].Count; i++)
                {
                    XmlElement objElement = objXmlDoc.CreateElement(listElement[0][i].ToString());
                    objElement.InnerText = listElement[1][i].ToString();
                    xmlElement.AppendChild(objElement);
                }
                objNode.AppendChild(xmlElement);
            }
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string mainNode, string elementName, string[] arrAttributeName, string[] arrAttributeContent, string elementContent)
        {
            //XmlNode objNode = objXmlDoc.SelectSingleNode(mainNode);
            XmlNodeList xmlNodeList = objXmlDoc.GetElementsByTagName(mainNode);
            XmlNode objNode = xmlNodeList.Item(0);
            XmlElement objElement = objXmlDoc.CreateElement(elementName);
            for (int i = 0; i <= arrAttributeName.GetUpperBound(0); i++)
            {
                objElement.SetAttribute(arrAttributeName[i], arrAttributeContent[i]);
            }
            objElement.InnerText = elementContent;
            objNode.AppendChild(objElement);
            return objXmlDoc;
        }
        public XmlDocument InsertNode(XmlDocument objXmlDoc, string elementName, string[] arrAttributeName, string[] arrAttributeContent, string elementContent)
        {
            XmlElement objElement = objXmlDoc.CreateElement(elementName);
            for (int i = 0; i <= arrAttributeName.GetUpperBound(0); i++)
            {
                objElement.SetAttribute(arrAttributeName[i], arrAttributeContent[i]);
            }
            objElement.InnerText = elementContent;
            objXmlDoc.AppendChild(objElement);
            return objXmlDoc;
        }
        #endregion
        //=====================================================================================================================
    }
}
