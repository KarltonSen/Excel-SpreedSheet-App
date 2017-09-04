using System;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;

using Excel = Microsoft.Office.Interop.Excel;
using OrderReceiptGUI.Extensions;
using System.Reflection;

namespace OrderReceiptGUI
{
    public partial class FrmOrderReceiptGUI : Form
    {
        private double dblTax = 0.0;
        private double dblTotal = 0.0;
        private double dblNetTotal = 0.0;
        private double dblBudget = 0.0;
        private double dblCost = 0.0;
        private double dblCostTotal = 0.0;
        private double dblBudgetTotal = 0.0;

        private const double TaxMultiplier = 0.0;

        /// <summary>
        /// Determines whether input is entered
        /// </summary>
        private bool IsInputEntered
        {
            get
            {
                return
                    txtLaboratory.Text.Length > 0 &&
                    txtItemName.Text.Length > 0 &&
                    txtAddress.Text.Length > 0 &&
                    txtCity.Text.Length > 0 &&
                    txtState.Text.Length > 0 &&
                    txtZipCode.Text.Length > 0 &&
                    txtQuantity.Text.Length > 0 &&
                    txtBudget.Text.Length > 0 &&
                    txtCost.Text.Length > 0;
            }
        }

        static string NewFileName2 = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmOrderReceiptGUI"/> class
        /// </summary>
        public FrmOrderReceiptGUI()
        {
            InitializeComponent();
        }

        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessInput();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clears the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Program: NCAT Order Receipt\n\n" +
                "Author: Joshua Karlton-Senaye & Ben Lutin\n\n" +
                "Director: Dr. William");
        }

        private void OutputNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessInput();
        }

        private void SaveNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel | .xls"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NewFileName2 = Path.GetDirectoryName(NewFileName2);
            }


            // stored file path 


            string connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0'", NewFileName2);


            using (OleDbConnection cn = new OleDbConnection(connectionString))
            {
                MessageBox.Show("Please save all data before copying the original file");

                if (File.Exists(NewFileName2))
                {

                    cn.Open();
                    OleDbCommand cmd1 = new OleDbCommand("INSERT INTO [Sheet1$] " +
                         "([laboratory][Item Name],[Address],[City],[State],[ZipCode Area],[Quantity],[Intial Budget],[Intial Cost],[Sales Tax],[Amount Due Before Tax],[Final Cost],[Final Amount Due],[Final Budget]) " +
                         "VALUES(@value1,@value2, @value3, @value4, @value5,@value6,@value7,@value8,@value9,@value10,@value11,@value12,@value13,@value14)", cn);
                    cmd1.Parameters.AddWithValue("@value1", txtLaboratory.Text);
                    cmd1.Parameters.AddWithValue("@value2", txtItemName.Text);
                    cmd1.Parameters.AddWithValue("@value3", txtAddress.Text);
                    cmd1.Parameters.AddWithValue("@value4", txtCity.Text);
                    cmd1.Parameters.AddWithValue("@value5", txtState.Text);
                    cmd1.Parameters.AddWithValue("@value6", txtZipCode.Text);
                    cmd1.Parameters.AddWithValue("@value7", txtQuantity.Text);
                    cmd1.Parameters.AddWithValue("@value8", txtBudget.Text);
                    cmd1.Parameters.AddWithValue("@value9", txtCost.Text);
                    cmd1.Parameters.AddWithValue("@value10", dblTax.ToString("C"));
                    cmd1.Parameters.AddWithValue("@value11", dblTotal.ToString("C"));
                    cmd1.Parameters.AddWithValue("@value12", dblCost.ToString("C"));
                    cmd1.Parameters.AddWithValue("@value13", dblNetTotal.ToString("C"));
                    cmd1.Parameters.AddWithValue("@value14", dblBudgetTotal.ToString("C"));

                    cmd1.ExecuteNonQuery();


                }
                cn.OpenAsync();
                cn.Close();

                MessageBox.Show("Data saved");
            }

        }

        private void OpenSqlConnection(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        private void CopyOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\NCAT_Order_Receipt.xls";

            string destination = @"C:\Copied_Origrinal_File\NCAT_Order_Receipt.xls";


            File.Delete(fileName);

            File.Copy(fileName, destination);

            MessageBox.Show("Data Copied");

        }

        private void MoveCopiedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\NCAT_Order_Receipt.xls";
            string NewDestination = @"C:\Copied_Origrinal_File\\Older_Versions";
            File.Move(fileName, NewDestination);
        }

        private void DeleteCopiedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string destination = @"C:\Copied_Origrinal_File\NCAT_Order_Receipt.xls";
            File.Delete(destination);
            MessageBox.Show("Original File in Copyied File has been Deleted");
        }

        /// <summary>
        /// Clears all input
        /// </summary>
        private void ResetInput()
        {
            txtLaboratory.Text = "";
            txtQuantity.Text = "";
            txtItemName.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            txtQuantity.Text = "";
            txtBudget.Text = "";
            txtCost.Text = "";
            dblNetTotal = 0;
            dblTax = 0;
            dblTotal = 0;
            dblBudgetTotal = 0;
            dblCostTotal = 0;
        }

        /// <summary>
        /// Toggles the input controls
        /// </summary>
        private void ToggleInputControls()
        {
            // Name
            lblName.Visible = !lblName.Visible;
            txtItemName.Visible = !txtItemName.Visible;

            // Address
            lblAddress.Visible = !lblAddress.Visible;
            txtAddress.Visible = !txtAddress.Visible;

            // State
            lblState.Visible = !lblState.Visible;
            txtState.Visible = !txtState.Visible;

            // Quantity
            lblQuantity.Visible = !lblQuantity.Visible;
            txtQuantity.Visible = !txtQuantity.Visible;

            // Zip code
            lblZipcode.Visible = !lblZipcode.Visible;
            txtZipCode.Visible = !txtZipCode.Visible;

            // City
            lblCity.Visible = !lblCity.Visible;
            txtCity.Visible = !txtCity.Visible;

            // Budget
            lblBudgetPrompt.Visible = !lblBudgetPrompt.Visible;
            txtBudget.Visible = !txtBudget.Visible;

            // Cost
            lblCost.Visible = !lblCost.Visible;
            txtCost.Visible = !txtCost.Visible;

            // Laboratory
            lblLaboratory.Visible = !lblLaboratory.Visible;
            txtLaboratory.Visible = !txtLaboratory.Visible;
        }

        private void ProcessInput()
        {
            if (IsInputEntered)
            {
                // Returns true if all values are successfully parsed
                if (double.TryParse(txtQuantity.Text, out dblTotal) &&
                    double.TryParse(txtBudget.Text, out dblBudget) &&
                    double.TryParse(txtCost.Text, out dblCost))
                {
                    lstResult.Items.Add(new ListViewItem(new[] { "Laboratory Name", txtLaboratory.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Item Name", txtItemName.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Address", txtAddress.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "City", txtCity.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "State", txtState.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Zip Code", txtZipCode.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Quantity", txtQuantity.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Initial Budget", txtBudget.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Item Cost", txtCost.Text }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Amount Due Before Tax", dblTotal.ToString("C2") }));

                    dblTax = TaxMultiplier * dblTotal;
                    lstResult.Items.Add(new ListViewItem(new[] { "Sales Tax", dblTax.ToString("C2") }));

                    dblNetTotal = dblTotal + dblTax;
                    dblCostTotal = dblCost * dblTotal;
                    dblBudgetTotal = dblBudget - dblNetTotal - dblCostTotal;
                    lstResult.Items.Add(new ListViewItem(new[] { "Final Cost", dblCostTotal.ToString("C2") }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Final Amount Due", dblNetTotal.ToString("C2") }));
                    lstResult.Items.Add(new ListViewItem(new[] { "Final Budget", dblBudgetTotal.ToString("C2") }));
                    ListViewExtensions.AutosizeColumns(lstResult);
                }
                else
                {
                    MessageBox.Show(this, "Invalid data was entered. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Please fill all values.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            ProcessInput();
        }

        private void AddToExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            if (GetSavePath(out path))
            {
                SaveWorkbook(path, true);
            }
        }

        private void SaveToNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            if(GetSavePath(out path))
            {
                SaveWorkbook(path, false);
            }
        }

        private bool GetSavePath(out string path)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                DefaultExt = ".xlsx"
            };
            dialog.Filter = "Excel files (*.xlsx) |*.xlsx|All files (*.*)|*.*";
            DialogResult result = dialog.ShowDialog();
            path = dialog.FileName;
            return result == DialogResult.OK;
        }

        private void SaveWorkbook(string path, bool append)
        {
            if(!append)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                Excel.Application oApp = new Excel.Application();

                if (oApp == null)
                {
                    MessageBox.Show("Microsoft Excel could not be started. Please check that your Office installation has Microsoft Excel.");
                    return;
                }

                Excel.Workbook oBook = oApp.Workbooks.Add();

                if(oBook == null)
                {
                    MessageBox.Show("Microsoft Excel failed to create a workbook. Exiting.");
                    return;
                }

                // Get first page
                Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);

                if (oSheet == null)
                {
                    MessageBox.Show("Microsoft Excel failed to create a worksheet. Exiting.");
                    return;
                }

                WriteWorksheetData(oSheet, txtItemName.Text);

                oSheet.SaveAs(path);
                oBook.Close();
                oApp.Quit();
            } 
            else
            {
                if(!File.Exists(path))
                {
                    // There was no point of appending. Just create a new workbook
                    SaveWorkbook(path, false);
                }
                else
                {
                    // Continue append
                    UpdateWorksheet(path);
                }
            }
        }

        private void WriteWorksheetData(Excel.Worksheet oSheet, string name)
        {
            try
            {
                oSheet.Name = txtItemName.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to save workbook. Reason: " + e.Message);
                return;
            }

            // Main Headers
            oSheet.Cells[1, 1] = "Laboratory";
            oSheet.Cells[1, 2] = "Item Name";
            oSheet.Cells[1, 3] = "Address";
            oSheet.Cells[1, 4] = "City";
            oSheet.Cells[1, 5] = "State";
            oSheet.Cells[1, 6] = "Zip code";
            oSheet.Cells[1, 7] = "Quantity";
            oSheet.Cells[1, 8] = "Intial Budget";
            oSheet.Cells[1, 9] = "Intial Cost";
            oSheet.Cells[1, 10] = "Sales Tax";
            oSheet.Cells[1, 11] = "Amount Due Before Tax";
            oSheet.Cells[1, 12] = "Final Cost";
            oSheet.Cells[1, 13] = "Final Amount Due";
            oSheet.Cells[1, 14] = "Final Budget";

            //All Data REF
            oSheet.Cells[2, 1] = txtLaboratory.Text;
            oSheet.Cells[2, 2] = txtItemName.Text;
            oSheet.Cells[2, 3] = txtAddress.Text;
            oSheet.Cells[2, 4] = txtCity.Text;
            oSheet.Cells[2, 5] = txtState.Text;
            oSheet.Cells[2, 6] = txtZipCode.Text;
            oSheet.Cells[2, 7] = txtQuantity.Text;
            oSheet.Cells[2, 8] = txtBudget.Text;
            oSheet.Cells[2, 9] = txtCost.Text;
            oSheet.Cells[2, 10] = dblTax.ToString("C2");
            oSheet.Cells[2, 11] = dblTotal.ToString("C2");
            oSheet.Cells[2, 12] = dblCost.ToString("C2");
            oSheet.Cells[2, 13] = dblNetTotal.ToString("C2");
            oSheet.Cells[2, 14] = dblBudgetTotal.ToString("C2");
        }

        private void UpdateWorksheet(string path)
        {
            Excel.Application oApp = new Excel.Application();
            Excel.Workbook oBook = oApp.Workbooks.Open(path);
            Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Worksheets.Add();
            WriteWorksheetData(oSheet, txtItemName.Text);
            oBook.Close();
            oApp.Quit();
        }
    }
}