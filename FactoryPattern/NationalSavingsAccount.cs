using AbstractClasses;

namespace FactoryPattern
{
    // Concrete Product
    public class NationalSavingsAcct : SavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }
}
