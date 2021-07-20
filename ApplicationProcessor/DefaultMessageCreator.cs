using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public class DefaultMessageCreator : IMessageCreator
    {
        private readonly Application _application;

        public DefaultMessageCreator(Application application)
        {
            _application = application;
        }
        
        public string Create()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"<p> Dear {_application.FirstName}, </p>");
            result.Append(
                $"<p/> Further to your recent application for our course reference: {_application.CourseCode} starting on {_application.StartDate.ToLongDateString()}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.");
            result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            result.Append("<br/> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");

            return result.ToString();
        }
    }
}
