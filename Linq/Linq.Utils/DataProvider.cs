using Linq.Utils.Common;
using Linq.Utils.Models;

namespace Linq.Utils
{
    public static class DataProvider
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "Alice Johnson", "alice.johnson@company.com", new DateOnly(2020, 1, 15), Team.Development),
                new Employee(2, "Bob Smith", "bob.smith@company.com", new DateOnly(2019, 3, 10), Team.DevOps),
                new Employee(3, "Charlie Brown", "charlie.brown@company.com", new DateOnly(2021, 6, 5), Team.Testing),
                new Employee(4, "Diana Prince", "diana.prince@company.com", new DateOnly(2018, 11, 20), Team.QA),
                new Employee(5, "Ethan Clark", "ethan.clark@company.com", new DateOnly(2022, 2, 1), Team.ProductManagement),
                new Employee(6, "Fiona Davis", "fiona.davis@company.com", new DateOnly(2020, 7, 18), Team.UXUI),
                new Employee(7, "George Miller", "george.miller@company.com", new DateOnly(2017, 9, 9), Team.DataEngineering),
                new Employee(8, "Hannah Wilson", "hannah.wilson@company.com", new DateOnly(2023, 1, 12), Team.Security),
                new Employee(9, "Ian Moore", "ian.moore@company.com", new DateOnly(2019, 4, 30), Team.Support),
                new Employee(10, "Jane Taylor", "jane.taylor@company.com", new DateOnly(2016, 12, 3), Team.ResearchAndDevelopment),
                new Employee(11, "Kevin Anderson", "kevin.anderson@company.com", new DateOnly(2020, 8, 14), Team.Development),
                new Employee(12, "Laura Thomas", "laura.thomas@company.com", new DateOnly(2021, 9, 25), Team.DevOps),
                new Employee(13, "Michael White", "michael.white@company.com", new DateOnly(2018, 5, 17), Team.Testing),
                new Employee(14, "Nina Harris", "nina.harris@company.com", new DateOnly(2022, 10, 11), Team.QA),
                new Employee(15, "Oscar Martin", "oscar.martin@company.com", new DateOnly(2019, 6, 6), Team.ProductManagement),
                new Employee(16, "Paula Thompson", "paula.thompson@company.com", new DateOnly(2021, 3, 22), Team.UXUI),
                new Employee(17, "Quentin Garcia", "quentin.garcia@company.com", new DateOnly(2020, 4, 19), Team.DataEngineering),
                new Employee(18, "Rachel Martinez", "rachel.martinez@company.com", new DateOnly(2017, 2, 8), Team.Security),
                new Employee(19, "Steven Robinson", "steven.robinson@company.com", new DateOnly(2015, 1, 27), Team.Support),
                new Employee(20, "Tina Walker", "tina.walker@company.com", new DateOnly(2023, 5, 16), Team.UXUI),
                new Employee(21, "Bob Smith", "bob.smithdev@company.com", new DateOnly(2019, 7, 7), Team.Development),
                new Employee(22, "Victoria Allen", "victoria.allen@company.com", new DateOnly(2020, 9, 3), Team.DevOps),
                new Employee(23, "William Young", "william.young@company.com", new DateOnly(2018, 8, 28), Team.Testing),
                new Employee(24, "Xenia King", "xenia.king@company.com", new DateOnly(2022, 11, 9), Team.QA),
                new Employee(25, "Yusuf Scott", "yusuf.scott@company.com", new DateOnly(2021, 12, 13), Team.ProductManagement),
                new Employee(26, "Zara Green", "zara.green@company.com", new DateOnly(2020, 10, 21), Team.UXUI),
                new Employee(27, "Aaron Baker", "aaron.baker@company.com", new DateOnly(2016, 4, 2), Team.DataEngineering),
                new Employee(28, "Bella Adams", "bella.adams@company.com", new DateOnly(2019, 2, 14), Team.Development),
                new Employee(29, "Carter Nelson", "carter.nelson@company.com", new DateOnly(2017, 6, 30), Team.Support),
                new Employee(30, "Daisy Carter", "daisy.carter@company.com", new DateOnly(2023, 8, 1), Team.DataEngineering),
                new Employee(31, "Daniel Cooper", "daniel.cooper@company.com", new DateOnly(2022, 1, 1), Team.Development),
                new Manager(32, "Emily Turner", "emily.turner@company.com", new DateOnly(2021, 5, 10), Team.Development),
                new Manager(33, "Olivia Martinez", "olivia.martinez@company.com", new DateOnly(2018, 4, 12), Team.DevOps),
                new Manager(34, "Benjamin Carter", "benjamin.carter@company.com", new DateOnly(2019, 9, 3), Team.Security),
                new SecurityEngineer(35, "Ryan Mitchell", "ryan.mitchell@company.com", new DateOnly(2020, 3, 15), Team.Security,SecurityTeam.BlueTeam),
                new SecurityEngineer(36, "Marcus Reed", "marcus.reed@company.com", new DateOnly(2020, 6, 6), Team.Security, SecurityTeam.RedTeam),
                new SecurityEngineer(37, "Sophia Bennett", "sophia.bennett@company.com", new DateOnly(2021, 7, 7), Team.Security, SecurityTeam.ThreatHunting),
                new SecurityEngineer(38, "Aiden Brooks", "aiden.brooks@company.com", new DateOnly(2019, 8, 21), Team.Security, SecurityTeam.PurpleTeam),
                new SecurityEngineer(39, "Chloe Ramirez", "chloe.ramirez@company.com", new DateOnly(2022, 2, 10), Team.Security, SecurityTeam.SOC),
                new SecurityEngineer(40, "Ethan Hayes", "ethan.hayes@company.com", new DateOnly(2018, 11, 5), Team.Security, SecurityTeam.IncidentResponse),
                new SecurityEngineer(41, "Maya Patel", "maya.patel@company.com", new DateOnly(2021, 4, 18), Team.Security, SecurityTeam.GovernanceRiskCompliance),
                new SecurityEngineer(42, "Liam O'Connor", "liam.oconnor@company.com", new DateOnly(2020, 12, 30), Team.Security, SecurityTeam.BlueTeam),
            };
        }
    }
}



