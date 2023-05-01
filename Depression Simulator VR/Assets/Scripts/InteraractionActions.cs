using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraractionActions : MonoBehaviour
{

    public VRScreenEffects fadeControll;
    public GameObject fadeCanvas;

     void Awake() {

        Debug.Log("hello World");
    }

        


    public void FadeIn(){
        Debug.Log("Fade in");

        fadeControll.FadeOut();
    }
}
