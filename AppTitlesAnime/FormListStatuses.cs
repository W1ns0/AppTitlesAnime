using System.ComponentModel;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormListStatus : Form
    {
        private AppContext db;

        public FormListStatus()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
            this.db = new AppContext(); // Взаимодействие с базой данных
            this.db.Statuses.Load(); //  Загружает данные о статусах из базы данных в локальный кэш
            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Устанавливает источник данных для dataGridViewStatuses, чтобы он отображал статусы, отсортированные по имени статуса

            //Скрытие столбцов
            dataGridViewStatuses.Columns["Id"].Visible = false;
            dataGridViewStatuses.Columns["TitlesStatuses"].Visible = false;

            // изменение названий заголовков столбцов
            dataGridViewStatuses.Columns["StatusName"].HeaderText = "Статус аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose(); // Освобождает ресурсы, связанные с контекстом базы данных, если он существует
            this.db = null; // Устанавливает db в null, чтобы избежать утечек памяти
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddUpdateStatus formAddStatus = new(); // Создает новый экземпляр формы для добавления статуса
            DialogResult result = formAddStatus.ShowDialog(this); // Вызывает диалоговое окно

            if (result == DialogResult.Cancel) // если пользователь нашёл на Отмена, то return закрывает программу
                return;

            Status status = new Status();
            status.StatusName = formAddStatus.textBoxStatusName.Text;
            db.Statuses.Add(status); // Добавляет новый статус в контекст базы данных
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Обновляет список
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0) // Проверяет, выбраны ли строки в dataGridViewStatuses. Если нет, то закрывает программу
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index; // Получает индекс выбранной строки
            short id = 0; // Объявляет переменную для хранения идентификатора статуса

            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id); // Пробует преобразовать значение из первой ячейки выбранной строки в short и сохраняет результат в converted            
            if (!converted) // если преобразовать не получилось, то выходит из метода
                return;

            Status status = db.Statuses.Find(id); // Находит статус в базе данных по идентификатору id
            FormAddUpdateStatus formAddstatus = new(); // Создает новый экземпляр формы для редактирования статуса
            formAddstatus.textBoxStatusName.Text = status.StatusName; // Устанавливает текстовое поле формы значением имени статуса, чтобы пользователь мог его изменить

            DialogResult result = formAddstatus.ShowDialog(this); // Показывает форму как модальное диалоговое окно и получает результат

            if (result == DialogResult.Cancel) // Если пользоватль нажал Отмена, то программа закрывается
                return;

            status.StatusName = formAddstatus.textBoxStatusName.Text; // Обновляет имя статуса на введенное в текстовом поле
            db.Statuses.Update(status); // Обновляет статус в контексте базы данных
            db.SaveChanges(); 

            MessageBox.Show("Объект изменён");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Обновляет список
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0) // Проверяет, выбраны ли строки в dataGridViewStatuses. Если нет, то закрывает программу
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index; // Получает индекс выбранной строки
            short id = 0; // Объявляет переменную для хранения идентификатора статуса

            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id); // Пробует преобразовать значение из первой ячейки выбранной строки в short и сохраняет результат в converted
            if (!converted)
                return;

            Status status = db.Statuses.Find(id); // Находит статус в базе данных по идентификатору id

            db.Statuses.Remove(status); // Удаляет статус из контекста базы данных
            db.SaveChanges();

            MessageBox.Show("Объект удалён");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); // Обновляет список
        }
    }
}
