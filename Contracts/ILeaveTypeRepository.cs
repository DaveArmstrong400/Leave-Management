using Leave_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Contracts
{
    public interface ILeaveTypeRepository : IRepositoyBase<Leave_Type>
    {
        ICollection<Leave_Type> GetEmployeesByLeaveType(int id);
    }
}
