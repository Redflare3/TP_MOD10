using Microsoft.AspNetCore.Mvc;
using TP_MODUL10_103022400141.Model;

namespace TP_MODUL10_103022400141.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static readonly List<Film> daftarFilm = new List<Film>
        {
            new Film { Id = 1, Judul = "Inception", Sutradara = "Christopher Nolan", Tahun = "2010", Genre = "Sci-Fi", Rating = "9.0" },
            new Film { Id = 2, Judul = "Interstellar", Sutradara = "Christopher Nolan", Tahun = "2014", Genre = "Sci-Fi", Rating = "8.7" },
            new Film { Id = 3, Judul = "Parasite", Sutradara = "Bong Joon-ho", Tahun = "2019", Genre = "Thriller", Rating = "8.6" }
        };

        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return daftarFilm;
        }

        [HttpGet("{id}")]
        public Film Get(int id)
        {
            return daftarFilm.FirstOrDefault(f => f.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Film value)
        {
            daftarFilm.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var film = daftarFilm.FirstOrDefault(f => f.Id == id);
            if (film != null)
            {
                daftarFilm.Remove(film);
            }
        }
    }
}
