using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiclass1.Models;

namespace webapiclass1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {

        static List<string> language = new List<string>()
         {
             "C#","GO","JAVA","SQL"
         };
      

        [HttpGet]
        [Route("getall")]
        public IEnumerable<string> GetAllLanguages()
        {
            return language;
        }

        [HttpGet]
        [Route("getone/{id}")]
        public string GetLanguageById(int id)
        {
            return language[id];
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteLanguage(int id)
        {
            language.RemoveAt(id);
        }
    }
}
