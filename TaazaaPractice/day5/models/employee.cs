namespace day5.models
{
    public class employee
    {
        private int Eid;  // pillow
        private double salary;

        public int Employeeid        //(pillow cover) Properties   (employeeid is the cover of eid)
        {
            get                    // Access
            {
                return Eid;
            }
            set                   //Assign    chain
            {
                Eid=value;         // (put the pillow into cover)Value is a reserve keyword to assign the data to the variable 
            }
        }
        public double Employeesalary
        {
            get
            {
                return salary;
            }
            set
            {
                salary=value;
            }
        }
    }
}