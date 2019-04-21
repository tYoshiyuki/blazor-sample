using BlazorSample.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Server.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {

    }

    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(BlazorSampleContext db) : base(db) { }
    }
}
