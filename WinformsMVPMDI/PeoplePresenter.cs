using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsMVPMDI.Models;

namespace WinformsMVPMDI
{
    public class PeoplePresenter
    {
        private readonly IPeopleView _view;

        public PeoplePresenter(IPeopleView view)
        {
            _view = view;
            _view.ButtonJohnClicked += ClickHandler;
            _view.ButtonPaulClicked += ClickHandler;
            _view.ButtonJaneClicked += ClickHandler;
        }

        private void ClickHandler(object? sender, string e)
        {
            _view.LoadData(new Person() { FirstName = e, PersonId = 0 });
        }
    }
}
