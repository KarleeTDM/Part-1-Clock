using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reminder : MonoBehaviour
{
    private static ILogger logger = Debug.unityLogger;
    private static string remind = "REMINDER";
    // Start is called before the first frame update
    void Start()
    {
        logger.LogWarning(remind, "You won't get full marks!");
        logger.LogWarning(remind, "Be sure to fulfill tasks 1 and 2.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
