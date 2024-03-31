using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsMVPMDI.Structure;

namespace WinformsMVPMDI.Models
{
    public class Person : ObservableObject
    {
        public int PersonId { get; set; }
        public string FirstName { get => _firstName; set => Set(ref _firstName, value); }
        private string _firstName = string.Empty;
    }
}
