using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExplorer.Core
{
    public class Win32ProcessTreeBuilder
    {
        public static List<Win32ProcessTreeNode> Build()
        {
            var processTreeNodeMap = new Dictionary<int, Win32ProcessTreeNode>();
            var parentMap = new Dictionary<int, int>();

            using (var searcher = WmiEnvironment.Win32Process())
            {
                foreach (ManagementObject mObject in searcher.Get())
                {
                    int processId = Convert.ToInt32(mObject["ProcessId"] ?? Win32ProcessTreeNode.InvalidProcessId);
                    int parentProcessId = Convert.ToInt32(mObject["ParentProcessId"] ?? Win32ProcessTreeNode.InvalidProcessId);
                    string name = mObject["Name"]?.ToString() ?? "";
                    var node = new Win32ProcessTreeNode
                    {
                        ProcessId = processId,
                        ParentProcessId = parentProcessId,
                        Name = name
                    };
                    processTreeNodeMap[processId] = node;
                    parentMap[processId] = parentProcessId;
                }
            }

            // 트리 구조 생성
            var roots = new List<Win32ProcessTreeNode>();
            foreach (var item in processTreeNodeMap)
            {
                int processId = item.Key;
                int parentProcessId = parentMap[processId];
                if (processTreeNodeMap.ContainsKey(parentProcessId) && processId != parentProcessId)
                {
                    processTreeNodeMap[parentProcessId].Children.Add(item.Value);
                }
                else
                {
                    roots.Add(item.Value);
                }
            }
            return roots;
        }
    }
}
