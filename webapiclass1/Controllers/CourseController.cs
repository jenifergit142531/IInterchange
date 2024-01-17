﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiclass1.Models;



namespace webapiclass1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        static List<Language> languages = new List<Language>()
        {
            new Language {Id=1,Name="C#"},
             new Language {Id=2,Name="GO"},
              new Language {Id=3,Name="JAVA"},
               new Language {Id=4,Name="SQL"},
        };

        [HttpGet]
        [Route("getcourse")]
        public IActionResult GetLanguages()
        {
            return Ok(languages);
        }

        [HttpGet]
        [Route("getcourseid/{id}")]
        public IActionResult GetLanguageById(int id)
        {
            var language = languages.FirstOrDefault(l => l.Id == id);
            if(language==null)
            {
                return NotFound();
            }
            return Ok(language);
        }

        [HttpPost]
        [Route("addcourse")]
        public IActionResult AddLanguage(Language newLanguage)
        {
            newLanguage.Id = languages.Count + 1;
            languages.Add(newLanguage);
            return Ok("Success");
        }

        [HttpPut]
        [Route("updatecourse/{id}")]
        public IActionResult UpdateLanguage(int id,Language updatedLanguage)
        {
            var existingLanguage = languages.FirstOrDefault(l => l.Id == id);
            if(existingLanguage==null)
            {
                return NotFound();
            }
            existingLanguage.Name = updatedLanguage.Name;
            return Ok("Success");
        }

        [HttpDelete]
        [Route("deletecourse/{id}")]
        public IActionResult DeleteLanguage(int id)
        {
            var deleteLanguage = languages.FirstOrDefault(l => l.Id == id);
            if (deleteLanguage == null)
            {
                return NotFound();
            }
            languages.Remove(deleteLanguage);

            return Ok("Delete is successful");
        }
    }
}


