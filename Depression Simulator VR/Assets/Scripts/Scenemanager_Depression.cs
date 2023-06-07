using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenemanager_Depression : MonoBehaviour
{

    [SerializeField] GameObject positiveWorldLoad;

     public Director_Depressief depressief;

    void  Awake() {
        positiveWorldLoad.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (depressief.interactionCount == 4) {
            positiveWorldLoad.SetActive(true);
        }
    }
}
