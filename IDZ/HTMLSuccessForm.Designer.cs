namespace IDZ
{
    partial class HTMLSuccessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            CloseButton = new Button();
            OpenButton = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(CloseButton, 0, 1);
            tableLayoutPanel1.Controls.Add(OpenButton, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(461, 192);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Fill;
            CloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(3, 147);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(224, 42);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Dock = DockStyle.Fill;
            OpenButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenButton.Location = new Point(233, 147);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(225, 42);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open file";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 40);
            label1.Name = "label1";
            label1.Size = new Size(435, 64);
            label1.TabIndex = 2;
            label1.Text = "HTML file has been successfully saved! Do you want to see it?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HTMLSuccessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 192);
            Controls.Add(tableLayoutPanel1);
            Name = "HTMLSuccessForm";
            Text = "HTML successfully saved";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button CloseButton;
        private Button OpenButton;
        private Label label1;
    }
}