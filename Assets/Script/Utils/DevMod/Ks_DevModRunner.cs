using System;
using UnityEngine;

/// <summary>
/// Script d�rivant de l'h�b�rgeur de l'API de DevMod
/// </summary>
public class Ks_DevModRunner : Ks_DevModHost
{
    /// <summary>
    /// Est appel� lors de l'execution
    /// </summary>
    /// <param name="active"></param>
    public override void OnStart(bool active)
    {
        Debug.Log("Ok 2");
    }

    /// <summary>
    /// Est appel� lors de l'execution de chaque frame
    /// </summary>
    /// <param name="active"></param>
    public override void OnUpdate(bool active)
    {
        Debug.Log("Ok 2");
    }
}