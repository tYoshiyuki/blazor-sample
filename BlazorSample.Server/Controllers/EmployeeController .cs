using AutoMapper;
using BlazorSample.Server.Models;
using BlazorSample.Server.Repositories;
using BlazorSample.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BlazorSample.Server.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<EmployeeViewModel> Index()
        {
            return _mapper.Map<List<Employee>, List<EmployeeViewModel>>(_repository.Get().ToList());
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public EmployeeViewModel Details(int id)
        {
            return _mapper.Map<Employee, EmployeeViewModel>(_repository.Find(id));
        }


        [HttpPost]
        [Route("api/Employee/Create")]
        public void Create([FromBody] EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee();
                _mapper.Map(employee, emp);
                _repository.Add(emp);
                _repository.Save();
            }
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public void Edit([FromBody] EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee();
                _mapper.Map(employee, emp);
                _repository.Update(emp);
                _repository.Save();
            }
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public void Delete(int id)
        {
            var emp = _repository.Find(id);
            if (emp != null)
            {
                _repository.Remove(emp);
                _repository.Save();
            }
        }
    }
}
