using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMPAdaptivityScene : MonoBehaviour
{
    public static TEMPAdaptivityScene tEMPAdaptivityScene;
    public bool grabCheck = false;

    private void Awake(){
        if (tEMPAdaptivityScene == null) 
        {
            tEMPAdaptivityScene = this;
            DontDestroyOnLoad(gameObject);
        } else 
        {
            Destroy(gameObject);
        }
    }

   void Update() {
           ToggleActive();

        // GameObject[] passive = GameObject.FindGameObjectsWithTag("Passive");
        // GameObject[] active = GameObject.FindGameObjectsWithTag("Active");

        // if (active == null) return;
        // if (passive == null) return;


        // if (grabCheck == false)
        // {
        //     foreach (GameObject passiveObject in passive)
        //     {
        //         // passiveObject.SetActive(true);
        //         Debug.Log(passiveObject.name);

        //         if (passiveObject == null) return;
        //     }
        // }
        // if (grabCheck == true)
        // {
        //     foreach (GameObject activeObject in active)
        //     {
        //         // activeObject.SetActive(true);
        //         Debug.Log(activeObject.name);

        //         if (activeObject == null) return;
        //     }
        // }
    
   }

    void ToggleActive()
    { 
        GameObject passive = GameObject.FindGameObjectWithTag("Passive");
        GameObject active = GameObject.FindGameObjectWithTag("Active");

        if (active == null) return;
        if (passive == null) return;


        if (grabCheck == false){

            active.SetActive(false);
     
        } 
        if (grabCheck == true){

            passive.SetActive(false);

        }
    }

    public void Toggle (){
        grabCheck = true;
    }


}
