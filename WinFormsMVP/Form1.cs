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

        private void button6_Click(object sender, EventArgs e)
        {
            _modelTwo.FirstName = "John";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _modelTwo.FirstName = "Paul";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _modelTwo.FirstName = "Jane";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _modelThree.FirstName = "John";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _modelThree.FirstName = "Paul";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _modelThree.FirstName = "Jane";
        }
    }
}
