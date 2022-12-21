using System.Diagnostics;
using System.Reflection;
using Version;

CVersion version = new();

// System.EntryPointNotFoundException : 'Unable to find an entry point named 'GetFileVersionInfoSizeExW' in DLL 'version.dll'.'
var vi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
