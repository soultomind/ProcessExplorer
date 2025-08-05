using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExplorer.Core
{
    public class ProcessExplorerContext
    {
        public static Assembly ThisAssembly
        {
            get
            {
                return typeof(ProcessExplorerContext).Assembly;
            }
        }
        public static Version Version
        {
            get
            {
                return ThisAssembly.GetName().Version;
            }
        }
    }
}
