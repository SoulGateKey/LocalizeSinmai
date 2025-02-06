using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(LocalizeSinmai.BuildInfo.Name)]
[assembly: AssemblyDescription(LocalizeSinmai.BuildInfo.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Created by " + LocalizeSinmai.BuildInfo.Author)]
[assembly: AssemblyProduct("LocalizeSinmai")]
[assembly: AssemblyCopyright("Copyright ©  2025")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: MelonInfo(typeof(LocalizeSinmai.LocalizeSinmai), LocalizeSinmai.BuildInfo.Name, LocalizeSinmai.BuildInfo.Version, LocalizeSinmai.BuildInfo.Author, LocalizeSinmai.BuildInfo.DownloadLink)]
[assembly: MelonColor()]


[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]