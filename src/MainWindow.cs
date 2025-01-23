using System.Data;
using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using VDS.RDF.Writing;

namespace Szaman
{
    public partial class MainWindow : Form
    {
        private OntologyGraph? _ontologyGraph;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki OWL (*.owl;*.rdf;*.xml)|*.owl;*.rdf;*.xml|Wszystkie pliki (*.*)|*.*"; // Filtry plików
            openFileDialog.Title = "Wybierz plik ontologii OWL";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filepath = openFileDialog.FileName;

                try
                {
                    _ontologyGraph = new OntologyGraph();
                    _ontologyGraph.LoadFromFile(filepath, new RdfXmlParser());
                    _ontologyGraph.NamespaceMap.AddNamespace("rdf", new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));

                    MessageBox.Show("Ontologia za³adowana pomyœlnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (RdfParseException ex)
                {
                    MessageBox.Show($"B³¹d parsowania ontologii: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ontologyGraph = null;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"Nie znaleziono pliku: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ontologyGraph = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ontologyGraph = null;
                }
            }
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            if (_ontologyGraph == null)
            {
                MessageBox.Show("Najpierw za³aduj ontologiê.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sparqlQuery = queryTextBox.Text;

            try
            {
                SparqlQueryParser parser = new SparqlQueryParser();
                SparqlQuery query = parser.Parse(new StringReader(sparqlQuery));

                // Wykonywanie zapytania w zale¿noœci od jego typu
                if (query.QueryType == SparqlQueryType.Select)
                {
                    SparqlResultSet results = (SparqlResultSet)_ontologyGraph.ExecuteQuery(query);
                    resultsGridView.DataSource = ConvertResultSetToDataTable(results); // Konwersja do DataTable
                }
                else if (query.QueryType == SparqlQueryType.Ask)
                {
                    SparqlResult results = _ontologyGraph.ExecuteQuery(query) as SparqlResult;
                    if (results != null)
                    {
                        MessageBox.Show($"Wynik zapytania ASK: {results.Value}", "Wynik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Zapytanie ASK nie zwróci³o poprawnego wyniku.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (query.QueryType == SparqlQueryType.Construct || query.QueryType == SparqlQueryType.Describe)
                {
                    Graph resultsGraph = _ontologyGraph.ExecuteQuery(query) as Graph;
                    if (resultsGraph != null)
                    {
                        // Tutaj mo¿na dodaæ kod do wizualizacji lub zapisania grafu
                        MessageBox.Show("Zapytanie CONSTRUCT/DESCRIBE wykonane. Wyniki w obiekcie Graph.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Przyk³adowy zapis do pliku:
                        //resultsGraph.SaveToFile("wyniki.rdf", new RdfXmlWriter());
                    }
                    else
                    {
                        MessageBox.Show("Zapytanie CONSTRUCT/DESCRIBE nie zwróci³o poprawnego grafu.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nieobs³ugiwany typ zapytania SPARQL.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (RdfQueryException ex)
            {
                MessageBox.Show($"B³¹d zapytania SPARQL: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertResultSetToDataTable(SparqlResultSet results)
        {
            DataTable dt = new DataTable();
            if (results.Count > 0)
            {
                foreach (var result in results.Variables)
                {
                    dt.Columns.Add(result);
                }

                foreach (var result in results)
                {
                    DataRow row = dt.NewRow();
                    foreach (var variable in results.Variables)
                    {
                        row[variable] = result[variable]?.ToString();
                    }
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        private void wszystkieProduktyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryTextBox.Text = Zapytania.WszystkieProdukty;
            executeQueryButton.PerformClick();
        }

        private void listaZamówieñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryTextBox.Text = Zapytania.ListaZamowien;
            executeQueryButton.PerformClick();
        }

        private void szczegó³yZamówieñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryTextBox.Text = Zapytania.SzczegolyZamowienia;
            executeQueryButton.PerformClick();
        }

        private void dodajProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ontologyGraph == null)
            {
                MessageBox.Show("Najpierw za³aduj ontologiê.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AddProductWindow addProductWindow = new AddProductWindow();

            if (addProductWindow.ShowDialog() == DialogResult.OK)
            {
                string name = addProductWindow.ShortName;
                string fullname = addProductWindow.FullName;
                string price = addProductWindow.Cena;

                if (ValidateProductData(name, fullname, price))
                {
                    var productNode = _ontologyGraph.CreateIndividual(
                        new Uri($"http://www.example.com/ecommerce#{name}"),
                        new Uri("http://www.example.com/ecommerce#Produkt"));

                    productNode.AddLiteralProperty("http://www.example.com/ecommerce#Nazwa", new LiteralNode(fullname), true);
                    productNode.AddLiteralProperty(
                        "http://www.example.com/ecommerce#Cena",
                        new LiteralNode(price, new Uri("http://www.w3.org/2001/XMLSchema#decimal")),
                        true);

                    MessageBox.Show("Produkt dodany/zaktualizowany pomyœlnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dane produktu s¹ niepoprawne.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateProductData(string name, string description, string price)
        {
            if (string.IsNullOrEmpty(name)) return false;
            if (string.IsNullOrEmpty(description)) return false;

            if (!decimal.TryParse(price, out decimal parsedPrice))
            {
                return false;
            }

            return true;
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "RDF/XML Files (*.rdf)|*.rdf|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Zapisz ontologiê";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog1.FileName;
                    string extension = System.IO.Path.GetExtension(filePath).ToLower();

                    IRdfWriter writer = null;

                    switch (extension)
                    {
                        case ".rdf":
                            writer = new RdfXmlWriter();
                            break;
                        default:
                            MessageBox.Show("Nieznany format.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    if (writer != null)
                    {
                        writer.Save(_ontologyGraph, filePath);
                        MessageBox.Show("Zapisano z suckesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void wyjdŸToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
