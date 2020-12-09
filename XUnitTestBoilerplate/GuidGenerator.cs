using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestBoilerplate
{
    public class GuidGenerator
    {
        public Guid RandomGuid { get; } = Guid.NewGuid();
    }
}
