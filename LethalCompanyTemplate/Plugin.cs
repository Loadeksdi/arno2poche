using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace LethalCompanyTemplate
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static String harmonyId = "Arno2poche";
        private void Awake()
        {
            // Plugin startup logic
            Harmony harmony = new(harmonyId);
            harmony.PatchAll(typeof(ItemPatch));
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}