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
            this.db = new AppContext();
            this.db.Statuses.Load();
            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

            //Скрытие столбцов
            dataGridViewStatuses.Columns["Id"].Visible = false;
            dataGridViewStatuses.Columns["TitlesStatuses"].Visible = false;

            // изменение названий заголовков столбцов
            dataGridViewStatuses.Columns["StatusName"].HeaderText = "Статус аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new();
            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Status status = new Status();
            status.StatusName = formAddStatus.textBoxStatusName.Text;
            db.Statuses.Add(status);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0)
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status status = db.Statuses.Find(id);
            FormAddStatus formAddstatus = new();
            formAddstatus.textBoxStatusName.Text = status.StatusName;

            DialogResult result = formAddstatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            status.StatusName = formAddstatus.textBoxStatusName.Text;
            db.Statuses.Update(status);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status status = db.Statuses.Find(id);

            db.Statuses.Remove(status);
            db.SaveChanges();

            MessageBox.Show("Объект удалён");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }
    }
}
