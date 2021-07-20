using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public interface IMessageCreatorFactory
    {
        IMessageCreator Create(Application application);
    }
}
