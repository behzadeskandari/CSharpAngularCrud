using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Supplier
    {
      
        public int Id { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }


        [StringLength(250)]
        public string LastName { get; set; }


    }
}
