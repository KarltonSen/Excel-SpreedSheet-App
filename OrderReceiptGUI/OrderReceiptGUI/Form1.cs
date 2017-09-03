using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace OrderReceiptGUI
{
    public partial class frmOrderReceiptGUI : Form
    {
        static double dbltax = 0.0;
        static double dbltotal = 0.0;
        static double dblNetTotal = 0.0;
        static double dblBudget;
        static double dblcost;
        static double dblCostTotal = 0.0;
        static double dblBudgetTotal = 0.0;
        static bool inputMade = false;
        static bool alreadyDisplayed = false;

        static string NewFileName2 = null;
       



        public class SavedtoFile
        {
            public string ItemName { get; set; }
            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string Quantity { get; set; }
            public string Budget { get; set; }
            public string Cost { get; set; }
            public string TotalCost { get; set; }
            public string finalBudget { get; set; }
            public string dblNetTotal { get; set; }
            public string dblBudgetTotal { get; set; }
            public string dbltax { get; set; }
            public string dbltotal { get; set; }

        }



        public frmOrderReceiptGUI()
        {
            InitializeComponent();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lblName.Visible = true; txtName.Visible = true;
            lblStreetAddress.Visible = true; txtAddress.Visible = true;
            lblState.Visible = true; txtState.Visible = true;
            lblQuantity.Visible = true; txtQuantity.Visible = true;
            lblZipcode.Visible = true; txtZipCode.Visible = true;
            txtCity.Visible = true; lblCity.Visible = true;
            inputMade = true; lblBudgetPrompt.Visible = true; txtBudget.Visible = true; lblCost.Visible = true; txtCost.Visible = true;
            lblLaboratory.Visible = true; txtlaboratory.Visible = true;
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alreadyDisplayed == false && inputMade == true)
            {
                lblDisplay.Visible = true; lblOutputAll.Visible = true;
                lblOutputAll.Text += "The Laboratory name is : " + txtlaboratory.Text;
                lblOutputAll.Text += "\n\n The item name is : " + txtName.Text;
                lblOutputAll.Text += " \n\n Your Street Address is : " + txtAddress.Text;
                lblOutputAll.Text += " \n\n Your City is : " + txtCity.Text;
                lblOutputAll.Text += " \n\n Your State is : " + txtState.Text;
                lblOutputAll.Text += " \n\n Your Zipcode is : " + txtZipCode.Text;
                lblOutputAll.Text += " \n\n Your Quantity is : " + txtQuantity.Text;
                lblOutputAll.Text += "\n\n YOUR INTIAL BUDGET IS : " + txtBudget.Text;
                lblOutputAll.Text += "\n\n The Cost of the Item is: " + txtCost.Text;
                try
                {
                    dbltotal = Convert.ToInt32(txtQuantity.Text);
                    dblBudget = Convert.ToInt32(txtBudget.Text);
                    dblcost = Convert.ToInt32(txtCost.Text);
                    lblOutputAll.Text += "\n\n Amount Due Before Tax : " + dbltotal.ToString("C");
                    dbltax = 0.0 * dbltotal;
                    lblOutputAll.Text += "\n\n Sales Tax " + dbltax.ToString("C");
                    dblNetTotal = dbltotal + dbltax;
                    dblCostTotal = dblcost * dbltotal;
                    dblBudgetTotal = dblBudget - dblNetTotal - dblCostTotal;
                    lblOutputAll.Text += "\n\n The Final Cost is: " + dblCostTotal.ToString("C");
                    lblOutputAll.Text += "\n\n Final Amount Due : " + dblNetTotal.ToString("C");
                    lblOutputAll.Text += "\n\n Final Budget is : " + dblBudgetTotal.ToString("C");
                    lblOutputAll.Text += "\n\n\n PLEASE SAVE ALL DATA before adding new Data ";
                    alreadyDisplayed = true;


                }
                catch
                {
                    MessageBox.Show("Enter all data");
                    lblOutputAll.Text += "Try again" + "User Error";
                    lblOutputAll.Text = "";
                    dblNetTotal = 0; dbltax = 0; dbltotal = 0; dblBudgetTotal = 0; dblCostTotal = 0;
                    txtQuantity.Text = "";
                    txtBudget.Text = "";
                    txtCost.Text = "";
                }

            }
            else
            {
                //MessageBox.Show("Enter all data right");
                //dblNetTotal = 0; dbltax = 0; dbltotal = 0; dblBudgetTotal = 0; dblCostTotal = 0;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtlaboratory.Text = "";
            txtQuantity.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            txtQuantity.Text = "";
            txtCost.Text = "";
            txtBudget.Text = "";
            lblOutputAll.Text = "";
            dblNetTotal = 0; dbltax = 0; dbltotal = 0; dblBudgetTotal = 0; dblCostTotal = 0;
            inputMade = false;
            alreadyDisplayed = false;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program: NCAT Order Receipt \n\n"
                + " Author: Joshua Karlton-Senaye \n\n " +
                "Director: Dr.William");

        }

        private void addANewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtlaboratory.Text = "";
            txtQuantity.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            txtQuantity.Text = "";
            txtBudget.Text = "";
            txtCost.Text = "";
            lblOutputAll.Text = "";
            dblNetTotal = 0; dbltax = 0; dbltotal = 0; dblBudgetTotal = 0; dblCostTotal = 0;



        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            lblOutputAll.Text += "\n\n All Data Saved";
            //  C: \Users\the\OneDrive\A & T Check
            //  C: \Users\the\OneDrive - Cabarrus County Schools\P3 - BP12 - jsenaye9631
            string NewfileName = @"C:\Users\the\OneDrive\A&T Check\NCAT Order Receipt.xls";
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string filename = Path.Combine(path, NewfileName); 
         //   System.IO.StreamWriter file = new System.IO.StreamWriter(NewfileName);
          //  file.WriteLine(NewfileName);


           if ((File.Exists(NewfileName)))
          {
              File.Delete(NewfileName);
            }
         

          
            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;

            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
            // Main Headers

            oSheet.Cells[1, 1] = "Item Name";
            oSheet.Cells[1, 2] = "Item Name";
            oSheet.Cells[1, 3] = "Address";
            oSheet.Cells[1, 4] = "City";
            oSheet.Cells[1, 5] = "State";
            oSheet.Cells[1, 6] = "ZipCode Area";
            oSheet.Cells[1, 7] = "Quantity";
            oSheet.Cells[1, 8] = "Intial Budget";
            oSheet.Cells[1, 9] = "Intial Cost";
            oSheet.Cells[1, 10] = "Sales Tax";
            oSheet.Cells[1, 11] = "Amount Due Before Tax";
            oSheet.Cells[1, 12] = "Final Cost";
            oSheet.Cells[1, 13] = "Final Amount Due";
            oSheet.Cells[1, 14] = "Final Budget";

            //All Data REF
            oSheet.Cells[2, 1] = txtlaboratory.Text;
            oSheet.Cells[2, 2] = txtName.Text;
            oSheet.Cells[2, 3] = txtAddress.Text;
            oSheet.Cells[2, 4] = txtCity.Text;
            oSheet.Cells[2, 5] = txtState.Text;
            oSheet.Cells[2, 6] = txtZipCode.Text;
            oSheet.Cells[2, 7] = txtQuantity.Text;
            oSheet.Cells[2, 8] = txtBudget.Text;
            oSheet.Cells[2, 9] = txtCost.Text;
            oSheet.Cells[2, 10] = dbltax.ToString("C");
            oSheet.Cells[2, 11] = dbltotal.ToString("C");
            oSheet.Cells[2, 12] = dblcost.ToString("C");
            oSheet.Cells[2, 13] = dblNetTotal.ToString("C");
            oSheet.Cells[2, 14] = dblBudgetTotal.ToString("C");


         
            //oBook.SaveAs(NewfileName);
           // file.Close();

            oBook.Close();
            oApp.Quit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Misclicked
        }

        private void outputNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alreadyDisplayed == true && inputMade == true)
            {
                lblDisplay.Visible = true; lblOutputAll.Visible = true;
                lblOutputAll.Text += "The Laboratory name is : " + txtlaboratory.Text;
                lblOutputAll.Text += "\n\n The item name is : " + txtName.Text;
                lblOutputAll.Text += " \n\n Your Street Address is : " + txtAddress.Text;
                lblOutputAll.Text += " \n\n Your City is : " + txtCity.Text;
                lblOutputAll.Text += " \n\n Your State is : " + txtState.Text;
                lblOutputAll.Text += " \n\n Your Zipcode is : " + txtZipCode.Text;
                lblOutputAll.Text += " \n\n Your Quantity is : " + txtQuantity.Text;
                lblOutputAll.Text += "\n\n The Cost of the Item is: " + txtCost.Text;
                try
                {
                    dbltotal =Convert.ToInt32(txtQuantity.Text);
                    dblBudget =Convert.ToInt32(txtBudget.Text);
                    dblcost = Convert.ToInt32(txtCost.Text);
                    lblOutputAll.Text += "\n\n Amount Due Before Tax : " + dbltotal.ToString("C");
                    dbltax = 0.0 * dbltotal;
                    lblOutputAll.Text += "\n\n Sales Tax " + dbltax.ToString("C");
                    dblNetTotal = dbltotal + dbltax;
                    dblCostTotal = dblcost * dbltotal;
                    dblBudgetTotal = dblBudget - dblNetTotal - dblCostTotal;
                    lblOutputAll.Text += "\n\n The Final Cost is: " + dblCostTotal.ToString("C");
                    lblOutputAll.Text += "\n\n Final Amount Due : " + dblNetTotal.ToString("C");
                    lblOutputAll.Text += "\n\n Final Budget is : " + dblBudgetTotal.ToString("C");
                    lblOutputAll.Text += "\n\n\n PLEASE SAVE ALL DATA before adding new Data ";
                    lblOutputAll.Text += "\n\n Please Save all data before copying the Original File";
                    alreadyDisplayed = true;


                }
                catch
                {
                    MessageBox.Show("Enter all data");
                    txtQuantity.Text = "";
                    txtName.Text = "";
                    txtCity.Text = "";
                    txtAddress.Text = "";
                    txtState.Text = "";
                    txtZipCode.Text = "";
                    txtQuantity.Text = "";
                    txtBudget.Text = "";
                    txtCost.Text = "";
                    lblOutputAll.Text = "";
                    dblNetTotal = 0; dbltax = 0; dbltotal = 0; dblBudgetTotal = 0; dblCostTotal = 0;
                }

            }
            else
            {
                MessageBox.Show("Enter all data right");
                txtQuantity.Text = "";
                txtName.Text = "";
                txtCity.Text = "";
                txtAddress.Text = "";
                txtState.Text = "";
                txtZipCode.Text = "";
                txtQuantity.Text = "";
                txtBudget.Text = "";
                txtCost.Text = "";
                lblOutputAll.Text = "";
                dblNetTotal = 0; dbltax = 0; dbltotal = 0; dblBudgetTotal = 0; dblCostTotal = 0;
            }
        }

        private void saveNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel | .xls"; 
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                NewFileName2= Path.GetDirectoryName(NewFileName2);

            }
         

