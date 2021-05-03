

using static CommonComponets.AccessTypeEventArgs;

namespace CommonComponets
{
    public interface IAccessTypeEventArgs
    {
        //AccessTypeEventArgs.AccessType GetAccessType();
        AccessTypeEventArgs.AccessType AccessTypeValue { get; set; }
        bool ValuesWereChanged { get; set; }

        //void SetAccessType(AccessTypeEventArgs.AccessType accessType);
    }
}