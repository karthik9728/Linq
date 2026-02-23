using System;
using System.Collections.Generic;

namespace LinqToEntities.Models;

public partial class Department
{
    public int Departmentid { get; set; }

    public string Departmentname { get; set; }

    public string Location { get; set; }

    public DateTime? Createdat { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
