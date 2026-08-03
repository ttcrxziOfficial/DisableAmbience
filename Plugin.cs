using System;
using System.Collections.Generic;
using UnityEngine;
using BepInEx;
using HarmonyLib;

namespace DisableAmbience
{
    [BepInPlugin("ttcrxzi.DisableAmbience", "Disable Ambience", "1.0.0")]
    internal class Plugin : BaseUnityPlugin
    {
        public void Start()
        {
            GameObject forest = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight");
            GameObject city = GameObject.Find("City_Pretty/Vista_Prefab/Ouside_Night");
            GameObject cave = GameObject.Find("Cave_Main_Prefab/NewCave/Cave_Audio_Prefab");
            GameObject sky = GameObject.Find("skyjungle/Ambience");
            Debug.Log("[DisableAmbience] Initialize");

            if (forest != null)
            {
                forest.SetActive(false);
                city.SetActive(false);
                cave.SetActive(false);
                sky.SetActive(false);

                Debug.Log("[DisableAmbience] All weather and background audio has been disabled");
            }
        }
    }
}
