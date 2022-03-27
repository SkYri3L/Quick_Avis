using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(Quick_Avis.BuildInfo.Name)]
[assembly: AssemblyDescription(Quick_Avis.BuildInfo.Descripiton)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(Quick_Avis.BuildInfo.Company)]
[assembly: AssemblyProduct(Quick_Avis.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + Quick_Avis.BuildInfo.Author)]
[assembly: AssemblyTrademark(Quick_Avis.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]


//[assembly: Guid("")]
[assembly: Guid("E17EB428-E3A2-4AD4-BB7D-420A4410CFF2")]

[assembly: AssemblyVersion(Quick_Avis.BuildInfo.Verison)]
[assembly: AssemblyFileVersion(Quick_Avis.BuildInfo.Verison)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(Quick_Avis.Main),
    Quick_Avis.BuildInfo.Name, 
    Quick_Avis.BuildInfo.Verison,
    Quick_Avis.BuildInfo.Author,
    Quick_Avis.BuildInfo.DownloadLink)]
[assembly: MelonColor(ConsoleColor.Magenta)]
[assembly: MelonGame("VRChat", "VRChat")]
