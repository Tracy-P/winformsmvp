using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP
{
    public class ModelTwo : ObservableObject
    {
        private string _firstName = string.Empty;
        public string FirstName { get { return _firstName; } set { Set(ref _firstName, value); } }

        public override bool Equals(object? obj)
        {
            return obj is ModelTwo two &&
                   FirstName == two.FirstName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
            //return HashCode.Combine(FirstName);
        }
    }
}
