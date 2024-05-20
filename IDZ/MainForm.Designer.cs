namespace IDZ
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            MainTableGUI = new TableLayoutPanel();
            ControlPanelGUI = new TableLayoutPanel();
            SearchRow = new TableLayoutPanel();
            ButtonRow = new TableLayoutPanel();
            OpenButton = new Button();
            ToHTMLButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ControlPanelGUI.SuspendLayout();
            ButtonRow.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(MainTableGUI, 0, 0);
            tableLayoutPanel1.Controls.Add(ControlPanelGUI, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1032, 115);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainTableGUI
            // 
            MainTableGUI.AutoScroll = true;
            MainTableGUI.AutoSize = true;
            MainTableGUI.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            MainTableGUI.ColumnCount = 1;
            MainTableGUI.ColumnStyles.Add(new ColumnStyle());
            MainTableGUI.Dock = DockStyle.Fill;
            MainTableGUI.Location = new Point(3, 3);
            MainTableGUI.Name = "MainTableGUI";
            MainTableGUI.RowCount = 2;
            MainTableGUI.RowStyles.Add(new RowStyle());
            MainTableGUI.RowStyles.Add(new RowStyle());
            MainTableGUI.Size = new Size(1026, 3);
            MainTableGUI.TabIndex = 0;
            // 
            // ControlPanelGUI
            // 
            ControlPanelGUI.ColumnCount = 1;
            ControlPanelGUI.ColumnStyles.Add(new ColumnStyle());
            ControlPanelGUI.Controls.Add(SearchRow, 0, 0);
            ControlPanelGUI.Controls.Add(ButtonRow, 0, 1);
            ControlPanelGUI.Dock = DockStyle.Fill;
            ControlPanelGUI.Location = new Point(3, 12);
            ControlPanelGUI.MaximumSize = new Size(0, 150);
            ControlPanelGUI.Name = "ControlPanelGUI";
            ControlPanelGUI.RowCount = 2;
            ControlPanelGUI.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            ControlPanelGUI.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            ControlPanelGUI.Size = new Size(1026, 100);
            ControlPanelGUI.TabIndex = 1;
            // 
            // SearchRow
            // 
            SearchRow.ColumnCount = 2;
            SearchRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SearchRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SearchRow.Dock = DockStyle.Fill;
            SearchRow.Location = new Point(3, 3);
            SearchRow.Name = "SearchRow";
            SearchRow.RowCount = 1;
            SearchRow.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SearchRow.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SearchRow.Size = new Size(1020, 34);
            SearchRow.TabIndex = 0;
            // 
            // ButtonRow
            // 
            ButtonRow.ColumnCount = 2;
            ButtonRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonRow.Controls.Add(OpenButton, 0, 0);
            ButtonRow.Controls.Add(ToHTMLButton, 1, 0);
            ButtonRow.Dock = DockStyle.Fill;
            ButtonRow.Location = new Point(3, 43);
            ButtonRow.Name = "ButtonRow";
            ButtonRow.RowCount = 1;
            ButtonRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonRow.Size = new Size(1020, 54);
            ButtonRow.TabIndex = 1;
            // 
            // OpenButton
            // 
            OpenButton.Dock = DockStyle.Fill;
            OpenButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenButton.Location = new Point(3, 3);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(504, 48);
            OpenButton.TabIndex = 0;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // ToHTMLButton
            // 
            ToHTMLButton.Dock = DockStyle.Fill;
            ToHTMLButton.Enabled = false;
            ToHTMLButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToHTMLButton.Location = new Point(513, 3);
            ToHTMLButton.Name = "ToHTMLButton";
            ToHTMLButton.Size = new Size(504, 48);
            ToHTMLButton.TabIndex = 1;
            ToHTMLButton.Text = "To HTML";
            ToHTMLButton.UseVisualStyleBackColor = true;
            ToHTMLButton.Click += ToHTMLButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 115);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Kostiuk_IDZ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ControlPanelGUI.ResumeLayout(false);
            ButtonRow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel MainTableGUI;
        private TableLayoutPanel ControlPanelGUI;
        private TableLayoutPanel SearchRow;
        private TableLayoutPanel ButtonRow;
        private Button OpenButton;
        private Button ToHTMLButton;
    }
}
