using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System;

/// <summary>
/// Script v�rifiant l'int�grit� de DevMod InEditor
/// </summary>
[InitializeOnLoad]
public class KS_DevMod : Editor
{
    static bool hasSent = false;

    static KS_DevMod()
    {
        EditorApplication.update += Update;
    }

    private static void Update()
    {
       if (SceneManager.GetActiveScene().name == "!Ks_Dev")
       {
            if (!hasSent)
            {
                Debug.Log("[KS_DevMod] : " + "Le daemon Ks_DevMod est <color=green>d�marr�</color>\najout des composants n�cessaire ...");

                if (GameObject.Find("DevMod")) { return; }

                GameObject devMod = new("DevMod");
                devMod.AddComponent<Ks_DevModHost>();

                Debug.Log("[KS_DevMod] : " + "Composants <color=green>ajout�s</color>");
            }
            hasSent = true;
       }
    }
}