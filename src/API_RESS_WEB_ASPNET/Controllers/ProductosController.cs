using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using MiProyectoWeb.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace MiProyectoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly string _connectionString;

        public ProductosController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // POST: api/productos/comprar
        [HttpPost("comprar")]
        public IActionResult Comprar([FromBody] List<Producto> productos)
        {
            if (productos == null || productos.Count == 0)
            {
                return BadRequest(new { mensaje = "No se recibieron productos" });
            }

            try
            {
                using var connection = new SqliteConnection(_connectionString);
                connection.Open();

                using var transaction = connection.BeginTransaction();

                foreach (var producto in productos)
                {
                    using var command = connection.CreateCommand();
                    command.CommandText =
                        @"INSERT INTO productos (titulo, url_imagen, precio)
                          VALUES (@titulo, @url_imagen, @precio);";

                    command.Parameters.AddWithValue("@titulo", producto.Titulo);
                    command.Parameters.AddWithValue("@url_imagen", producto.UrlImagen);
                    command.Parameters.AddWithValue("@precio", producto.Precio);

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (SqliteException ex)
            {
                return StatusCode(500, new
                {
                    mensaje = "Error al insertar productos en la base de datos",
                    error = ex.Message
                });
            }

            return Ok(new
            {
                mensaje = "Productos insertados correctamente",
                cantidad = productos.Count
            });
        }
    }
}
