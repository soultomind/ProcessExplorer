using System.Management;

namespace ProcessExplorer.Core
{
    /// <summary>
    /// <see cref="System.Management.ManagementObjectSearcher"/>(Win32_Process) Tree Node Class
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
    public class Win32ProcessTreeNode
    {
        public const int InvalidProcessId = 0;
        public required string Name { get; set; }
        public int ParentProcessId { get; set; }
        public int ProcessId { get; set; }
        public List<Win32ProcessTreeNode> Children { get; } = new List<Win32ProcessTreeNode>();

        public override string ToString()
        {
            return $"{Name} (ProcessId: {ProcessId}, ParentProcessId: {ParentProcessId})";
        }

        public static Win32ProcessTreeNode Parse(ManagementObject mObject)
        {
            return new Win32ProcessTreeNode
            {
                Name = mObject["Name"]?.ToString() ?? string.Empty,
                ParentProcessId = Convert.ToInt32(mObject["ParentProcessId"] ?? InvalidProcessId),
                ProcessId = Convert.ToInt32(mObject["ProcessId"] ?? InvalidProcessId)
            };
        }
    }
}
