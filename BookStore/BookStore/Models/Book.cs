﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public int GenreId{ get; set; }
        public Genre Genre{ get; set; }

        public int PageCount { get; set; }

        public string PublishDate { get; set; }
    }
}
