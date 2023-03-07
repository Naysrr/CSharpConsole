class Program
{

    public Class1()
    {


        public User(int id, string firstName, string lastName, int age, decimal salary, decimal tax)
=======
    static void Main(string[] args)
    {
        string[] month = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
        string closedMonth = "Aout";
        double tauxPrime = 0;

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Quel est votre Salaire annuel Brut : ");
        bool salaryInInt = int.TryParse(Console.ReadLine().Replace("€", ""), out int salary);
        Console.WriteLine("\nQuel est votre Taux d'imposition : ");
        double taxes = double.Parse(Console.ReadLine().Replace("%", ""));
        Console.WriteLine("\nQuel est le Taux de la prime de fin d'année : ");
        try
        {
            tauxPrime = double.Parse(Console.ReadLine().Replace("%", ""));
        }
        catch (FormatException)
        {
            Console.WriteLine("Le taux de la Prime de fin d'année doit être un entier");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("La division ne peux pas être par 0");
        }
        Console.WriteLine("\nVous avez un salaire de : " + salary + "€ Brut" + "\nImposable a " + taxes + "%" + "\n avec une prime de fin d'année de : " + tauxPrime + "%");
        double salaryNet = Math.Round(calculateSalary(salary, taxes), 2);
        Console.WriteLine("\nVous gagnez donc : " + salaryNet + "€ Net");
        switch (salary)


        public override string ToString()
        {
            return $"ID: {ID}, Name: {FirstName} {LastName}, Age: {Age}, Salary: {Salary:C}, Tax: {Tax:C}";
        }
    }

}