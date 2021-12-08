using leave_managementNet5._0.Contracts;
using leave_managementNet5._0.Data;
using System.Collections.Generic;

namespace leave_managementNet5._0.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository (ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(LeaveHistory entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public LeaveHistory FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(LeaveHistory entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
