using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEMPSceneManager : MonoBehaviour
{
    
    public void LoadSecondPhase() {
        SceneManager.LoadScene(1);
    }

    public void LoadLastPhase()
    {
        SceneManager.LoadScene(2);
    }

}
