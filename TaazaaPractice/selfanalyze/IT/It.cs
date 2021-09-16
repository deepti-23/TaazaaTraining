namespace selfanalyze.It
{
    public class Taazaa
    {
        double Salary;
        readonly int EmpId;
        static string cafetaria;   


        public Taazaa(int EId,double Sal)
        {
            Salary=Sal;
            EmpId=EId;
        }
        static Taazaa()
        {
            cafetaria="100 sq.ft.";
        }



        public int EmployeeId()     
        {
            return EmpId;
        }


        public double EmployeeSalary()     
        {
            return Salary;
        }


        public static string CoffeeHouse()   
        {
            return cafetaria;
        }
    }
}