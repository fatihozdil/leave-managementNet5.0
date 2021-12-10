using System;
using System.ComponentModel.DataAnnotations;

namespace leave_managementNet5._0.Models
{
    public class DetailsLeaveTypeVM
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {

        [Required]
        public string Name { get; set; }
    }

}
