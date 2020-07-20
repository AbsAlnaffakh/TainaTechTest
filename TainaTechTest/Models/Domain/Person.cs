using System;
using TainaTechTest.Enums;

namespace TainaTechTest.Models.Domain
{
    public class Person
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
    }
}