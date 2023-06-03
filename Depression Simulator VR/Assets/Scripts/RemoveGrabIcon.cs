using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGrabIcon : MonoBehaviour
{
    
    
    public void DestroyIcon() {


        while (transform.childCount > 0) {
            if(transform.GetChild(0).gameObject.tag == "icon")
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
    
}
