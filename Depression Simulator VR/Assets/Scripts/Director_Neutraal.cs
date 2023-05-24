using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Director_Neutraal : MonoBehaviour
{

    [SerializeField] PlayableDirector director;
    [SerializeField] PlayableAsset[] playable;

    public bool voetbalIsGrabbed = false,
    guitarIsGrabbed = false,
    fotolijstjeIsGrabbed = false,
    computerIsGrabbed = false,
    bedIsGrabbed = false,
    medicijnIsGrabbed = false;

    [SerializeField] int interactionCount = 0;


    void Awake()
    {
        director.Play(playable[0]);
    }

    void Update()
    {
        Debug.Log(interactionCount);
    }

    public void PlayVoetbal()
    {
        if (voetbalIsGrabbed == false)
        {
            director.Play(playable[1]);
        }
    }

    public void PlayGitaar()
    {
        if (guitarIsGrabbed == false)
        {
            director.Play(playable[2]);
        }
    }

    public void PlayFotolijstje()
    {
        if (fotolijstjeIsGrabbed == false)
        {
            director.Play(playable[3]);
        }
    }

    public void PlayComputer()
    {
        if (computerIsGrabbed == false)
        {
            director.Play(playable[4]);
        }
    }

    public void PlayBed()
    {
        if (bedIsGrabbed == false)
        {
            director.Play(playable[5]);
        }
    }

    public void PlayMedicatie()
    {
        if (medicijnIsGrabbed == false){
            director.Play(playable[6]);
        }
    }

    public void PlayEnd()
    {
        director.Play(playable[7]);
    }

    public void VoetbalIsGrabbed()
    {
        voetbalIsGrabbed = true;
    }

    public void GuitarIsGrabbed()
    {
        guitarIsGrabbed = true;
    }

    public void FotolijstjeIsGrabbed()
    {
        fotolijstjeIsGrabbed = true;
    }

    public void ComputerIsGrabbed()
    {
        computerIsGrabbed = true;
    }

    public void BedIsGrabbed()
    {
        bedIsGrabbed = true;
    }

    public void MedicijnIsGrabbed()
    {
        medicijnIsGrabbed = true;
    }

    public void InteractionCounter()
    {
        interactionCount = interactionCount + 1;
    }

    public void InteractionCountChecker()
    {
        if (interactionCount == 6)
        {
            PlayEnd();
        }
    }

    



}
