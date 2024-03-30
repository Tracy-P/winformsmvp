using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP
{
    public class Presenter
    {
        private readonly IForm1 _form1;
        public Presenter(IForm1 form)
        {
            _form1 = form;
            _form1.JohnButton += HandleEvent;
            _form1.PaulButton += HandleEvent;
            _form1.JaneButton += HandleEvent;
        }

        private void HandleEvent(object? sender, string e)
        {
            _form1.LoadData(new ModelTwo() { FirstName = e });
        }
    }
}
