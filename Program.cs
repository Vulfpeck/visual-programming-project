using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace VisualProgrammingProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialForm());
        }
    }

    static class DBRepo
    {
        const string connectionString = "datasource=127.0.0.1;port=3306;username=tushar;password=tushar;database=students_db;";
        static MySqlConnection databaseConnection;

        static DBRepo()
        {
            databaseConnection =  new MySqlConnection(connectionString);
        }

        public static void AddStudent(Student stud)
        {
            string query = $"insert into students_list values (\"{stud.StudentId}\", \"{stud.FirstName}\", \"{stud.LastName}\", {stud.Year}, \"{stud.Branch}\", {stud.Cgpa}, \"{stud.Campus}\")";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                Console.WriteLine(reader);
                MessageBox.Show("User added successfully");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }

        internal static List<Student> FetchAllStudents()
        {
            List<Student> studentsList = new List<Student>();
            string query = $"select * from students_list";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 30
            };
            try
            {
                databaseConnection.Open();
                MySqlDataReader  reader = commandDatabase.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student temp = new Student(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt16(3),
                            reader.GetString(4),
                            reader.GetDouble(5),
                            reader.GetString(6)
                        );
                        studentsList.Add(temp);
                        Console.WriteLine(temp.ToString());
                    }
                }
                databaseConnection.Close(); 
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return studentsList;
        }
    }

    class Student
    {
        string student_id;
        string first_name;
        string last_name;
        int year;
        string branch;
        double cgpa;
        string campus;

        public Student()
        {

        }

        public Student(string student_id, string first_name, string last_name, int year, string branch, double cgpa, string campus)
        {
            this.student_id = student_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.year = year;
            this.branch = branch;
            this.cgpa = cgpa;
            this.campus = campus;
        }

        internal bool validateEntries()
        {
            if (this.first_name == "" || this.last_name == "" || this.student_id == "" || this.year == 0 || this.branch == "" || this.cgpa == 0.0 || this.campus == "")
            {
                return false;
            } else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"ID : {this.StudentId}, First Name: {this.FirstName}, Last Name: {this.LastName}, Year: {this.Year}, Branch: {this.branch}, CGPA: {this.Cgpa}, Campus: {this.Campus}";
        }

        public string StudentId { get => student_id; set { student_id = value; } }
        public string FirstName { get => first_name; set { first_name= value; } }
        public string LastName { get => last_name; set { last_name= value; } }
        public int Year { get => year; set { year= value; } }
        public string Branch { get => branch; set { branch= value; } }
        public double Cgpa{ get => cgpa; set { cgpa= value; } }
        public string Campus { get => campus; set { campus = value; } }
    }
}
