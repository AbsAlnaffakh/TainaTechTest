using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TainaTechTest.Models.DTO;

namespace TainaTechTest.Services
{
    public interface IPersonService
    {
        /// <summary>
        /// Get a set of persons from the repository respecing pagination patameters
        /// </summary>
        /// <returns>A list of persons</returns>
        Task<IEnumerable<PersonDTO>> GetAsync(int skip, int take);

        /// <summary>
        /// Create a new persons and inserts their details into the database
        /// </summary>
        /// <param name="person"></param>
        /// <returns>A list of persons</returns>
        Task<bool> CreateAsync(PersonDTO person);

        /// <summary>
        /// Update a persons record 
        /// </summary>
        /// <param name="person"></param>
        /// <returns>Updates the user record</returns>
        Task<bool> UpdateAsync(PersonDTO person);

        /// <summary>
        /// Delete the specified user record from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return true if the person has been successfully removed from the database</returns>
        Task<bool> DeleteAsync(int id);
    }
}