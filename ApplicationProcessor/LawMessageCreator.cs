using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public class LawMessageCreator : IMessageCreator
    {
        private readonly Application _application;

        public LawMessageCreator(Application application)
        {
            _application = application;
        }

        public string Create()
        {
            decimal depositAmount = 350.00M; // This shouldn't be hardcoded here but we will ignore for now
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("<p> Dear {0}, </p>", _application.FirstName));
            result.Append(string.Format("<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {0} starting on {1}.", _application.CourseCode, _application.StartDate.ToLongDateString()));
            result.Append(string.Format("<br/> This offer will be subject to evidence of your qualifying {0} degree at grade: {1}.", _application.DegreeSubject.ToDescription(), _application.DegreeGrade.ToDescription()));
            result.Append(string.Format("<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{0} deposit fee to secure your place.", depositAmount.ToString()));
            result.Append(string.Format("<br/> We look forward to welcoming you to the University,"));
            result.Append(string.Format("<br/> Yours sincerely,"));
            result.Append(string.Format("<p/> The Admissions Team,"));
            
            return result.ToString();
        }
    }
}
