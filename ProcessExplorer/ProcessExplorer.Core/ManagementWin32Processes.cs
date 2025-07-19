using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExplorer.Core
{
    public class ManagementWin32Processes
    {
        public List<Win32Process> Processes { get; private set; }

        private ManagementWin32Processes()
            : this(new List<Win32Process>())
        {
            
        }

        private ManagementWin32Processes(List<Win32Process> processes)
        {
            if (processes == null)
            {
                throw new ArgumentNullException(nameof(processes), "Processes list cannot be null.");
            }

            Processes = processes;
        } 
        
        public static bool TryGetProcesses(out ManagementWin32Processes? win32Processes)
        {
            var processes = new List<Win32Process>();
            var searcher = new ManagementObjectSearcher("SELECT Name, ParentProcessId, ProcessId FROM Win32_Process");
            try
            {
                foreach (ManagementObject mObject in searcher.Get())
                {
                    Win32Process win32Process = Win32Process.Parse(mObject);
                    processes.Add(win32Process);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error initializing ManagementObjectSearcher: {ex.Message}");
                win32Processes = null;
                return false;
            }

            win32Processes = new ManagementWin32Processes(processes);
            return true;
        }
    }
}
