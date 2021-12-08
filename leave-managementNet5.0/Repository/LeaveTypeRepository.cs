using leave_managementNet5._0.Contracts;
using leave_managementNet5._0.Data;
using System.Collections.Generic;
using System.Linq;

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
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveTypes.ToList();
        }

        public LeaveType FindById(int id)
        {
            var leaveType = _db.LeaveTypes.Find(id);
            return leaveType;
        }


        public ICollection<LeaveType> GetEmployeeByLeaveType(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
          var changes =  _db.SaveChanges() > 0;
            return changes;
        }


        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
