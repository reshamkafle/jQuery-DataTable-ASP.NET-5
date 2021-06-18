using DataTable.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace DataTable.Controllers
{
    public class HolidayController : Controller
    {
        private readonly IHolidayService _holidayService;

        public HolidayController(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetHoliday()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();

                var start = Request.Form["start"].FirstOrDefault(); //start row
                var length = Request.Form["length"].FirstOrDefault(); //pagination length, e.g. 10 item in a page
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault(); //sort the column name
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault(); //sort order (asc, desc)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault(); //get value from search box
                int pageSize = length != null ? Convert.ToInt32(length) : 0; //page size 10,20,30
                int skip = start != null ? Convert.ToInt32(start) : 0;

                int recordsTotal = 0;
                
                var holidaydata = _holidayService.GetAll(); // getting all holiday data  

                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    holidaydata = holidaydata.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    holidaydata = holidaydata.Where(m => m.Name.Contains(searchValue));
                }
                
                recordsTotal = holidaydata.Count(); //total number of rows counts               
                var data = holidaydata.Skip(skip).Take(pageSize).ToList();//Paging             
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });//Returning Json Data  

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
