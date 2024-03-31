namespace WinformsMVPMDI
{
    public partial class MainMDIView : Form
    {
        public MainMDIView()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleView form = new() { MdiParent = this };
            _ = new PeoplePresenter(form);
            form.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
