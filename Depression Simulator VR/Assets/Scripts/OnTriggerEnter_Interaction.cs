using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class OnTriggerEnter_Interaction : MonoBehaviour
{
    [SerializeField] PlayableDirector director;
    // [SerializeField] PlayableAsset asset;
    [SerializeField] GameObject destroy;
    public Director_Positive positive;
    public Director_Neutraal neutraal;
    // public Ditector_Depresive depressief:

    private Scene scene;

    
    void Start() {
        scene = SceneManager.GetActiveScene();
        Debug.Log("Name: " + scene.name);
    }

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag.Equals("PlayerHand")) {
                Destroy(destroy);


                if (gameObject.name=="BedFrame"){
                    if(scene.name == "Story - Positive") 
                    {
                        positive.PlayBed();
                    } else if (scene.name == "Story - Neutral")
                    {
                        neutraal.PlayBed();
                    } else if (scene.name == "Story - Depressed")
                    {
                        // depressief.PlayBed();
                    }
                }

                if (gameObject.name == "Gamingtoetsenbord" || gameObject.name == "GamingMouse")
                {
                    if (scene.name == "Story - Positive")
                    {
                        positive.PlayComputer();
                    }
                    else if (scene.name == "Story - Neutral")
                    {
                        neutraal.PlayComputer();
                    }
                    else if (scene.name == "Story - Depressed")
                    {
                        // depressief.PlayComputer();
                    }
                }
        }
    }



}
