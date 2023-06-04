using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGrabIcon : MonoBehaviour
{
    
    
    public void DestroyIcon() {


        foreach (Transform childTransform in this.transform){
            if(childTransform.tag == "Icon"){
            // DestroyImmediate(transform.GetChild(0).gameObject);
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
        }
    }
    
}
