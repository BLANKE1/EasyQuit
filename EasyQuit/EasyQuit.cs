﻿using MelonLoader;
using UIExpansionKit.API;
using System.Diagnostics;

[assembly: MelonInfo(typeof(KillGame.Main), "EasyQuit", "0.0.1", "BLANKE")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace KillGame
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            var Menu = ExpansionKitApi.CreateCustomQuickMenuPage(LayoutDescription.WideSlimList);
            Menu.AddLabel("Are you sure you want to close the game?");
            Menu.AddSimpleButton("Close Game", () => Process.GetCurrentProcess().Kill());
            Menu.AddSimpleButton("Close", () => Menu.Hide());
            ExpansionKitApi.GetExpandedMenu(ExpandedMenu.QuickMenu).AddSimpleButton("Close Game", () => Menu.Show());
        }
    }
}