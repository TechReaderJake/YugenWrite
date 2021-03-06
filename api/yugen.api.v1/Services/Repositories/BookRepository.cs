﻿using yugen.api.v1.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yugen.api.v1.Services.Repositories
{
    /// <summary>
    /// Implementation of the Book Repository and inheriting from the Generic Repository.
    /// </summary>
    public class BookRepository : Repository<BookDTO, string>, IBookRepository
    {
        private const string Collection = "books";
        public BookRepository(AppDbContext context) : base(context, Collection)
        {
            /* 
             * If it is the first time creating the collection uncomment line below this block comment.
             * This line below will eventually have an if the collection hasn't been created to create it and 
             * seed the database with generic information. 
            */

            //context.DB().CreateCollection(Collection);
        }
        public IEnumerable<BookDTO> GetBooksByWorldId(string worldId)
        {
            return _context.Find(book => book.WorldId == worldId).ToList();
        }
    }
}
