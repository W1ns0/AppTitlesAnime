namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        public FormListGenres()
        {
            InitializeComponent();
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new FormAddGenre();
            formAddGenre.ShowDialog();
        }
    }
}
