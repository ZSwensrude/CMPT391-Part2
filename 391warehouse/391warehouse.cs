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
            String connectionString = "Server =LAPTOP-L6HCRV5P; Database = 391warehouse; Trusted_Connection = yes;";
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
            this.AcceptButton = submit_btn;
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

        private void submit_btn_Click(object sender, EventArgs e)
        {

            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = "SELECT SUM(no_of_course) as total_courses FROM Fact F";

            //use these flags to see if there is anything to search in those boxes
            Boolean date_search = false;
            Boolean course_search = false;
            Boolean instructor_search = false;


            //ADD DATE SEARCH HERE  "+= Date D"
            string year_start = yearStart.Text;
            string year_end = yearEnd.Text;
            string term = termCombo.Text;
            int invalid_flag = 0;

            if (year_start.Length > 0 || year_end.Length > 0 || term.Length > 0)
            {
                myCommand.CommandText += ", Date D";
                date_search = true;
            }

            //Course lookup
            string course_title = courseTitle.Text;
            string selected_dept = courseDept.Text;
            string selected_credits = courseCredits.GetItemText(courseCredits.SelectedItem);
            
            if (course_title.Length > 0 || selected_dept.Length > 0 || selected_credits.Length > 0)
            {
                myCommand.CommandText += ", Course C";
                course_search= true;
            }



            //ADD INSTRUCTOR HERE "+= Instructor I"
            //instuctor lookup
            string instr_Name = instructorName.Text;
            string instr_Title = instructorTitle.GetItemText(instructorTitle.SelectedItem); ;
            string instr_Dept = instructorDept.GetItemText(instructorDept.SelectedItem);
            string intr_Gender = instructorGender.GetItemText(instructorGender.SelectedItem);

            if (instr_Name.Length > 0 || instr_Title.Length > 0 || instr_Dept.Length > 0 || intr_Gender.Length > 0)
            { 
                myCommand.CommandText += ", Instructor I";
                instructor_search = true;
            }



            //Now add to the search string
            //add initial where statment if there is anything to search for
            if (date_search || course_search || instructor_search)
            {
                myCommand.CommandText += " where";

                if (date_search)
                {
                    myCommand.CommandText += " F.DID = D.DID";
                }
                if (course_search)
                {
                    //check if there was already a join to see if we need to add an "and" to the query
                    if (!date_search)
                    {
                        myCommand.CommandText += " F.CID = C.CID";
                    }
                    else
                    {
                        myCommand.CommandText += " and F.CID = C.CID";
                    }
                }
                if (instructor_search)
                {
                    //check if there was already a join to see if we need to add an "and" to the query
                    if (!date_search && !course_search)
                    {
                        myCommand.CommandText += " F.IID = I.IID";
                    }
                    else
                    {
                        myCommand.CommandText += " and F.IID = I.IID";
                    }
                }
            }

            //Now add the specific parameters if needed
            //if (date_search)
            //do thing
            if (date_search)
            {
                // reset flag to 0 
                invalid_flag = 0;

                // if there is both a start and end date
                if (year_start.Length > 0 && year_end.Length > 0)
                {
                    //  if the end date is less than the start date (ex. start = 2001, end = 1990) throw an error message and switch flag
                    if (int.Parse(year_end) < int.Parse(year_start))
                    {
                        MessageBox.Show("End date lower than start date, please enter a valid selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        invalid_flag = 1;
                    }
                    // otherwise find values between range
                    else
                    {
                        // Check if a term other than "All" is specified
                        if (term.Length > 0 && term != "All")
                        {
                            myCommand.CommandText += " and D.year >= " + int.Parse(year_start) + " and D.year <= " + int.Parse(year_end) + " and D.semester = '" + term + "'";
                        }
                        // otherwise find results for all terms
                        else
                        {
                            myCommand.CommandText += " and D.year >= " + int.Parse(year_start) + " and D.year <= " + int.Parse(year_end);
                        }

                    }
                }
                // if there is only a start date
                else if (year_start.Length > 0)
                {

                    // Check if a term other than "All" is specified
                    if (term.Length > 0 && term != "All")
                    {
                        myCommand.CommandText += " and D.year >= " + int.Parse(year_start) + " and D.semester = '" + term + "'";
                    }
                    // otherwise find results for all terms
                    else
                    {
                        myCommand.CommandText += " and D.year >= " + int.Parse(year_start);
                    }
                }
                // if there is only an end date
                else if (year_end.Length > 0)
                {

                    // Check if a term other than "All" is specified
                    if (term.Length > 0 && term != "All")
                    {
                        myCommand.CommandText += " and D.year <= " + int.Parse(year_end) + " and D.semester = '" + term + "'";
                    }
                    // otherwise find results for all terms
                    else
                    {
                        myCommand.CommandText += " and D.year <= " + int.Parse(year_end);
                    }
                }
                // if there is only a term
                else if (term.Length > 0 && term != "ALL")
                {
                    myCommand.CommandText += " and D.semester = '" + term + "'";
                }
            }

            if (course_search)
            {
                if (course_title.Length > 0)
                {
                    myCommand.CommandText += " and C.title = '" + course_title + "'";
                }
                if (selected_dept.Length > 0)
                {
                    myCommand.CommandText += " and C.Dept_Name = '" + selected_dept + "'";
                }
                if (selected_credits.Length > 0)
                {
                    myCommand.CommandText += " and C.credits = " + selected_credits;
                }
            }

            //if (instructor_search)
            //do thing 

            if (instructor_search)
            {
                if (instr_Name.Length > 0)
                {
                    myCommand.CommandText += " and I.name = '" + instr_Name + "'";
                }
                if (instr_Title.Length > 0)
                {
                    myCommand.CommandText += " and I.title = '" + instr_Title + "'";
                }
                if (instr_Dept.Length > 0)
                {
                    myCommand.CommandText += " and I.dept = '" + instr_Dept + "'";
                }
                if (intr_Gender.Length > 0)
                {
                    myCommand.CommandText += " and I.gender = '" + intr_Gender + "'";
                }
            }



            MessageBox.Show(myCommand.CommandText);

            try
            {
                // Throw an exception to end execution if end date is less than start date
                if (invalid_flag != 0) throw new ArgumentException("Invalid date selection!");

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    num_display.Text = myReader["total_courses"] == DBNull.Value ? "0" : myReader["total_courses"].ToString();
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            UpdateTotalCoursesDisplay();
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = null;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).Text = null;
                }
            }
        }
    }
}
