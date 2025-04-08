namespace AppTitlesAnime
{
    public partial class FormListTypes : Form
    {
        public FormListTypes()
        {
            InitializeComponent();
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddtype = new FormAddType();
            formAddtype.ShowDialog();
        }
    }
}
