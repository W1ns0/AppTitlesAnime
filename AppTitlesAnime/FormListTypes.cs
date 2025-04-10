using System.ComponentModel;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
using Type = AppTitlesAnime.Models.Type;

namespace AppTitlesAnime
{
    public partial class FormListTypes : Form
    {
        private AppContext db;
        public FormListTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Types.Load();
            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            //скрытие столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewTypes.Columns["TypeName"].HeaderText = "Тип аниме";

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddtype = new FormAddType();
            DialogResult result = formAddtype.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Type type = new Type();
            type.TypeName = formAddtype.textBoxTypeName.Text;

            db.Types.Add(type);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }

        private void BtnUpdateType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)         
                return;

            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Type type = db.Types.Find(id);
            FormAddType formAddtype = new();
            formAddtype.textBoxTypeName.Text = type.TypeName;

            DialogResult result = formAddtype.ShowDialog(this);

            if(result == DialogResult.Cancel) 
                return;

            type.TypeName = formAddtype.textBoxTypeName.Text;
            db.Types.Update(type);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dataGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
        }
    }
}
