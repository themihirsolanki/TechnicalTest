using ULaw.ApplicationProcessor;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor
{
    public class MessageCreatorFactory : IMessageCreatorFactory
    {
        // There are different ways of implementing this rather than hard coding like this
        public IMessageCreator Create(Application application)
        {
            if (application.DegreeGrade == DegreeGradeEnum.twoTwo)
            {
                return new TwoTwoMessageCreator(application);
            }
            else if (application.DegreeGrade == DegreeGradeEnum.third)
            {
                return new ThirdMessageCreator(application);
            }
            else if (application.DegreeSubject == DegreeSubjectEnum.law ||
                     application.DegreeSubject == DegreeSubjectEnum.lawAndBusiness)
            {
                return new LawMessageCreator(application);
            }

            return new DefaultMessageCreator(application);
        }
    }
}
