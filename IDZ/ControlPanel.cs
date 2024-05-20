using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ
{
    public delegate void FileOpenedEventHandler(object source, FileOpenedEventArgs e);

    public class FileOpenedEventArgs : EventArgs
    {
        private List<int> _column_sizes = new List<int>();
        public FileOpenedEventArgs(List<int> column_sizes)
        {
            _column_sizes = column_sizes;
        }
        public List<int> GetSizes()
        {
            return _column_sizes;
        }
    }

    interface IControlPanel
    {        
        event FileOpenedEventHandler FileOpened;
        void Call(object source, FileOpenedEventArgs e);
        Data? OpenFile();
        string? SaveFile(Data data);
        void SetSearchBar(object sender, FileOpenedEventArgs args);
        void SetGUI(TableLayoutPanel panel);
    }

    public class ControlPanel : IControlPanel
    {
        private TableLayoutPanel? GUI;
        public event FileOpenedEventHandler? FileOpened;

        public ControlPanel() { }
        public ControlPanel(TableLayoutPanel panel) { GUI = panel; }

        public void Call(object source, FileOpenedEventArgs e)
        {
            if (FileOpened == null) { return; }
            FileOpened(source, e);
        }

        public Data? OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.DefaultExt = "XML Files (*.xml)|*.xml";
            openFileDialog.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            File file = new File(openFileDialog.FileName);
            file.Read();
            string load = file.GetLoad();
            return new Data(Translator.TranslateXMLToList(load));
        }

        public string? SaveFile(Data data)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "HTML Files (*.html)|*.html";
            saveFileDialog.DefaultExt = "HTML Files (*.html)|*.html";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) { return null; }
            File file = new File(saveFileDialog.FileName);
            string load = Translator.TranslateDataToHTML(data);
            file.SetLoad(load);
            file.Write();
            return saveFileDialog.FileName;
        }

        public void SetSearchBar(object sender, FileOpenedEventArgs args)
        {
            List<int> sizes = args.GetSizes();
            if (GUI == null) { return; }
            TableLayoutPanel? searchRow = (TableLayoutPanel?) GUI.Controls["SearchRow"];
            if (searchRow == null) { return; }
            searchRow.Controls.Clear();
            searchRow.ColumnCount = sizes.Count;
            int i = 0;
            foreach (int size in sizes)
            {
                AddControl(searchRow, size, i);
                i++;
            }
        }

        public void SetGUI(TableLayoutPanel panel) { GUI = panel; }

        private void AddControl(TableLayoutPanel panel, int width, int column)
        {
            TextBox textBox = new TextBox();
            textBox.Width = width;
            textBox.Dock = DockStyle.Fill;
            textBox.TextChanged += new EventHandler(MainForm.Search);
            panel.Controls.Add(textBox, column, 0);
            panel.ColumnStyles.Insert(column, new ColumnStyle(SizeType.AutoSize));
        }
    }
}
