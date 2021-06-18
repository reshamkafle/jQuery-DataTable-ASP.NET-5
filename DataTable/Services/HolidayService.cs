using DataTable.Interfaces;
using DataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTable.Services
{
    public class HolidayService : IHolidayService
    {
        public IQueryable<Holiday> GetAll()
        {
            return new List<Holiday>
            {
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
                new Holiday{Start = DateTime.Now, End = DateTime.Now, Name="Christmas"},
            }.AsQueryable();

        }
    }
}
