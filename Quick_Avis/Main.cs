using MelonLoader;
using UnityEngine;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using System.Diagnostics;
using ActionMenuApi.Pedals;
using ActionMenuApi;
using ActionMenuApi.Api;

namespace Quick_Avis
{
    public static class BuildInfo
    {
        public const string Name = "Quick Avatars";
        public const string Author = "SkYri3L";
        public const string Company = "null";
        public const string Verison = "0.0.1";
        public const string DownloadLink = "https://github.com/SkYri3L/Quick_Avis";
        public const string Descripiton = "Adds the option to favourite/unfavourite and swap avatars in the Action menu.";
    }
    
    
    public class Main : MelonMod
    {
        internal PedalSubMenu subMenu;
        private readonly string[] AmApiODV = { "0.1.0", "0.1.2", "0.2.0", "0.2.1", "0.2.2", "0.2.3" };
        public static bool isDebug;

        public override void OnApplicationStart()
        {
            if (MelonDebug.IsEnabled() || Environment.CommandLine.Contains("--QuickAvi.debug"))
            {
                isDebug = true;
                MelonLogger.Msg(ConsoleColor.Green, "Debug mode is active");
            }
            MelonLogger.Msg("Initializing .  .  .");

            if (MelonHandler.Mods.Any(m => m.Info.Name.Equals("ActionMenuApi")))
            {
                if (MelonHandler.Mods.Single(m => m.Info.Name.Equals("ActionMenuApi")).Info.Version
                    .Equals(AmApiODV))
                {
                    MelonLogger.Warning(
                        "ActionMenuApi Outdated. older versions are not supported, please update the other mod");
                }
                else BuildActionMenu();
            }

            void BuildActionMenu()
            {
            }
            
            
        }


    }
}