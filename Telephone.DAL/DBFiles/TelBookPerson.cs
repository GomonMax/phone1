using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Telephone.DAL.DBFiles
{
    [Table("tblTelBookPersons")]
    public class TelBookPerson
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string FirstName { get; set; }
        [Required, StringLength(255)]
        public string SecondName { get; set; }
        [Required, StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required, MinLength(10)]
        public string telNummer { get; set; }
    }
}
