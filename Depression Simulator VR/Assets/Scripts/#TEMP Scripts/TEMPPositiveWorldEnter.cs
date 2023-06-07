using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TEMPPositiveWorldEnter : MonoBehaviour
{

    [SerializeField] GameObject blockadeBorderWall;
    [SerializeField] GameObject walls;
    [SerializeField] GameObject sunPostive;
    [SerializeField] GameObject deur;
    
    [SerializeField] Material cloudySky;

    public PlayableDirector director;
    public PlayableAsset positiveMessage;


    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag =="PlayerHand")
        { 
            walls.SetActive(false);
            sunPostive.SetActive(true);
            blockadeBorderWall.SetActive(true);
            deur.SetActive(false);

            RenderSettings.skybox = cloudySky;
            director.Play(positiveMessage);

        }    
    }
}
