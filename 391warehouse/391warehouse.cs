using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _391warehouse
{
    public partial class Warehouse : Form
    {

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Warehouse()
        {
            InitializeComponent();
            ///////////////////////////////
            String connectionString = "Server = DESKTOP-JSPRNKM; Database = 391warehouse; Trusted_Connection = yes;";
            // Need to change server to your personal SQL server before using (and Database if different)
            // Adam: DESKTOP-SO5MCT3
            // Zach: LAPTOP-HUT8634L
            // Jasper: LAPTOP-JPNKMR DESKTOP-JSPRNKM
            // Salah: 
            // Brittney: LAPTOP-L6HCRV5P

            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            UpdateTotalCoursesDisplay();
        }

        private void UpdateTotalCoursesDisplay()
        {
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = "SELECT SUM(no_of_course) as total_courses FROM Fact;";

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    num_display.Text = myReader["total_courses"].ToString();
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                // Load the XML file into an XmlDocument object
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(selectedFileName);

                // Get the root element of the XML document which should be <University_upload_**date**>
                XmlElement rootElement = xmlDocument.DocumentElement;

                // Get the child elements of the root element
                XmlNodeList childNodes = rootElement.ChildNodes;

                foreach (XmlNode childNode in childNodes)
                {
                    if (childNode.Name == "Instructor")
                    {
                        int iid = int.Parse(childNode.SelectSingleNode("IID").InnerText);
                        string name = childNode.SelectSingleNode("Name").InnerText;
                        string title = childNode.SelectSingleNode("Title").InnerText;
                        string dept = childNode.SelectSingleNode("Dept").InnerText;
                        string gender = childNode.SelectSingleNode("Gender").InnerText;

                        ProcessInstructor(iid, name, title, dept, gender);

                    }
                    else if (childNode.Name == "Date")
                    {
                        int did = int.Parse(childNode.SelectSingleNode("DID").InnerText);
                        int year = int.Parse(childNode.SelectSingleNode("Year").InnerText);
                        string semester = childNode.SelectSingleNode("Semester").InnerText;

                        ProcessDate(did, year, semester);
                    }
                    else if (childNode.Name == "Course")
                    {
                        int cid = int.Parse(childNode.SelectSingleNode("CID").InnerText);
                        string title = childNode.SelectSingleNode("Title").InnerText;
                        int credits = int.Parse(childNode.SelectSingleNode("Credits").InnerText);
                        string deptName = childNode.SelectSingleNode("Dept_Name").InnerText;

                        ProcessCourse(cid, title, credits, deptName);
                    }
                    else if (childNode.Name == "Fact")
                    {
                        int iid = int.Parse(childNode.SelectSingleNode("IID").InnerText);
                        int cid = int.Parse(childNode.SelectSingleNode("CID").InnerText);
                        int did = int.Parse(childNode.SelectSingleNode("DID").InnerText);
                        int no_of_course = int.Parse(childNode.SelectSingleNode("no_of_course").InnerText);

                        ProcessFact(iid, cid, did, no_of_course);
                    }
                }
                MessageBox.Show("Successfully imported XML file.");
            }
        }

        private void ProcessDate(int did, int year, string semester)
        {
            try
            {
                string insertCommand = "INSERT INTO Date (DID, Year, Semester) VALUES (@DID, @Year, @Semester)";
                using (SqlCommand command = new SqlCommand(insertCommand, myCommand.Connection))
                {
                    command.Parameters.AddWithValue("@DID", did);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Semester", semester);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing XML file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessInstructor(int iid, string name, string title, string dept, string gender)
        {
            try
            {
                string insertCommand = "INSERT INTO Instructor (IID, Name, Title, Dept, Gender) VALUES (@IID, @Name, @Title, @Dept, @Gender)";
                using (SqlCommand command = new SqlCommand(insertCommand, myCommand.Connection))
                {
                    command.Parameters.AddWithValue("@IID", iid);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Dept", dept);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing XML file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessCourse(int cid, string title, int credits, string deptName)
        {
            try
            {
                string insertStatement = "INSERT INTO Course (CID, title, credits, Dept_Name) VALUES (@cid, @title, @credits, @deptName)";
                using (SqlCommand command = new SqlCommand(insertStatement, myCommand.Connection))
                {
                    command.Parameters.AddWithValue("@cid", cid);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@credits", credits);
                    command.Parameters.AddWithValue("@deptName", deptName);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing XML file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessFact(int iid, int cid, int did, int no_of_course)
        {
            try
            {
                string insertStatement = "INSERT INTO Fact (IID, CID, DID, no_of_course) VALUES (@iid, @cid, @did, @no_of_course)";
                using (SqlCommand command = new SqlCommand(insertStatement, myCommand.Connection))
                {
                    command.Parameters.AddWithValue("@iid", iid);
                    command.Parameters.AddWithValue("@cid", cid);
                    command.Parameters.AddWithValue("@did", did);
                    command.Parameters.AddWithValue("@no_of_course", no_of_course);
                    command.ExecuteNonQuery();
                }
                UpdateTotalCoursesDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing XML file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
