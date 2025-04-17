namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void BtnShowGenres_Click(object sender, EventArgs e)
        {
            FormListGenres formListGenres = new FormListGenres();
            formListGenres.Show();
        }

        private void BtnShowStatuses_Click(object sender, EventArgs e)
        {
            FormListStatus formListStatus = new FormListStatus(); // Создаем новый экземпляр формы Статус
            formListStatus.Show(); // Открываем форму
        }
    }
}
