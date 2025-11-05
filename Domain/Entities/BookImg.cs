using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BookImg:BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool IsMainImg { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}
