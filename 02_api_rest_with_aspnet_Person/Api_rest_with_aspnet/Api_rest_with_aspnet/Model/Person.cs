using System.ComponentModel.DataAnnotations.Schema;

namespace Api_rest_with_aspnet.Model
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("address")]
        public string FirstName { get; set; }
        [Column("first_name")]
        public string LastName { get; set; }
        [Column("gender")]
        public string Address { get; set; }
        [Column("last_name")]
        public string Gender { get; set; }
    }
}
