using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public class MessageBuilder : IMessageBuilder
    {
        private readonly IMessageCreatorFactory _factory;
        
        public MessageBuilder(IMessageCreatorFactory factory)
        {
            _factory = factory;
        }

        public string Build(Application application)
        {
            var messageCreator = _factory.Create(application);

            // Header
            var result = new StringBuilder("<html><body><h1>Your Recent Application from the University of Law</h1>");

            result.Append(messageCreator.Create());
            
            // Footer
            result.Append(string.Format("</body></html>"));

            return result.ToString();
        }
    }
}
