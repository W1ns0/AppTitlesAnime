namespace AppTitlesAnime
{
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAddType_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTypeName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым!");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void textBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым!");
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
