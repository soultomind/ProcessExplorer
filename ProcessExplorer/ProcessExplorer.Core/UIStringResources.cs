using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExplorer.Core
{
    public class UIStringResources
    {
        public const string MyGitHubUrl = "http://www.github.com/soultomind/ProcessExplorer";

        public static string MainFormTitle
        {
            get
            {
                return $"Process Explorer [{Environment.UserDomainName}\\{Environment.UserName}]";
            }
        }
    }
}
