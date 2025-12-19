namespace MiProyectoWeb.Models
{
    public class Producto
    {
        public int Id { get; set; } // autoincrement en SQLite
        public string Titulo { get; set; }
        public string UrlImagen { get; set; }
        public double Precio { get; set; }
    }
}
