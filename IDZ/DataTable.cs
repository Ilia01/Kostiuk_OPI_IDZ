using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    public delegate void DataTableSizeEventHandler(object source, DataTableSizeEventArgs e);

    public class DataTableSizeEventArgs : EventArgs
    {
        private int width;
        private int height;
        public DataTableSizeEventArgs(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
    }

    interface IDataTable
    {
        public event DataTableSizeEventHandler? DataTableSizeChanged;
        public Data Data { get; set; }
        public bool new_data { get; set; }
        public List<int> GetSizes();
        public void Search(Data? data, List<string> search_strings);
    }

    public class DataTable : IDataTable
    {
        public event DataTableSizeEventHandler? DataTableSizeChanged;
        private TableLayoutPanel GUI;
        private Data _data = new Data();
        public bool new_data { get; set; }
        public Data Data
        { 
            get 
            { 
                return _data; 
            } 
            set 
            {
                _data = value; 
                Display(); 
            } 
        }
        
        public DataTable(TableLayoutPanel panel) { GUI = panel; }
        public DataTable(TableLayoutPanel panel, Data data) { GUI = panel; this.Data = data; }

        private void AddControl(string text, int col, int row)
        {
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            GUI.Controls.Add(label, col, row);
        }

        private void FixSize()
        {
            int columns = GUI.ColumnCount;
            GUI.ColumnStyles.Clear();
            for (int i = 0; i < columns; i++)
            {
                GUI.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, GUI.Controls[i].Width + 10));
            }
        }

        private void Display()
        {
            GUI.Visible = false;
            GUI.Controls.Clear();
            SetDimensions(_data.Rows.Count, _data.Headers.Count);
            int row = 0;
            int col = 0;
            foreach (string value in  _data.Headers)
            {
                AddControl(value, col, row);
                col++;
            }
            row = 1;
            col = 0;
            foreach (List<string> row_list in _data.Rows)
            {
                foreach (string value in  row_list)
                {
                    AddControl(value, col, row);
                    col++;
                }
                row++;
                col = 0;
            }
            if (DataTableSizeChanged != null && new_data)
            {
                FixSize();
                Size size = GUI.GetPreferredSize(Size.Empty);                
                DataTableSizeChanged(this, new DataTableSizeEventArgs(size.Width, size.Height));                
            }
            GUI.Visible = true;
            new_data = false;
        }

        public List<int> GetSizes()
        {
            List<int> sizes = new List<int>();
            for (int i=0; i < GUI.ColumnCount; i++)
            {
                sizes.Add((int)GUI.Controls[i].Width);
            }
            return sizes;
        }

        public void Search(Data? data, List<string> search_strings)
        {
            if (data == null) { return; }
            List<List<string>> rows = data.Rows;
            List<List<string>> result = new List<List<string>>();
            int count = search_strings.Count;
            for (int i=0; i < count; i++)
            {
                string search_row = search_strings[i].ToLower();
                int countj = rows.Count;
                for (int j=0; j < countj; j++)
                {
                    List<string> row = rows[j];
                    if (row[i].ToLower().Contains(search_row)) { result.Add(row); }
                }
                rows = result;
                result = new List<List<string>>();
            }
            this.Data = new Data(data.Headers, rows);
        }

        private void SetDimensions(int rows, int columns)
        {
            GUI.RowCount = rows;
            GUI.ColumnCount = columns;
        }
    }
}