// stored file path 

           
            string connectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0'", NewFileName2);


            using (OleDbConnection cn = new OleDbConnection(connectionString))
            {
                lblOutputAll.Text += "\n\n Please Save all data before copying the Original File";

                if (File.Exists(NewFileName2))
                {

                    cn.Open();
                    OleDbCommand cmd1 = new OleDbCommand("INSERT INTO [Sheet1$] " +
                         "([laboratory][Item Name],[Address],[City],[State],[ZipCode Area],[Quantity],[Intial Budget],[Intial Cost],[Sales Tax],[Amount Due Before Tax],[Final Cost],[Final Amount Due],[Final Budget]) " +
                         "VALUES(@value1,@value2, @value3, @value4, @value5,@value6,@value7,@value8,@value9,@value10,@value11,@value12,@value13,@value14)", cn);
                    cmd1.Parameters.AddWithValue("@value1", txtlaboratory.Text);
                    cmd1.Parameters.AddWithValue("@value2", txtName.Text);
                    cmd1.Parameters.AddWithValue("@value3", txtAddress.Text);
                    cmd1.Parameters.AddWithValue("@value4", txtCity.Text);
                    cmd1.Parameters.AddWithValue("@value5", txtState.Text);
                    cmd1.Parameters.AddWithValue("@value6", txtZipCode.Text);
                    cmd1.Parameters.AddWithValue("@value7", txtQuantity.Text);
                    cmd1.Parameters.AddWithValue("@value8", txtBudget.Text);
                    cmd1.Parameters.AddWithValue("@value9", txtCost.Text);
                    cmd1.Parameters.AddWithValue("@value10", dbltax.ToString("C"));
                    cmd1.Parameters.AddWithValue("@value11", dbltotal.ToString("C")) ;
                    cmd1.Parameters.AddWithValue("@value12", dblcost.ToString("C"));
                    cmd1.Parameters.AddWithValue("@value13", dblNetTotal.ToString("C"));
                    cmd1.Parameters.AddWithValue("@value14", dblBudgetTotal.ToString("C"));
                   
                    cmd1.ExecuteNonQuery();

                   
                }

                cn.OpenAsync();

                cn.Close();

               



                lblOutputAll.Text += "\n\n\n Data Saved";
            }

        }
       private static void OpenSqlConnection(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }


        private void copyOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\NCAT_Order_Receipt.xls";

            string destination = @"C:\Copied_Origrinal_File\NCAT_Order_Receipt.xls";


            File.Delete(fileName);

            File.Copy(fileName, destination);

            MessageBox.Show("Data Copied");

        }

        private void moveCopiedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\NCAT_Order_Receipt.xls";
            string NewDestination = @"C:\Copied_Origrinal_File\\Older_Versions";

            File.Move(fileName, NewDestination);

        }

        private void deleteCopiedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string destination = @"C:\Copied_Origrinal_File\NCAT_Order_Receipt.xls";

            File.Delete(destination);
            MessageBox.Show("Original File in Copyied File has been Deleted");
        }
    }
}











