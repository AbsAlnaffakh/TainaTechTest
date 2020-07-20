using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TainaTechTest.Exceptions;
using TainaTechTest.Models.DTO;
using TainaTechTest.Repositories;

namespace TainaTechTest.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _repository; 

        public PersonService()
        {
            // add dependancy injection
            throw new NotImplementedException();
        }

        public async Task<bool> CreateAsync(PersonDTO person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            person.Validate();

            var result = await _repository.CreateAsync(person);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _repository.ExistsAsync(id);
            
            if (!exists)
                throw new PersonNotFoundException();

            var result = await _repository.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<PersonDTO>> GetAsync(int skip, int take)
        {
            var result = await _repository.GetAsync(skip, take);
            return result;
        }

        public async Task<bool> UpdateAsync(PersonDTO person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            var exists = await _repository.ExistsAsync(person.Id);

            if (!exists)
                throw new PersonNotFoundException();

            person.Validate();

            var result = await _repository.UpdateAsync(person);
            return result;
        }
    }
}