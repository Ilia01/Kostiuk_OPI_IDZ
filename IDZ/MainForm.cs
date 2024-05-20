using System.Diagnostics;

namespace IDZ
{
    public partial class MainForm : Form
    {
        private static MainForm? instance;
        Data? Data;
        IDataTable DataTable;
        IControlPanel ControlPanel;

        public MainForm()
        {
            InitializeComponent();
            DataTable = new DataTable(MainTableGUI);
            DataTable.DataTableSizeChanged += new DataTableSizeEventHandler(SetWindowSizeFromEvent);
            ControlPanel = new ControlPanel();
            ControlPanel.SetGUI(ControlPanelGUI);
            ControlPanel.FileOpened += new FileOpenedEventHandler(ControlPanel.SetSearchBar);
            MainForm.instance = this;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Data = ControlPanel.OpenFile();
            if (Data == null) { return; }
            if (Data.Headers.Count != 0) { ToHTMLButton.Enabled = true; }
            else { ToHTMLButton.Enabled = false; }
            MainTableGUI.Size = new Size(1, 1);
            SetWindowSize(-60, -ControlPanelGUI.Height);
            tableLayoutPanel1.RowStyles[0].SizeType = SizeType.AutoSize;
            DataTable.new_data = true;
            DataTable.Data = Data;
            ControlPanel.Call(this, new FileOpenedEventArgs(DataTable.GetSizes()));
        }

        public void SetWindowSizeFromEvent(object sender, DataTableSizeEventArgs e)
        {
            SetWindowSize(e.GetWidth(), e.GetHeight());
        }

        public void SetWindowSize(int width, int height)
        {
            width += 60;
            height += ControlPanelGUI.Height;
            Rectangle resolution = Screen.GetBounds(this);
            if (width > resolution.Width - 50) { width = resolution.Width - 50; }
            if (height > resolution.Height - 50) { height = resolution.Height - 50; }
            this.Width = width;
            this.Height = height;
            this.Location = new Point((resolution.Width - width) / 2, (resolution.Height - height) / 2);
            this.tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
            this.tableLayoutPanel1.RowStyles[0].Height = Math.Max(height - ControlPanelGUI.Height, 0);
        }

        public static void Search(object? sender, EventArgs e)
        {
            if (instance == null) { return; }
            List<string> strings = new List<string>();
            foreach (object? item in instance.ControlPanelGUI.Controls[0].Controls)
            {
                if (item.GetType() != typeof(TextBox)) { continue; }
                TextBox tb = (TextBox)item;
                strings.Add(tb.Text);
            }
            instance.DataTable.Search(instance.Data, strings);
        }

        private void ToHTMLButton_Click(object sender, EventArgs e)
        {
            if (Data == null) { return; }
            string? path = ControlPanel.SaveFile(DataTable.Data);
            if (path != null)
            {
                HTMLSuccessForm HTMLSuccessForm = new HTMLSuccessForm();
                HTMLSuccessForm.path = path;
                HTMLSuccessForm.ShowDialog();
            }
        }
    }
}