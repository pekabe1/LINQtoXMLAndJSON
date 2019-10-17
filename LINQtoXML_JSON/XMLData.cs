using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQtoXMLAndJSON
{
    public static class XMLData
    {

        public static List<Book> GetBooksFromFile(string fileName)
        {
            XDocument document = XDocument.Load(fileName);

            return document.
                Element("root").
                 Elements().
                 Select(x => new Book
                 {
                     Category = x.Attribute(nameof(Book.Category)).Value,
                     ID = int.Parse(x.Attribute(nameof(Book.ID)).Value),
                     Name = x.Attribute(nameof(Book.Name)).Value,
                     Status = x.Attribute(nameof(Book.Status)).Value
                 })
                 .ToList();
        }
    }
}
