namespace Szaman
{
    partial class AddProductWindow
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            shortNameTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            priceTextBox = new TextBox();
            addButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(shortNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(fullNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(priceTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(addButton, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(351, 278);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa krótka";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 138);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwa pełna";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 211);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Cena";
            // 
            // shortNameTextBox
            // 
            shortNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            shortNameTextBox.Location = new Point(87, 37);
            shortNameTextBox.Name = "shortNameTextBox";
            shortNameTextBox.Size = new Size(261, 23);
            shortNameTextBox.TabIndex = 3;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullNameTextBox.Location = new Point(87, 134);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(261, 23);
            fullNameTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceTextBox.Location = new Point(87, 207);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(261, 23);
            priceTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(addButton, 2);
            addButton.Location = new Point(3, 249);
            addButton.Name = "addButton";
            addButton.Size = new Size(345, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Dodaj";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddProductWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 278);
            Controls.Add(tableLayoutPanel1);
            Name = "AddProductWindow";
            Text = "Dodaj produkt";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox shortNameTextBox;
        private TextBox fullNameTextBox;
        private TextBox priceTextBox;
        private Button addButton;
    }
}