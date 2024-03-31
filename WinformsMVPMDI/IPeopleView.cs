using WinformsMVPMDI.Models;

namespace WinformsMVPMDI
{
    public interface IPeopleView
    {
        event EventHandler<string>? ButtonJaneClicked;
        event EventHandler<string>? ButtonJohnClicked;
        event EventHandler<string>? ButtonPaulClicked;

        void LoadData(Person person);
    }
}