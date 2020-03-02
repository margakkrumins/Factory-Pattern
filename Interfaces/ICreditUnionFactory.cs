using AbstractClasses;

namespace Interfaces
{
    public interface ICreditUnionFactory
    {
        SavingsAccount GetSavingsAccount(string acctNo);
    }
}
