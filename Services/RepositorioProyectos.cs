using Portafolio.Models;

namespace Portafolio.Services 
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
    {
        return new List<Proyecto>() { 
            new Proyecto
        {
            Titulo = "Amazon",
            Descripcion = "E-Commerce Realizado en ASP.NET Core",
            Link = "https://amazon.com",
            ImagenURL= "/imgs/amazon.png"
        },
            new Proyecto{
            Titulo = "New York Times",
            Descripcion = "Pagina de noticias en React",
            Link = "https://nytimes.com",
            ImagenURL= "/imgs/nytimes.png"
            },

             new Proyecto{
            Titulo = "Reddit",
            Descripcion = "Red social para compartir en comunidades",
            Link = "https://reddit.com",
            ImagenURL= "/imgs/reddit.png"
            },

             new Proyecto{
            Titulo = "Steam",
            Descripcion = "Tienda en linea para comprar videojuegos",
            Link = "https://steam.com",
            ImagenURL= "/imgs/steam.png"
            },
        };
    }
    }
}