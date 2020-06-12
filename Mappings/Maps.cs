using AutoMapper;
using Leave_Management.Data;
using Leave_Management.Models;
using Leave_Management.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Mappings
{
    public class Maps : Profile 
    {
        public Maps()
        {
            CreateMap<Leave_Type, LeaveTypeVM>().ReverseMap();
            CreateMap<Leave_History, LeaveHistoryVM>().ReverseMap();
            CreateMap<Leave_Allocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
