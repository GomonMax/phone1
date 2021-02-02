using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneBook.Models
{
    public class ComboBoxView
    {
        public int Id { get; set; }
        public string ViewStr { get; set; }

        public override string ToString()
        {
            return this.ViewStr;
        }
    }
}
