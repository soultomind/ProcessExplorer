using System.Management;

namespace ProcessExplorer.Core
{
    /// <summary>
    /// <see cref="System.Management.ManagementObjectSearcher"/>(Win32_Process)
    /// <para>
    /// Name: System Idle Process
    /// </para>
    /// <para>
    /// ParentProcessId: 0
    /// </para>
    /// <para>
    /// ProcessId: 0
    /// </para>
    /// </summary>
    public class Win32Process
    {
        public required string Name { get; set; }
        public int ParentProcessId { get; set; }
        public int ProcessId { get; set; }

        public override string ToString()
        {
            return $"{Name} (PID: {ProcessId}, Parent PID: {ParentProcessId})";
        }

        public static Win32Process Parse(ManagementObject mObject)
        {
            return new Win32Process
            {
                Name = mObject["Name"]?.ToString() ?? string.Empty,
                ParentProcessId = Convert.ToInt32(mObject["ParentProcessId"] ?? 0),
                ProcessId = Convert.ToInt32(mObject["ProcessId"] ?? 0)
            };
        }
    }
}
