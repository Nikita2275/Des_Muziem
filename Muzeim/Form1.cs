using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Muzeim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadExhibits()
        {
            string query = "SELECT ExhibitID, Title, Artist, Year, Description, ExhibitionID FROM Exhibits";
            DataTable exhibitsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Muzeim;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(exhibitsTable);
            }

            dataGridView2.DataSource = exhibitsTable;
        }

        private void LoadExhibitions()
        {
            string query = "SELECT * FROM Exhibitions";
            DataTable exhibitionsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Muzeim;Integrated Security=True"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(exhibitionsTable);
            }

            dataGridView1.DataSource = exhibitionsTable;
        }

        private void btnOpenAddExhibitForm_Click(object sender, EventArgs e)
        {
            AddExhibitForm addExhibitForm = new AddExhibitForm();
            addExhibitForm.ShowDialog(); // или Show() в зависимости от ваших потребностей
            LoadExhibits();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddExhibitionForm addExhibitionForm = new AddExhibitionForm();
            addExhibitionForm.ShowDialog(); // или Show() в зависимости от ваших потребностей
            LoadExhibitions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "muzeimDataSet.Exhibits". При необходимости она может быть перемещена или удалена.
            this.exhibitsTableAdapter.Fill(this.muzeimDataSet.Exhibits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "muzeimDataSet.Exhibitions". При необходимости она может быть перемещена или удалена.
            this.exhibitionsTableAdapter.Fill(this.muzeimDataSet.Exhibitions);

        }
    }

    public class Database
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Muzeim;Integrated Security=True";
        public void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public class Exhibit
    {
        public int ExhibitID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int ExhibitionID { get; set; }
    }

    public class Exhibition
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }

    public class ExhibitManager
    {
        private Database db = new Database();

        public void AddExhibit(Exhibit exhibit)
        {
            string query = "INSERT INTO Exhibits (Title, Artist, Year, Description, ExhibitionID) VALUES (@Title, @Artist, @Year, @Description, @ExhibitionID)";
            db.ExecuteNonQuery(query,
                new SqlParameter("@Title", exhibit.Title),
                new SqlParameter("@Artist", exhibit.Artist),
                new SqlParameter("@Year", exhibit.Year),
                new SqlParameter("@Description", exhibit.Description),
                new SqlParameter("@ExhibitionID", exhibit.ExhibitionID));
        }

        public void AddExhibition(Exhibition exhibition)
        {
            string query = "INSERT INTO Exhibitions (Name, StartDate, EndDate, Description) VALUES (@Name, @StartDate, @EndDate, @Description)";
            db.ExecuteNonQuery(query,
                new SqlParameter("@Name", exhibition.Name),
                new SqlParameter("@StartDate", exhibition.StartDate),
                new SqlParameter("@EndDate", exhibition.EndDate),
                new SqlParameter("@Description", exhibition.Description));
        }

        // Реализуйте аналогичные методы для Update и Delete
    }
}