using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TainaTechTest.Models.DTO;
using TainaTechTest.Services;

namespace TainaTechTest.Controllers
{
    /// <summary>
    /// Provides persons administration functinality
    /// </summary>
    [RoutePrefix("Persons")]
    public class PersonsController : ApiController
    {
        private IPersonService _personService;

        public PersonsController()
        {
            //add dependancy injection
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns a list of persons while respecting pagination values
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<PersonDTO>))]
        public async Task<IHttpActionResult> GetAsync([FromUri]int skip, [FromUri]int take)
        {
            try
            {
                var result = await _personService.GetAsync(skip, take);
                return Ok(result);
            }
            catch(Exception e)
            {
                // A handles is to be implemnted to ensure the correct response is returned to the client based on the exception thrown
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Creates a new person entry within the repository
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(bool))]
        public async Task<IHttpActionResult> CreateAsync(PersonDTO person)
        {
            try
            {
                var result = await _personService.CreateAsync(person);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Updates a person entry
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("")]
        [ResponseType(typeof(bool))]
        public async Task<IHttpActionResult> UpdateAsync(PersonDTO person)
        {
            try
            {
                var result = await _personService.UpdateAsync(person);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Delets a person entry
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:min:1}")]
        [ResponseType(typeof(bool))]
        public async Task<IHttpActionResult> DeleteAsync(int id)
        {
            try
            {
                var result = await _personService.DeleteAsync(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
