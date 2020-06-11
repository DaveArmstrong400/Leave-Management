using Leave_Management.Contracts;
using Leave_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Repository
{
    public class LeaveTypeRepositoy : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        private object return_db;

        public LeaveTypeRepositoy(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Leave_Type entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(Leave_Type entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<Leave_Type> FindAll()
        {
            var LeaveTypes = _db.LeaveTypes.ToList();
            return LeaveTypes;
        }

        public Leave_Type FindById(int id)
        {
            var LeaveType = _db.LeaveTypes.Find(id);
            return LeaveType;
        }

        public ICollection<Leave_Type> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Leave_Type entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
