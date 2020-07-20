using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TainaTechTest.Models.Domain;

namespace TainaTechTest.Repositories.Mappings
{
    public class Context : DbContext, IContext
    {
        public IDbSet<Person> Persons { get; set; }

    }
}