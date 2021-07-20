using System;
using System.Collections.Generic;
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

            result.Append(string.Format("<p> Dear {0}, </p>", _application.FirstName));
            result.Append(string.Format("<p/> Further to your recent application for our course reference: {0} starting on {1}, we are writing to inform you that we are currently assessing your information and will be in touch shortly.", _application.CourseCode, _application.StartDate.ToLongDateString()));
            result.Append("<br/> If you wish to discuss any aspect of your application, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            result.Append("<br/> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");

            return result.ToString();
        }
    }
}
