using System.ComponentModel;
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

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new FormAddStatus();
            formAddStatus.ShowDialog();
        }
    }
}
