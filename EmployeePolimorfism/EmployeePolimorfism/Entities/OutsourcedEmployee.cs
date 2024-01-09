using System.Xml.Linq;

namespace EmployeePolimorfism.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }
        public OutsourcedEmployee(double aditionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour) 
        {
            aditionalCharge = AditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;
        }
    }
}
