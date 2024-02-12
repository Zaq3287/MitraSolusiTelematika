using Microsoft.AspNetCore.Mvc;
using MitraSolusiTelematika.Model;

namespace MitraSolusiTelematika.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PlayersController : ControllerBase
    {
        // here uses a list because it does not use a database
        // data will always be deleted
        // seed data into list
        List<Player> lstPlayer = new List<Player>
        {
            new Player { Id = 1, Name = "Cristiano Ronaldo", Age = 37, BirthPlace = "Europe" },
            new Player { Id = 2, Name = "Lionel Messi", Age = 36, BirthPlace = "South America" },
            new Player { Id = 3, Name = "Karim Benzema", Age = 35, BirthPlace = "Europe" },
            new Player { Id = 4, Name = "Erling Haaland", Age = 23, BirthPlace = "Europe" },
            new Player { Id = 5, Name = "Kylian Mbappe", Age = 24, BirthPlace = "Europe" }
        };

        [HttpGet]
        // route ./api/players
        // displays all data contained in the list
        public IEnumerable<Player> GetPlayers()
        {
            return lstPlayer;
        }

        [HttpGet("{id}")]
        // route ./api/players/{id}
        // displays data based on Id
        public IEnumerable<Player> GetPlayer(int id)
        {
            return lstPlayer.Where(x => x.Id == id).ToList();
        }

        [HttpGet("birthPlace/{birthPlace}")]
        // route ./api/players/birthPlace/{birthPlace}
        // display data based on place of birth
        public IEnumerable<Player> GetPlayer(string birthPlace)
        {
            return lstPlayer.Where(x => x.BirthPlace == birthPlace).ToList();
        }

        [HttpPost]
        // route ./api/players
        // insert new data into the list
        // this will work, but when displaying the data displayed according to the default value
        public ActionResult<Player> Create(Player player)
        {
            lstPlayer.Add(player);

            return Ok();
        }
    }
}
