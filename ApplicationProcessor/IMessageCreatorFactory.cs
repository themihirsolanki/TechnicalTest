using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public interface IMessageCreatorFactory
    {
        IMessageCreator Create(Application application);
    }
}
