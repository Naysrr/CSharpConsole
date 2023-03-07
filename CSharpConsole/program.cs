class Program
{

    public Class1()
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public decimal Tax { get; set; }

        public User(int id, string firstName, string lastName, int age, decimal salary, decimal tax)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
            Tax = tax;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {FirstName} {LastName}, Age: {Age}, Salary: {Salary:C}, Tax: {Tax:C}";
        }
    }

}