using leave_managementNet5._0.Contracts;
using leave_managementNet5._0.Data;
using System.Collections.Generic;

namespace leave_managementNet5._0.Repository
{
    public class LeaveAllocationsRepository : ILeaveAllocationsRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationsRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
