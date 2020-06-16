using Leave_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoyBase<Leave_Allocation>
    {
        bool CheckAllocation(int leavetypeid, string employeeid);
        ICollection<Leave_Allocation> GetLeaveAllocationsByEmployee(string id);
    }
}
