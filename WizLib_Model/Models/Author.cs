using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib_Model.Models
{
    public class Author
    {
        [Key] // entity, a db cria o valor da pk. none, o código. computed, a db cria e mexe tanto quanto cria quanto quando atualiza
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Author_Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Location { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }

        [NotMapped]
        public string FullName { get {
                return $"{FirstName} {LastName}";
            }
            }
    }
}
