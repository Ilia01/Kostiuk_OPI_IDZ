using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDZ
{
    public static class Translator
    {
        public static List<Dictionary<string, string>> TranslateXMLToList(string xml_text)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            XElement xElement = XElement.Parse(xml_text);
            foreach (XElement element in xElement.Elements())
            {
                Dictionary<string, string> eldict = new Dictionary<string, string>();
                foreach (XElement element2 in element.Elements())
                {
                    eldict.Add(element2.Name.LocalName, element2.Value);
                }
                result.Add(eldict);
            }
            return result;
        }

        public static string TranslateDataToHTML(Data data)
        {
            string html_header = String.Join(Environment.NewLine,
                "<!DOCTYPE html>",
                "<html>",
                "<body>",
                "<table>");
            string html_footer = String.Join(Environment.NewLine,
                "</table>",
                "</body>",
                "</html>");
            string headers = "<tr>" + Environment.NewLine;
            foreach (string header in data.Headers)
            {
                headers += @"   <th scope=""col"">" + header + "</th>" + Environment.NewLine;
            }
            headers += "</tr>";
            string rows = "";
            foreach (List<string> row in data.Rows)
            {
                string row_text = "<tr>";
                foreach (string cell in row)
                {
                    row_text += Environment.NewLine + @"  <td>" + cell + "</td>";
                }
                row_text += Environment.NewLine + "</tr>";
                rows += row_text;
            }
            return String.Join(Environment.NewLine,
                html_header,
                headers,
                rows,
                html_footer);
        }
    }
}
