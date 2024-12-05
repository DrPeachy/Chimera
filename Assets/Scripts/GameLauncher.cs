using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLauncher : MonoBehaviour
{
    public string pathToManagerScripts = "Scripts/Managers";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LaunchManagers(){
        GameObject managers = new GameObject("Managers");
        // Load all the manager scripts
        var managerScripts = Resources.LoadAll(pathToManagerScripts, typeof(MonoBehaviour));
        foreach (var manager in managerScripts)
        {
            GameObject managerObject = new GameObject(manager.name);
        }

    }
}
