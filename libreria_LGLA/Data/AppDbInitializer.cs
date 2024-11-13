using libreria_LGLA.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace libreria_LGLA.Data
{
    public class AppDbInitializer
    {
        //Método que agrega datos a nuestra BD
        public static void Seed (IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "1st Book Title",
                        Descripcion = "1st Book Descripción",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    },
                    new Book()
                    {
                        Titulo = "2nd Book Title",
                        Descripcion = "2nd Book Descripción",
                        IsRead = true,
                        Genero = "Biography",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    });
                    context.SaveChanges();
                }
            }
        }
        
    }
}
