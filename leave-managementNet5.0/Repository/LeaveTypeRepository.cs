using leave_managementNet5._0.Contracts;
using leave_managementNet5._0.Data;
using System.Collections.Generic;

namespace leave_managementNet5._0.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db; 
        }
        public bool Create(LeaveType entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(LeaveType entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveType> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public LeaveType FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveType> GetEmployeeByLeaveType(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(LeaveType entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
