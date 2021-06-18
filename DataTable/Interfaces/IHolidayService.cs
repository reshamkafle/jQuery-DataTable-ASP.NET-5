using DataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTable.Interfaces
{
    public interface IHolidayService
    {
        public IQueryable<Holiday> GetAll();
    }
}
