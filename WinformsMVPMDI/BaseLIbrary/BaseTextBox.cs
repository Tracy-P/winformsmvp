using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsMVPMDI.BaseLIbrary
{
    public class BaseTextBox : TextBox
    {
        public void Bind(object datasource, string dataproperty)
        {
            var oldBinding = DataBindings[nameof(Text)];
            if (oldBinding != null) { DataBindings.Remove(oldBinding); }

            var newBinding = new Binding(nameof(Text), datasource, dataproperty, false);
            DataBindings.Add(newBinding);
        }
    }
}
