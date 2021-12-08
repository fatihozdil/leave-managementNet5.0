using AutoMapper;
using leave_managementNet5._0.Data;
using leave_managementNet5._0.Models;

namespace leave_managementNet5._0.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType,CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType,LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveType,LeaveAllocationsVM>().ReverseMap();
            CreateMap<LeaveType,EmployeeVM>().ReverseMap();

        }
    }
}
