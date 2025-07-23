using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExplorer.Core
{
    public class WmiEnvironment
    {
        public static ManagementObjectSearcher Win32Process()
        {
            return new ManagementObjectSearcher("SELECT ProcessId, ParentProcessId, Name FROM Win32_Process");
        }
    }
}
