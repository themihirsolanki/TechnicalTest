using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public interface IMessageBuilder
    {
        // Here we should be passing interface instead of concrete Application Object
        string Build(Application application);
    }
}