//public static List<Employee> GetEmployees()
//{
//    return new List<Employee>
//    {
//        new Employee(1, "Alice Johnson", "alice.johnson@company.com", new DateOnly(2020, 1, 15), Team.Development),
//        new Employee(2, "Bob Smith", "bob.smith@company.com", new DateOnly(2019, 3, 10), Team.DevOps),
//        new Employee(3, "Charlie Brown", "charlie.brown@company.com", new DateOnly(2021, 6, 5), Team.Testing),
//        new Employee(4, "Diana Prince", "diana.prince@company.com", new DateOnly(2018, 11, 20), Team.QA),
//        new Employee(5, "Ethan Clark", "ethan.clark@company.com", new DateOnly(2022, 2, 1), Team.ProductManagement),
//        new Employee(6, "Fiona Davis", "fiona.davis@company.com", new DateOnly(2020, 7, 18), Team.UXUI),
//        new Employee(7, "George Miller", "george.miller@company.com", new DateOnly(2017, 9, 9), Team.DataEngineering),
//        new Employee(8, "Hannah Wilson", "hannah.wilson@company.com", new DateOnly(2023, 1, 12), Team.Security),
//        new Employee(9, "Ian Moore", "ian.moore@company.com", new DateOnly(2019, 4, 30), Team.Support),
//        new Employee(10, "Jane Taylor", "jane.taylor@company.com", new DateOnly(2016, 12, 3), Team.ResearchAndDevelopment),

//        new Employee(11, "Kevin Anderson", "kevin.anderson@company.com", new DateOnly(2020, 8, 14), Team.Development),
//        new Employee(12, "Laura Thomas", "laura.thomas@company.com", new DateOnly(2021, 9, 25), Team.DevOps),
//        new Employee(13, "Michael White", "michael.white@company.com", new DateOnly(2018, 5, 17), Team.Testing),
//        new Employee(14, "Nina Harris", "nina.harris@company.com", new DateOnly(2022, 10, 11), Team.QA),
//        new Employee(15, "Oscar Martin", "oscar.martin@company.com", new DateOnly(2019, 6, 6), Team.ProductManagement),
//        new Employee(16, "Paula Thompson", "paula.thompson@company.com", new DateOnly(2021, 3, 22), Team.UXUI),
//        new Employee(17, "Quentin Garcia", "quentin.garcia@company.com", new DateOnly(2020, 4, 19), Team.DataEngineering),
//        new Employee(18, "Rachel Martinez", "rachel.martinez@company.com", new DateOnly(2017, 2, 8), Team.Security),
//        new Employee(19, "Steven Robinson", "steven.robinson@company.com", new DateOnly(2015, 1, 27), Team.Support),
//        new Employee(20, "Tina Walker", "tina.walker@company.com", new DateOnly(2023, 5, 16), Team.ResearchAndDevelopment),

//        new Employee(21, "Bob Smith", "bob.smithdev@company.com", new DateOnly(2019, 7, 7), Team.Development),
//        new Employee(22, "Victoria Allen", "victoria.allen@company.com", new DateOnly(2020, 9, 3), Team.DevOps),
//        new Employee(23, "William Young", "william.young@company.com", new DateOnly(2018, 8, 28), Team.Testing),
//        new Employee(24, "Xenia King", "xenia.king@company.com", new DateOnly(2022, 11, 9), Team.QA),
//        new Employee(25, "Yusuf Scott", "yusuf.scott@company.com", new DateOnly(2021, 12, 13), Team.ProductManagement),
//        new Employee(26, "Zara Green", "zara.green@company.com", new DateOnly(2020, 10, 21), Team.UXUI),
//        new Employee(27, "Aaron Baker", "aaron.baker@company.com", new DateOnly(2016, 4, 2), Team.DataEngineering),
//        new Employee(28, "Bella Adams", "bella.adams@company.com", new DateOnly(2019, 2, 14), Team.Security),
//        new Employee(29, "Carter Nelson", "carter.nelson@company.com", new DateOnly(2017, 6, 30), Team.Support),
//        new Employee(30, "Daisy Carter", "daisy.carter@company.com", new DateOnly(2023, 8, 1), Team.ResearchAndDevelopment)
//    };
//}