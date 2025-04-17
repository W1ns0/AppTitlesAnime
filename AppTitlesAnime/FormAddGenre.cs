using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form
    {
        private AppContext db;
        public FormAddGenre()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
            this.db = new AppContext(); 
            this.db.Genres.Load();
        }

        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым"); 
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear(); 
                btnSaveChanges.Enabled = true; 
            }

            string newGenreAnime = textBoxGenreName.Text;

            bool exists = db.Genres.Any(t => t.GenreName == newGenreAnime);

            if (exists)
            {
                errorProvider.SetError(textBoxGenreName, "Поле должно быть уникальным");
                btnSaveChanges.Enabled = false;                
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxGenreName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text)) 
            {
                errorProvider.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; 
            }
            else
            {
                errorProvider.Clear(); 
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
