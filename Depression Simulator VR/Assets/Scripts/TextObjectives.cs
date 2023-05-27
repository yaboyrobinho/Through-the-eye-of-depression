using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TextObjectives : MonoBehaviour
{

    public TextMeshProUGUI objective;
    public int interactionTotal;

    private Scene scene;
    public Director_Positive positive;
    public Director_Neutraal neutraal;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        objective = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == "Story - Positive")
        {
            objective.text = "Interacteer met de verhaalsvoorwerpen (" + interactionTotal + "/" + positive.interactionCount + ")";
        }
        else if (scene.name == "Story - Neutral")
        {
            objective.text = "Interacteer met de verhaalsvoorwerpen (" + interactionTotal + "/" + neutraal.interactionCount + ")";
        }
        // else if (scene.name == "Story - Depressed")
        // {
        //     // depressief.PlayBed();
        // }
        
    }
}
