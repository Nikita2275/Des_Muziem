using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzeim
{
    public partial class AddExhibitForm : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Muzeim;Integrated Security=True";

        private ExhibitManager exhibitManager = new ExhibitManager();
        public AddExhibitForm()
        {
            InitializeComponent();
        }

        public bool ExhibitionExists(int exhibitionId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Exhibitions WHERE ExhibitionID = @ExhibitionID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExhibitionID", exhibitionId);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnAddExhibit_Click(object sender, EventArgs e)
        {
            // Создание нового экспоната
            Exhibit exhibit = new Exhibit
            {
                Title = txtTitle.Text,
                Artist = txtArtist.Text,
                Year = int.TryParse(txtYear.Text, out int year) ? year : 0,
                Description = txtDescription.Text,
                ExhibitionID = int.TryParse(txtExhibitionID.Text, out int exhibitionId) ? exhibitionId : 0
            };

            if (!ExhibitionExists(exhibit.ExhibitionID))
            {
                MessageBox.Show("Выставка с указанным ID не найдена.");
                return;
            }

            // Вызов метода добавления экспоната
            try
            {
                exhibitManager.AddExhibit(exhibit);
                MessageBox.Show("Экспонат добавлен успешно!");
                // Очистите текстовые поля после успешного добавления
                txtTitle.Clear();
                txtArtist.Clear();
                txtYear.Clear();
                txtDescription.Clear();
                txtExhibitionID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении экспоната: {ex.Message}");
            }
        }
    }
}
