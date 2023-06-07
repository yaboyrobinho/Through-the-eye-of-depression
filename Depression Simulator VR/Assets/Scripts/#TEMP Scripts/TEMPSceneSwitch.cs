using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEMPSceneSwitch : MonoBehaviour
{


    public void LoadScene2() {
        SceneManager.LoadScene(1);
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(2);
    }
}
