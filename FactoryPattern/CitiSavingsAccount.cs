using AbstractClasses;

namespace FactoryPattern
{
    // Concrete Product
    public class CitiSavingsAcct : SavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }
}
