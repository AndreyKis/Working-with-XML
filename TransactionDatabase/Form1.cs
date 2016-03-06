using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Diagnostics;
namespace TransactionDatabase
{
    public partial class Form1 : Form
    {
        private string xmlFilePath = "";
        private IXml xml;
        private Categories categories = new Categories();
        public Form1()
        {
            InitializeComponent();
            LinqRadioButton.Checked = true;
        }

        private void openXmlFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (xmlOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filePath = xmlOpenFileDialog.FileName;
                    xmlFilePath = filePath;
                    xml.LoadFile(filePath);
                    categories.Load(xmlFilePath);
                    RedrawTransactions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mistake");
            }
        }

        private void RedrawTransactions()
        {
            addElementsToList(xml.GetAllTransactions());
        }

        private void addElementToList(Transaction transaction)
        {
            if (transaction == null)
                return;
            ListViewItem item = new ListViewItem(new[] { 
                transaction.id.ToString(), 
                (transaction.type.ToString()=="income"?"Income":"Waste"), 
                transaction.cost.ToString(), 
                categories.GetName(transaction.categoryId), 
                transaction.date.ToString()});
            this.testsListView.Items.Add(item);
        }
        private void addElementsToList(List<Transaction> transactions)
        {

            testsListView.Items.Clear();
            foreach (var transaction in transactions)
            {
                if (transaction != null)
                    addElementToList(transaction);
            }
        }



        private void searchQuestionButton_Click(object sender, EventArgs e)
        {
            if (xmlFilePath == null)
            {
                MessageBox.Show("Firstly, open an XML file");
                return;
            }
            
            if (byIdRadioButton.Checked) // by id
            {
                int id;
                if (!Int32.TryParse(this.textBox1.Text, out id))
                {
                    MessageBox.Show("Enter the correct number");
                    return;
                }
                var transactions = xml.SearchById(id);
                addElementsToList(transactions);
            }
            else if (ByDateRadioButton.Checked) // by dates
            {
                string startDate = textBox2.Text;
                string endDate = textBox4.Text;

                if (!checkDate(startDate) || !checkDate(endDate))
                {
                    MessageBox.Show("Enter the correct dates YYYY-MM-DD");
                    return;
                }
                
                var transactions = xml.SearchByDate(startDate, endDate);
                addElementsToList(transactions);
            }
            else if (ByCategoryRadioButton.Checked) // by category
            {
                string category = textBox3.Text;
                if (categories.GetId(category) == -1)
                {
                    MessageBox.Show("Unknown category");
                }
                else
                {
                    var transactions = xml.SearchByCategoryId(categories.GetId(category));
                    addElementsToList(transactions);
                }
            }
        }

        private bool checkDate(string date)
        {
            if (date.Length != 10)
                return false;
            int x;
            if (!Int32.TryParse(date.Substring(0, 4), out x)) {
                return false;
            }
            if (!Int32.TryParse(date.Substring(5, 2), out x)) {
                return false;
            }
            if (!Int32.TryParse(date.Substring(8, 2), out x)) {
                return false;
            }
            return true;
        }

        private void TransformFile(string filePath, string templateFilePath)
        {
            if (filePath == null || filePath == "")
                throw new ArgumentException("Firstly, open an XML file");
            XslCompiledTransform xslt = new XslCompiledTransform();
            string resultFilePath = filePath.Substring(0, filePath.LastIndexOf('.')) + ".html";
            xslt.Load(templateFilePath);
            xslt.Transform(filePath, resultFilePath);
            MessageBox.Show("Done\n"+resultFilePath);
        }

        private void transformationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (xmlFilePath == null)
                {
                    MessageBox.Show("Firstly, open an XML file");
                        return;
                }
                string xslFile = null;
                if (xslOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    xslFile = xslOpenFileDialog.FileName;
                }
                if (xmlFilePath != null && xslFile != null)
                    TransformFile(xmlFilePath, xslFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categories.Load(xmlFilePath);
            RedrawTransactions();
        }

        private void LinqRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            xml = new Linq();
            if (xmlFilePath != "")
            {
                xml.LoadFile(xmlFilePath);
            }
        }

        private void ByCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            xml = new Dom();
            if (xmlFilePath != "")
            {
                xml.LoadFile(xmlFilePath);
            }
        }

        private void SaxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            xml = new Sax();
            if (xmlFilePath != "")
            {
                xml.LoadFile(xmlFilePath);
            }
        }
    }
}
