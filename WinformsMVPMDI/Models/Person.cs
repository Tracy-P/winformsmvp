using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsMVPMDI.Structure;

namespace WinformsMVPMDI.Models
{
    public class Person : ObservableObject, IEquatable<Person?>
    {
        public int PersonId { get; set; }
        public string FirstName { get => _firstName; set => Set(ref _firstName, value); }
        private string _firstName = string.Empty;

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   PersonId == other.PersonId &&
                   FirstName == other.FirstName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PersonId, FirstName);
        }
    }
}
