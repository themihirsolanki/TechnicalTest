using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public class ThirdMessageCreator : IMessageCreator
    {
        private readonly Application _application;

        public ThirdMessageCreator(Application application)
        {
            _application = application;
        }


        public string Create()
        {
            var result = new StringBuilder();

            result.Append(string.Format("<p> Dear {0}, </p>", _application.FirstName));
            result.Append("<p/> Further to your recent application, we are sorry to inform you that you have not been successful on this occasion.");
            result.Append("<br/> If you wish to discuss the decision further, or discuss the possibility of applying for an alternative course with us, please contact us at AdmissionsTeam@Ulaw.co.uk.");
            result.Append("<br> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");

            return result.ToString();
        }
    }
}
