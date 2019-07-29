using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tictactoeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/stealidentity
        [HttpGet("{id}")]
        public ActionResult<string> Get([FromQuery] string firstName, string lastName)
        {
            if (firstName.Equals("Peter") && lastName.Equals("Billings"))
            {
                return firstName + lastName;
            }
            else
            {
                return "Other response!";
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult<GameUpdateResponse> Post([FromBody] TictactoeBoard board)
        {
            GameUpdateResponse response = new GameUpdateResponse();

            BoardStateInterpreter requestHandler = new BoardStateInterpreter(board);

            response.ChosenSquare = board.ChosenSquare;

            response.Winner = requestHandler.CheckForWinner();

            response.Turn = requestHandler.CurrentTurn;

            return response;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
