using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TainaTechTest.Models.DTO;
using TainaTechTest.Repositories.Mappings;

namespace TainaTechTest.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private Context _context;

        public PersonRepository()
        {
            //use dependancy injection
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PersonDTO>> GetAsync(int skip, int take)
        {
            var persons = _context.Persons.Skip(skip).Take(take).Select(PersonDTO.ToDto);
            return await persons.ToListAsync();
        }

        public async Task<bool> CreateAsync(PersonDTO person)
        {
            var entity = PersonDTO.FromDto(person);
            _context.Persons.Add(entity);
            return await SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var person = _context.Persons.Single(p => p.Id == id);
            _context.Persons.Remove(person);
            return await SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            var person = await _context.Persons.SingleOrDefaultAsync(p => p.Id == id);
            return person == null;
        }

        public async Task<bool> UpdateAsync(PersonDTO person)
        {
            var entity = PersonDTO.FromDto(person);
            _context.Entry(entity).State = EntityState.Modified;
            return await SaveChangesAsync();
        }

        private async Task<bool> SaveChangesAsync()
        {
            var affected = await _context.SaveChangesAsync();
            return affected > 0;
        }
    }
}