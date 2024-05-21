using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using zad1.Interfaces;
using zad1.Models;

namespace zad1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }
        public void Add(Student student)
        {
            var xRoot = _document.DocumentElement;

            XmlElement flightElem = _document.CreateElement("student");

            XmlAttribute LastNameAttribute = _document.CreateAttribute("LastName");
            XmlText LastNameText = _document.CreateTextNode(student.LastName);
            LastNameAttribute.AppendChild(LastNameText);

            XmlElement bdNumberElem = _document.CreateElement("Birthday");
            XmlText bdNumberInnerText = _document.CreateTextNode(student.Birthday.ToString());
            bdNumberElem.AppendChild(bdNumberInnerText);

            flightElem.AppendChild(bdNumberElem);

            XmlElement NameElem = _document.CreateElement("Name");
            XmlText NameInnerText = _document.CreateTextNode(student.Name.ToString());
            NameElem.AppendChild(NameInnerText);

            flightElem.AppendChild(NameElem);

            xRoot.AppendChild(flightElem);
            _document.Save(_xmlFilePath);

        }

        public void Delete(string LastName)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeName = xNode.Attributes.GetNamedItem(LastName);
                    try 
                    {
                        var attributeNameText = attributeName?.InnerText;
                        if (attributeNameText.Equals(LastName))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeName));
                    }
                }
            }
        }

        public Student FindBy(string destinationName)
        {
            Student student = null;
            var xRoot = _document.DocumentElement;
            foreach(XmlNode xmlNode in xRoot)
            {
                student = GetFlight(xmlNode);
                if (student.LastName.Equals(destinationName))
                {
                    return student;
                }
            }

            return student;
        }

        private Student GetFlight(XmlNode node)
        {
            var student = new Student();
            if (node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("LastName");
                student.LastName = attributeName?.Value;
            }

            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("LastName"))
                    {
                        student.LastName = (childNode.InnerText).ToString();
                    }
                    if(childNode.Name.Equals("Birthday"))
                    {
                        student.Birthday = (childNode.InnerText).ToString();
                    }
                    if(childNode.Name.Equals("Name"))
                    {
                        student.Name = (childNode.InnerText).ToString();
                    }

                }
                catch (Exception ex) when (ex is FormatException
                    || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));   
                }
            }
            return student;
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            var xRoot = _document.DocumentElement;
            foreach(XmlNode node in xRoot)
            {
                var student = GetFlight(node);
                students.Add(student);      
            }
            return students;
        }

        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }
    }
}
