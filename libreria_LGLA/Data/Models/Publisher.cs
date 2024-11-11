using System.Collections.Generic;

namespace libreria_LGLA.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegación
        public List<Book> Books { get; set; }
    }
}
