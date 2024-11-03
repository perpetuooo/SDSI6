using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XML_Validator
{
    public partial class Form1 : Form
    {
        private string xsdPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectXsd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XSD Files (*.xsd)|*.xsd|All files (*.*)|*.*";
            openFileDialog1.Title = "Select an XSD File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xsdPath = openFileDialog1.FileName;
                txtResult.Text = "XSD carregado: " + xsdPath;
            }
        }

        private void btnSelectXml_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.Title = "Select an XML File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(openFileDialog1.FileName);

                    if (string.IsNullOrEmpty(xsdPath))
                    {
                        txtResult.Text = "Por favor, carregue um arquivo XSD primeiro.";
                        return;
                    }

                    xmlDoc.Schemas.Add(null, xsdPath);
                    xmlDoc.Validate(ValidationEventHandler);

                    txtResult.Text = "XML bem formado e válido segundo o esquema XSD.";
                }
                catch (XmlSchemaValidationException ex)
                {
                    txtResult.Text = "Erro de validação: " + ex.Message;
                }
                catch (XmlException xmlEx)
                {
                    txtResult.Text = "Erro ao analisar o XML: " + xmlEx.Message;
                }
                catch (Exception ex)
                {
                    txtResult.Text = "Erro: " + ex.Message;
                }
            }
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            throw new XmlSchemaValidationException($"Erro de validação: {e.Message}");
        }
    }
}
