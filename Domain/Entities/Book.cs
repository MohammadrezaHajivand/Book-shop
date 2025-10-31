using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public List<BookImg> BookImgs { get; set; }



        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
