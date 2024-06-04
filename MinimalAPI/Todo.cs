using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MinimalAPI
{
    public class Todo
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string? Name { get; set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal value { get; set; }

        public bool IsComplete { get; set; }
    }
}
