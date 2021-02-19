namespace FirstLookToEF
{
    using Models;
    using System;
    using System.Text;
    using System.Linq;

    public class StartUp
    {
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var employees = context.Employees;
            string result = string.Empty;

            foreach (var emp in employees.OrderBy(e => e.EmployeeId))
            {
                result += $"{emp.FirstName} {emp.LastName} {emp.MiddleName} {emp.Salary:F2} {Environment.NewLine}";
            }

            return result;
        }
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employee = context.Employees.Where(e => e.Salary > 50000).OrderBy(e => e.FirstName).ToArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < employee.Length; i++)
            {
                var emp = employee[i];

                sb.AppendLine($"{emp.FirstName} - {emp.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var departmentId = context.Departments
                .Where(d => d.Name == "Research and Development")
                .Select(d => d.DepartmentId)
                .FirstOrDefault();

            var employees = context.Employees
                .Where(e => e.DepartmentId == departmentId)
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToList();

            foreach (var emp in employees)
            {

                var departmentName = context.Departments
                     .Where(d => d.DepartmentId == emp.DepartmentId)
                     .Select(d => d.Name)
                    .FirstOrDefault();

                sb.AppendLine($"{emp.FirstName} {emp.LastName} {departmentName} - {emp.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var address = new Address
            {

                AddressText = "Vitoshka 15",
                TownId = 4,
                Town = context.Towns.Where(t => t.TownId == 4).FirstOrDefault()
            };
            context.Addresses.Add(address);

            var employee = context.Employees
                .FirstOrDefault(x => x.LastName == "Nakov");

            employee.Address = address;
            context.SaveChanges();

            var addressTexts = context.Employees
                .OrderByDescending(x => x.AddressId)
                .Select(a => a.Address.AddressText)
                .Take(10)
                .ToList();

            foreach (var addressTxt in addressTexts)
            {
                sb.AppendLine(addressTxt);
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context.Employees
                   .Where(e => e.EmployeesProjects.Any(p => p.Project.StartDate.Year > 2000
                                                         && p.Project.StartDate.Year < 2004))
                   .Select(x => new
                   {
                       EmployeeFullName = x.FirstName + ' ' + x.LastName,
                       ManagerFullName = x.Manager.FirstName + ' ' + x.Manager.LastName,

                       Projects = x.EmployeesProjects.Select(p => new
                       {
                           ProjectName = p.Project.Name,
                           StartDate = p.Project.StartDate,
                           EndDate = p.Project.EndDate
                       })
                   })
                   .Take(10)
                   .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.EmployeeFullName} - {employee.ManagerFullName}");

                foreach (var project in employee.Projects)
                {
                    string endDate = project.EndDate.HasValue ?
                        project.EndDate.ToString() :
                        "not finished";

                    sb.AppendLine($"--{project.ProjectName} - {project.StartDate} - {endDate}");
                }
            }
            return sb.ToString().TrimEnd();
        }
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var addresses = context.Addresses
                         .OrderByDescending(a => a.Employees.Count)
                         .ThenBy(a => a.Town.Name)
                         .Select(a => new
                         {
                             AddressText = a.AddressText,
                             TownName = a.Town.Name,
                             EmployeeCount = a.Employees.Count
                         })
                        .Take(10)
                        .ToList();

            foreach (var address in addresses)
            {
                sb.AppendLine($"{address.AddressText} {address.TownName} - {address.EmployeeCount}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployee147(SoftUniContext context)
        {
            var sb = new StringBuilder();
            int employeeId = 147;

            var employee = context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .Select(e => new
                {
                    FullName = e.FirstName + ' ' + e.LastName,
                    JobTitle = e.JobTitle,

                    Projects = e.EmployeesProjects
                    .Select(p => new
                    {
                        ProjectName = p.Project.Name
                    })
                    .OrderBy(p => p.ProjectName)
                })
                .FirstOrDefault();

            sb.AppendLine($"{employee.FullName} - {employee.JobTitle}");

            foreach (var project in employee.Projects)
            {
                sb.AppendLine(project.ProjectName);
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerFullName = d.Manager.FirstName + ' ' + d.Manager.LastName,

                    Employees = d.Employees
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .Select(d => new
                    {
                        FullName = d.FirstName + ' ' + d.LastName,
                        JobTitle = d.JobTitle
                    })
                })
                .ToList();

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.DepartmentName} - {department.ManagerFullName}");

                foreach (var employee in department.Employees)
                {
                    sb.AppendLine($"--{employee.FullName} - {employee.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetLatestProjects(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var projects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Select(p => new
                {
                    Name = p.Name,
                    Description = p.Description,
                    StartDate = p.StartDate

                })
                .Take(10)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var project in projects)
            {
                sb.AppendLine(project.Name);
                sb.AppendLine(project.Description);
                sb.AppendLine(project.StartDate.ToString());
            }

            return sb.ToString().TrimEnd();
        }
        public static string IncreaseSalaries(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Engineering" ||
                e.Department.Name == "Tool Design" ||
                e.Department.Name == "Marketing" ||
                e.Department.Name == "Information Services")
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new
                {
                    Id = e.EmployeeId,
                    FullName = e.FirstName + ' ' + e.LastName,
                    Salary = e.Salary + e.Salary * 0.12m
                })
                .ToList();

            foreach (var emp in employees)
            {
                Employee employee = context.Employees
                    .Where(e => e.EmployeeId == emp.Id)
                    .FirstOrDefault();

                employee.Salary = emp.Salary;

                sb.AppendLine($"{emp.FullName} {emp.Salary:F2}");
            }

            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new
                {
                    FullName = e.FirstName + ' ' + e.LastName,
                    JobTitle = e.JobTitle,
                    Salary = e.Salary
                })
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FullName} - {employee.JobTitle} - ({employee.Salary:F2})");
            }

            return sb.ToString().TrimEnd();
        }
        public static string DeleteProjectById(SoftUniContext context)
        {
            var sb = new StringBuilder();
            int projectId = 2;

            var project = context.Projects
                .Where(p => p.ProjectId == projectId)
                .FirstOrDefault();

            var employeeProjects = context.EmployeesProjects
                .Where(ep => ep.ProjectId == projectId)
                .ToList();

            context.EmployeesProjects.RemoveRange(employeeProjects);

            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();


            foreach (var pr in projects)
            {
                sb.AppendLine(pr);
            }
            context.Projects.Remove(project);

            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        public static string RemoveTown(SoftUniContext context)
        {
            var town = context.Towns
                .Where(x => x.Name == "Seattle")
                .FirstOrDefault();

            var addresses = context.Addresses
                .Where(a => a.TownId == town.TownId)
                .ToList();

            var employees = context.Employees
                .Where(x => x.Address.Town == town)
                .ToList();

            foreach (var employee in employees)
            {
                employee.AddressId = null;
            }

            context.Addresses.RemoveRange(addresses);

            context.Towns.Remove(town);

            context.SaveChanges();

            return $"{addresses.Count} addresses in Seattle were deleted";
        }
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                Console.WriteLine(RemoveTown(context));
            }

        }
    }
}