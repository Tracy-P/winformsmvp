namespace WinFormsMVP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxFirstName.DataBindings.Add("Text", _model, "FirstName");
            textBox1.DataBindings.Add("Text", _modelTwo, "FirstName");
            textBox2.Bind(_modelThree, "FirstName");
        }
        private readonly Model _model = new();
        private readonly ModelTwo _modelTwo = new();
        private readonly ModelTwo _modelThree = new();

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
        private void Button4_Click(object sender, EventArgs e)
        {
            _modelTwo.FirstName = "Jane";
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            _modelTwo.FirstName = "Paul";
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            _modelTwo.FirstName = "John";
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            _modelThree.FirstName = "Jane";
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            _modelThree.FirstName = "Paul";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            _modelThree.FirstName = "John";
        }
    }
}
