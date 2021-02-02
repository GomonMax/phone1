using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneBook.Models
{
    public class SearchModel
    {
        public string Name { get; set; }
        public string telNum { get; set; }
        public bool? State { get; set; }
        public int page { get; set; }
        public int countOnePage { get; set; } = 10;
    }
}
