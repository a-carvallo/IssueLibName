using System.Diagnostics;
using System.Reflection;
using Version;

namespace NoIssueWithNetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CVersion version = new CVersion();

            // No issue
            var vi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        }
    }
}
