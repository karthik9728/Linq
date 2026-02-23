using System;
using System.Collections.Generic;

namespace LinqToEntities.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public decimal? Salary { get; set; }

    public DateOnly Hiredate { get; set; }

    public int Departmentid { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Createdat { get; set; }

    public virtual Department Department { get; set; }
}
