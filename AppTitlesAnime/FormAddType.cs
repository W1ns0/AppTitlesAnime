using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddType : Form
    {
        private AppContext db;

        public FormAddType()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
            this.db = new AppContext();
            this.db.Types.Load(); 
        }

        private void TextBoxTypeName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text)) 
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false; 
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true; 
            }

            string newTypeAnime = textBoxTypeName.Text; 

            bool exists = db.Types.Any(t => t.TypeName.ToLower() == newTypeAnime.ToLower()); 

            if (exists)
            {
                errorProvider.SetError(textBoxTypeName, "Такой жанр уже есть в списке");
                btnSaveChanges.Enabled = false;

            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text)) 
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым");
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
