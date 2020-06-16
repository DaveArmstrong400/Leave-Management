using Leave_Management.Contracts;
using Leave_Management.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CheckAllocation(int leavetypeid, string employeeid)
        {
            var period = DateTime.Now.Year;
            return FindAll()
                .Where(q => q.EmployeeId == employeeid && q.LeaveTypeId == leavetypeid && q.Period == period)
                .Any();
        }

            public bool Create(Leave_Allocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(Leave_Allocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<Leave_Allocation> FindAll()
        {
            var LeaveAllocations = _db.LeaveAllocations
                .Include(q => q.Leave_Type)
                .Include(q => q.Employee)
                .ToList();
            return LeaveAllocations;
        }

        public Leave_Allocation FindById(int id)
        {
            var LeaveAllocation = _db.LeaveAllocations
                .Include(q => q.Leave_Type)
                .Include(q => q.Employee)
                .FirstOrDefault(q => q.Id == id);
            return LeaveAllocation;
        }

        public ICollection<Leave_Allocation> GetLeaveAllocationsByEmployee(string id)
        {
            var period = DateTime.Now.Year;
            return FindAll()
                .Where(q => q.EmployeeId == id && q.Period == period)
                .ToList();
        }

        public bool isExists(int id)
        {
            var exist = _db.LeaveAllocations.Any(q => q.Id == id);
            return exist;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Leave_Allocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
