namespace Szaman
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            resultsGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            otwórzToolStripMenuItem = new ToolStripMenuItem();
            zapiszJakoToolStripMenuItem = new ToolStripMenuItem();
            wyjdźToolStripMenuItem = new ToolStripMenuItem();
            zapytaniaToolStripMenuItem = new ToolStripMenuItem();
            wszystkieProduktyToolStripMenuItem = new ToolStripMenuItem();
            listaZamówieńToolStripMenuItem = new ToolStripMenuItem();
            szczegółyZamówieńToolStripMenuItem = new ToolStripMenuItem();
            operacjeToolStripMenuItem = new ToolStripMenuItem();
            dodajProduktToolStripMenuItem = new ToolStripMenuItem();
            bindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            executeQueryButton = new Button();
            label1 = new Label();
            queryTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)resultsGridView).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // resultsGridView
            // 
            resultsGridView.AllowUserToAddRows = false;
            resultsGridView.AllowUserToDeleteRows = false;
            resultsGridView.AllowUserToResizeRows = false;
            resultsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            resultsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsGridView.Dock = DockStyle.Fill;
            resultsGridView.Location = new Point(3, 150);
            resultsGridView.Name = "resultsGridView";
            resultsGridView.ReadOnly = true;
            resultsGridView.Size = new Size(1082, 416);
            resultsGridView.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, zapytaniaToolStripMenuItem, operacjeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1088, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { otwórzToolStripMenuItem, zapiszJakoToolStripMenuItem, wyjdźToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            otwórzToolStripMenuItem.Size = new Size(180, 22);
            otwórzToolStripMenuItem.Text = "Otwórz...";
            otwórzToolStripMenuItem.Click += otwórzToolStripMenuItem_Click;
            // 
            // zapiszJakoToolStripMenuItem
            // 
            zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            zapiszJakoToolStripMenuItem.Size = new Size(180, 22);
            zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            zapiszJakoToolStripMenuItem.Click += zapiszJakoToolStripMenuItem_Click;
            // 
            // wyjdźToolStripMenuItem
            // 
            wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            wyjdźToolStripMenuItem.Size = new Size(180, 22);
            wyjdźToolStripMenuItem.Text = "Wyjdź";
            wyjdźToolStripMenuItem.Click += wyjdźToolStripMenuItem_Click;
            // 
            // zapytaniaToolStripMenuItem
            // 
            zapytaniaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wszystkieProduktyToolStripMenuItem, listaZamówieńToolStripMenuItem, szczegółyZamówieńToolStripMenuItem });
            zapytaniaToolStripMenuItem.Name = "zapytaniaToolStripMenuItem";
            zapytaniaToolStripMenuItem.Size = new Size(71, 20);
            zapytaniaToolStripMenuItem.Text = "Zapytania";
            // 
            // wszystkieProduktyToolStripMenuItem
            // 
            wszystkieProduktyToolStripMenuItem.Name = "wszystkieProduktyToolStripMenuItem";
            wszystkieProduktyToolStripMenuItem.Size = new Size(182, 22);
            wszystkieProduktyToolStripMenuItem.Text = "Wszystkie produkty";
            wszystkieProduktyToolStripMenuItem.Click += wszystkieProduktyToolStripMenuItem_Click;
            // 
            // listaZamówieńToolStripMenuItem
            // 
            listaZamówieńToolStripMenuItem.Name = "listaZamówieńToolStripMenuItem";
            listaZamówieńToolStripMenuItem.Size = new Size(182, 22);
            listaZamówieńToolStripMenuItem.Text = "Lista zamówień";
            listaZamówieńToolStripMenuItem.Click += listaZamówieńToolStripMenuItem_Click;
            // 
            // szczegółyZamówieńToolStripMenuItem
            // 
            szczegółyZamówieńToolStripMenuItem.Name = "szczegółyZamówieńToolStripMenuItem";
            szczegółyZamówieńToolStripMenuItem.Size = new Size(182, 22);
            szczegółyZamówieńToolStripMenuItem.Text = "Szczegóły zamówień";
            szczegółyZamówieńToolStripMenuItem.Click += szczegółyZamówieńToolStripMenuItem_Click;
            // 
            // operacjeToolStripMenuItem
            // 
            operacjeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajProduktToolStripMenuItem });
            operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            operacjeToolStripMenuItem.Size = new Size(66, 20);
            operacjeToolStripMenuItem.Text = "Operacje";
            // 
            // dodajProduktToolStripMenuItem
            // 
            dodajProduktToolStripMenuItem.Name = "dodajProduktToolStripMenuItem";
            dodajProduktToolStripMenuItem.Size = new Size(150, 22);
            dodajProduktToolStripMenuItem.Text = "Dodaj produkt";
            dodajProduktToolStripMenuItem.Click += dodajProduktToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(resultsGridView, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.8347988F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.1652F));
            tableLayoutPanel1.Size = new Size(1088, 569);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(executeQueryButton, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(queryTextBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1082, 141);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // executeQueryButton
            // 
            executeQueryButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            executeQueryButton.Location = new Point(116, 115);
            executeQueryButton.Name = "executeQueryButton";
            executeQueryButton.Size = new Size(963, 23);
            executeQueryButton.TabIndex = 0;
            executeQueryButton.Text = "Wykonaj zapytanie";
            executeQueryButton.UseVisualStyleBackColor = true;
            executeQueryButton.Click += executeQueryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Zapytanie SPARQL:";
            // 
            // queryTextBox
            // 
            queryTextBox.Dock = DockStyle.Fill;
            queryTextBox.Location = new Point(116, 3);
            queryTextBox.Multiline = true;
            queryTextBox.Name = "queryTextBox";
            queryTextBox.ScrollBars = ScrollBars.Vertical;
            queryTextBox.Size = new Size(963, 106);
            queryTextBox.TabIndex = 2;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 593);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Name = "MainWindow";
            Text = "RTV Szaman AGD";
            ((System.ComponentModel.ISupportInitialize)resultsGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private ToolStripMenuItem wyjdźToolStripMenuItem;
        private BindingSource bindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button executeQueryButton;
        private Label label1;
        private TextBox queryTextBox;
        private DataGridView resultsGridView;
        private ToolStripMenuItem zapytaniaToolStripMenuItem;
        private ToolStripMenuItem wszystkieProduktyToolStripMenuItem;
        private ToolStripMenuItem listaZamówieńToolStripMenuItem;
        private ToolStripMenuItem szczegółyZamówieńToolStripMenuItem;
        private ToolStripMenuItem operacjeToolStripMenuItem;
        private ToolStripMenuItem dodajProduktToolStripMenuItem;
    }
}
