using Leave_Management.Contracts;
using Leave_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Leave_History entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(Leave_History entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<Leave_History> FindAll()
        {
            var LeaveHistories = _db.LeaveHistories.ToList();
            return LeaveHistories;
        }

        public Leave_History FindById(int id)
        {
            var LeaveHistory = _db.LeaveHistories.Find(id);
            return LeaveHistory;
        }

        public bool isExists(int id)
        {
            var exist = _db.LeaveHistories.Any(q => q.Id == id);
            return exist;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Leave_History entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
