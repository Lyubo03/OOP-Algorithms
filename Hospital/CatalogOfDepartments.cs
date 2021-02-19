namespace Hospital
{
    using System.Collections.Generic;

    public class CatalogOfDepartments
    {
        private List<Department> departments;

        public CatalogOfDepartments()
        {
            departments = new List<Department>();
        }
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }
    }
}