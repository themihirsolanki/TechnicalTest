using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor;
using ULaw.ApplicationProcessor.Enums;

namespace Ulaw.ApplicationProcessor
{
    public class MessageCreatorFactory : IMessageCreatorFactory
    {
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
