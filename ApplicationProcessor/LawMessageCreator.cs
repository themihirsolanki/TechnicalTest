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
            var result = new StringBuilder();

            result.Append($"<p> Dear {_application.FirstName}, </p>");
            result.Append(
                $"<p/> Further to your recent application, we are delighted to offer you a place on our course reference: {_application.CourseCode} starting on {_application.StartDate.ToLongDateString()}.");
            result.Append(
                $"<br/> This offer will be subject to evidence of your qualifying {_application.DegreeSubject.ToDescription()} degree at grade: {_application.DegreeGrade.ToDescription()}.");
            result.Append(
                $"<br/> Please contact us as soon as possible to confirm your acceptance of your place and arrange payment of the £{depositAmount.ToString()} deposit fee to secure your place.");
            result.Append("<br/> We look forward to welcoming you to the University,");
            result.Append("<br/> Yours sincerely,");
            result.Append("<p/> The Admissions Team,");
            
            return result.ToString();
        }
    }
}
