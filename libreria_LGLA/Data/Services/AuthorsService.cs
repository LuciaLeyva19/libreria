﻿using libreria_LGLA.Data.Models;
using libreria_LGLA.Data.ViewModels;
using System;
using System.Linq;

namespace libreria_LGLA.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar un nuevo Autor en la BD
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.Id == authorId).Select(n => new AuthorWithBooksVM ()
            {
                FullName = n.FullName,
                BookTitles = n.Book_Authors.Select(n => n.Book.Titulo).ToList()
            }).FirstOrDefault();
            return _author;
        }
    }
}
