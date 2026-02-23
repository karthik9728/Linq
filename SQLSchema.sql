CREATE TABLE Department (
    DepartmentId SERIAL PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL UNIQUE,
    Location VARCHAR(100),
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Employee (
    EmployeeId SERIAL PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(150) UNIQUE NOT NULL,
    Phone VARCHAR(20),
    Salary NUMERIC(10,2) CHECK (Salary > 0),
    HireDate DATE NOT NULL,
    DepartmentId INT NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT fk_department
        FOREIGN KEY (DepartmentId)
        REFERENCES Department(DepartmentId)
        ON DELETE RESTRICT
);

INSERT INTO Department (DepartmentName, Location) VALUES
('Human Resources', 'Chennai'),
('Engineering', 'Bangalore'),
('Finance', 'Mumbai'),
('Marketing', 'Hyderabad'),
('IT Support', 'Pune');

INSERT INTO Employee
(FirstName, LastName, Email, Phone, Salary, HireDate, DepartmentId)
VALUES
('Arun', 'Kumar', 'arun.kumar@company.com', '9876543210', 60000, '2022-03-15', 2),
('Priya', 'Sharma', 'priya.sharma@company.com', '9876543211', 55000, '2021-07-10', 1),
('Rohit', 'Verma', 'rohit.verma@company.com', '9876543212', 75000, '2020-01-05', 2),
('Sneha', 'Iyer', 'sneha.iyer@company.com', '9876543213', 50000, '2023-02-01', 4),
('Vikram', 'Singh', 'vikram.singh@company.com', '9876543214', 90000, '2019-11-20', 3),
('Anjali', 'Mehta', 'anjali.mehta@company.com', '9876543215', 45000, '2022-09-12', 5);

SELECT e.EmployeeId,
       e.FirstName,
       e.LastName,
       d.DepartmentName,
       e.Salary
FROM Employee e
JOIN Department d ON e.DepartmentId = d.DepartmentId;


-- Scaffold-DbContext "Host=localhost;Port=5432;Database=EmpManagement;Username=postgres;Password=karthik;TrustServerCertificate=True;" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models -Context EmpManagementContext