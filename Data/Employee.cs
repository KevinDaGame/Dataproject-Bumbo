using System;

namespace Data
{
    public class Employee
    {
        public int Id { get; set; }
        public Role Role { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String Language { get; set; }
        public DateTime BirthDate { get; set; }
    }
}