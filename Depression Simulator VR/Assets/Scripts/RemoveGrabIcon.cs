using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGrabIcon : MonoBehaviour
{
    
    
    public void DestroyIcon() {
        while (transform.childCount > 0) {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
}
