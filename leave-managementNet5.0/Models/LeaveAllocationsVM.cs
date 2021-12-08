using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace leave_managementNet5._0.Models
{
    public class LeaveAllocationsVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public IEnumerable<SelectListItem> Employees { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
}
