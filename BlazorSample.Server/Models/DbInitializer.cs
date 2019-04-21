using BlazorSample.Server.Models;
using System.Linq;

namespace BlazorSample.Models
{
    public class DbInitializer
    {
        public static void Initialize(BlazorSampleContext context)
        {
            if (context.Employee.Any())
            {
                return;
            }

            var emps = new Employee[]
            {
                new Employee { Name = "Taro Yamada", Gender = "man", Department = "Sales", City = "New Orleans" },
                new Employee { Name = "Jiro Sato", Gender = "man", Department = "Sales", City = "Hamilton" },
                new Employee { Name = "Saburo Tanaka", Gender = "man", Department = "Sales", City = "Chicago" },
                new Employee { Name = "Shiro Suzuki", Gender = "man", Department = "Sales", City = "Los Angeles" },
                new Employee { Name = "Goro Tanaka", Gender = "man", Department = "Sales", City = "Mc Minnville" },
                new Employee { Name = "Taro Takahashi", Gender = "man", Department = "Sales", City = "Aston" },
            };

            foreach (var emp in emps)
            {
                context.Employee.Add(emp);
            }
            context.SaveChanges();
        }
    }
}
