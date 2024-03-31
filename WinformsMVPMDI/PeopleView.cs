using System.ComponentModel;
using WinformsMVPMDI.BaseLIbrary;
using WinformsMVPMDI.Models;

namespace WinformsMVPMDI
{
    public partial class PeopleView : BaseForm, IPeopleView
    {
        public PeopleView()
        {
            InitializeComponent();
            _person.PropertyChanged += PersonChanged;
            textBoxFirstName.Bind(_person, nameof(_person.FirstName));
        }

        private void PersonChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_person.FirstName)) { }
        }

        private readonly Person _person = new();
        public event EventHandler<string>? ButtonJohnClicked;
        public event EventHandler<string>? ButtonPaulClicked;
        public event EventHandler<string>? ButtonJaneClicked;
        public void LoadData(Person person)
        {
            _person.FirstName = person.FirstName;
        }

        private void ButtonJohn_Click(object sender, EventArgs e)
        {
            ButtonJohnClicked?.Invoke(this, "John");
        }

        private void ButtonPaul_Click(object sender, EventArgs e)
        {
            ButtonPaulClicked?.Invoke(this, "Paul");
        }

        private void ButtonJane_Click(object sender, EventArgs e)
        {
            ButtonJaneClicked?.Invoke(this, "Jane");
        }
    }
}
