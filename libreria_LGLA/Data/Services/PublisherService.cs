using libreria_LGLA.Data.Models;
using libreria_LGLA.Data.ViewModels;

namespace libreria_LGLA.Data.Services
{
    public class PublisherService
    {
        private AppDbContext _context;

        public PublisherService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar un nuevo Editora en la BD
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name

            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
