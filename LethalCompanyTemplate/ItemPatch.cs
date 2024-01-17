using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine.UIElements;

namespace LethalCompanyTemplate
{
    [HarmonyPatch(typeof(GrabbableObject))]
    public class ItemPatch
    {
        [HarmonyPatch(nameof(GrabbableObject.Start))]
        [HarmonyPostfix]
        public static void ChangeItemName(GrabbableObject __instance)
        {
            if (__instance == null)
                return;

            string itemName = __instance.itemProperties.name.ToLower();
            if (itemName == "robot toy")
                __instance.itemProperties.name = "Arno 2 Poche";

        }
    }    
    
}
