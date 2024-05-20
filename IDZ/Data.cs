using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    public class Data
    {
        public List<string> Headers = new List<string>();
        public List<List<string>> Rows = new List<List<string>>();

        public Data() { }
        public Data(List<Dictionary<string, string>> data) { SetData(data); }
        public Data(List<string> headers, List<List<string>> rows) { SetData(headers, rows); }

        public void SetData(List<Dictionary<string, string>> data)
        {
            List<string> headers = new List<string>();
            List<List<string>> rows = new List<List<string>>();
            foreach (Dictionary<string, string> dict in data)
            {
                foreach (string key in dict.Keys)
                {
                    if (headers.Contains(key)) { continue; }
                    headers.Add(key);
                }
            }
            foreach (Dictionary<string, string> dict in data)
            {
                List<string> row = new List<string>();
                foreach (string header in headers)
                {
                    string? val;
                    dict.TryGetValue(header, out val);
                    if (val == null) { val = ""; }
                    row.Add(val);
                }
                rows.Add(row);
            }
            Headers = headers;
            Rows = rows;
        }
        public void SetData(List<string> headers, List<List<string>> rows)
        {
            Headers = headers;
            Rows = rows;
        }
    }
}
