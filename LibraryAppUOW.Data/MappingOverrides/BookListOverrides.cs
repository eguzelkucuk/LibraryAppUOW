
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using LibraryAppUOW.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Data.MappingOverrides
{

    public class BookListOverrides : IAutoMappingOverride<BookList>
    {
        public void Override(AutoMapping<BookList> mapping)
        {
        }
    }

}
