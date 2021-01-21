using System.ComponentModel.DataAnnotations;

namespace SearchAPI.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
