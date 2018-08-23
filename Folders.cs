using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HackerRank
{
    public class Folders
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            var doc = XDocument.Parse(xml);

            var nodes = doc.DescendantNodes().ToList();

            List<string> list = new List<string>();

            foreach (var node in nodes)
            {
                var element = node as XElement;

                if (element.Name != "folder") continue;

                foreach (var attribute in element.Attributes())
                {
                    if (attribute.Value.StartsWith(startingLetter.ToString()))
                    {
                        list.Add(attribute.Value);
                    }
                }
            }

            return list;
        }
    }
}
