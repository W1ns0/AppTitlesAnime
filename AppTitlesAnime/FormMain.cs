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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowGenres_Click(object sender, EventArgs e)
        {
            FormListGenres formListGenres = new FormListGenres();
            formListGenres.Show();
        }
    }
}
