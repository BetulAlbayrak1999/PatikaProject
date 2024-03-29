﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Books.Any()) { return; }
                    

                context.Genres.AddRange(
                    new Genre { Name= "Romance"},
                    new Genre { Name= "Sceince Fiction"},
                    new Genre { Name= "Fantasy"}
                    );

                context.Authors.AddRange(
                    new Author { Name = "Ahmet", Surname = "Ahmetxx", BirthDate= "12-12-12" },
                    new Author { Name = "Hamit", Surname = "Hamitxx", BirthDate = "13-13-13" },
                    new Author { Name = "Samir", Surname = "Samirxx", BirthDate = "14-14-14" }
                    );


                context.Books.AddRange(
                    new Book
                    {
                        Title = "1.book",
                        GenreId = 1,
                        PageCount = 234,
                        PublishDate = "12-11-11"
                    },
                    new Book
                    {
                        Title = "2.book",
                        GenreId = 2,
                        PageCount = 455,
                        PublishDate = "12-02-01"
                    }
                );;

                context.SaveChanges();
            }
        }
    }
}


