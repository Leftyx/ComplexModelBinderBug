using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexModelBinderBug
{
    /// <summary>
    /// Attribute indicating that entered values should not be trimmed
    /// </summary>
    public class NoTrimAttribute : Attribute
    {
    }
}
