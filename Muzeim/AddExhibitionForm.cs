using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzeim
{
    public partial class AddExhibitionForm : Form
    {

        private ExhibitManager exhibitionManager = new ExhibitManager();
        public AddExhibitionForm()
        {
            InitializeComponent();
        }

        private void btnAddExhibition_Click(object sender, EventArgs e)
        {
            // Создание новой выставки
            Exhibition exhibition = new Exhibition
            {
                Name = txtExhibitionName.Text,
                StartDate = txtStartDate.Value, // Если используете DateTimePicker
                EndDate = txtEndDate.Value,     // Если используете DateTimePicker
                Description = txtDescription.Text
            };

            // Вызов метода добавления выставки
            try
            {
                exhibitionManager.AddExhibition(exhibition);
                MessageBox.Show("Выставка добавлена успешно!");
                // Очистите текстовые поля после успешного добавления
                txtExhibitionName.Clear();
                txtStartDate.Value = DateTime.Now; // Сбросьте значение на текущее время
                txtEndDate.Value = DateTime.Now;   // Сбросьте значение на текущее время
                txtDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении выставки: {ex.Message}");
            }
        }
    }
}
