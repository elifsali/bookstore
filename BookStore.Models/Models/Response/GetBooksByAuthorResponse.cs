using BookStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models.Response
{
    public class GetBooksByAuthorResponse
    {
        public Author? Author { get; set; }

        public List<Book>? Books { get; set;} 
    }
}
