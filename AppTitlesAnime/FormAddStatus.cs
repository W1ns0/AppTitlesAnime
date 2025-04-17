using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddStatus : Form
    {
        private AppContext db;
        public FormAddStatus()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Загрузка базы данных
            this.db = new AppContext(); // Взаимодействие с базой данных
            this.db.Statuses.Load(); //  Загружает данные о статусах из базы данных в локальный кэш
        }

        private void TextBoxStatusName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text)) //Если поле для ввода пустое
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; // Блокируем кнопку сохранить
            }
            else
            {
                errorProvider.Clear(); //Если поле для ввода не пустое, то убираем ошибку
                btnSaveChanges.Enabled = true; // Разблокируем кнопку сохранить
            }

            string newStatusAnime = textBoxStatusName.Text; // Записывает текст введёный в textBoxStatusName

            bool exists = db.Statuses.Any(t => t.StatusName.ToLower() == newStatusAnime.ToLower()); // Проверяет есть ли этот элемент в базе, или нет приводя всё к нижнему регистру

            if (exists)
            {
                btnSaveChanges.Enabled = false;
                errorProvider.SetError(textBoxStatusName, "Поле должно быть уникальным");
            } else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxStatusName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text)) //Если поле для ввода пустое
            {
                errorProvider.SetError(textBoxStatusName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; // Блокируем кнопку сохранить
            }
            else
            {
                errorProvider.Clear(); //Если поле для ввода не пустое, то убираем ошибку
                btnSaveChanges.Enabled = true; // Разблокируем кнопку сохранить
            }           
        }
    }
}
