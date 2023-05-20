using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Director_Positive : MonoBehaviour
{

    [SerializeField] PlayableDirector director;
    [SerializeField] PlayableAsset[] playable;


    void Awake()
    {
        director.Play(playable[0]);
    }

    public void PlayVoetbal() {
        director.Play(playable[1]);
    }

    public void PlayGitaar()
    {
        director.Play(playable[2]);
    }

    public void PlayFotolijstje()
    {
        director.Play(playable[3]);
    }

    public void PlayComputer()
    {
        director.Play(playable[4]);
    }

    public void PlayBed()
    {
        director.Play(playable[5]);
    }

    public void PlayEnd()
    {
        director.Play(playable[6]);
    }

    



}
