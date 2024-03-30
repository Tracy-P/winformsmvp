namespace WinFormsMVP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxFirstName.DataBindings.Add("Text", _model, "FirstName");
        }
        private readonly Model _model = new();

        private void Button1_Click(object sender, EventArgs e)
        {
            _model.FirstName = "John";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _model.FirstName = "Paul";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _model.FirstName = "Jane";
        }
    }
}
