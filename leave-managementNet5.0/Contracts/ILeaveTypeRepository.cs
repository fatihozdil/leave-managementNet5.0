using leave_managementNet5._0.Data;
using System.Collections.Generic;

namespace leave_managementNet5._0.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeeByLeaveType(int id);
    }

}
