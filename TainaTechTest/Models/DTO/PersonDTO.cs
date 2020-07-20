using System;
using System.Linq.Expressions;
using System.Security.AccessControl;
using TainaTechTest.Enums;
using TainaTechTest.Exceptions;
using TainaTechTest.Extensions;
using TainaTechTest.Models.Domain;

namespace TainaTechTest.Models.DTO
{
    /// <summary>
    /// A DTO that represents a person
    /// </summary>
    public class PersonDTO
    {
        /// <summary>
        /// The identifier of the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The persons' firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// The persons' surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The persons' gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// The persons' email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The persons' contact number
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// The persons' date of birth
        /// </summary>
        public DateTime DOB { get; set; }

        /// <summary>
        /// Converts a domain object to a DTO form
        /// </summary>
        public static Expression<Func<Person, PersonDTO>> ToDto = p =>
            new PersonDTO()
            {
                Id = p.Id,
                Firstname = p.Firstname,
                Surname = p.Surname,
                Gender = p.Gender,
                Email = p.Email,
                Contact = p.Contact,
                DOB = p.DOB
            };
        
        /// <summary>
        /// Converts a domain object into dto
        /// </summary>
        public static Person FromDto(PersonDTO p) =>
            new Person()
            {
                Id = p.Id,
                Firstname = p.Firstname,
                Surname = p.Surname,
                Gender = p.Gender,
                Email = p.Email,
                Contact = p.Contact,
                DOB = p.DOB
            };

        /// <summary>
        /// Validates the DTO fields
        /// </summary>
        /// <returns>true when validation succeeds</returns>
        public void Validate()
        {
            if (!Firstname.HasValue())
                throw new InvalidPropertyValueException(nameof(Firstname), Firstname);
            
            if (!Surname.HasValue())
                throw new InvalidPropertyValueException(nameof(Surname), Surname);

            if (!Email.IsEmailAddress())
                throw new InvalidPropertyValueException(nameof(Email), Email);

            if (!Contact.IsContactNumber())
                throw new InvalidPropertyValueException(nameof(Contact), Contact);

            if (DOB == null)
                throw new InvalidPropertyValueException(nameof(DOB));
        }
    }
}