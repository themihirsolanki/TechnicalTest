using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor;

namespace Ulaw.ApplicationProcessor
{
    public interface IMessageBuilder
    {
        string Build(Application application); // Application object should be implemented with interface too so that we can pass them around with depending on the actual type
    }
}
