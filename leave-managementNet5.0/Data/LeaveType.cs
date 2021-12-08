using System;
using System.ComponentModel.DataAnnotations;

namespace leave_managementNet5._0.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
