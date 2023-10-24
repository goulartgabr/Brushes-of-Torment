using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sleepTrigger : MonoBehaviour
{
    public string LevelName;
    public GameObject inticon, bed;
    public AudioSource interact;
    public SceneFader sceneFader; // Reference to the SceneFader script.
    public bool bedLocked = true;
    public GameObject lockedtext2;

    public static bool paintDone = false;

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space)) // Replace with your preferred input condition
        // {
        //     sceneFader.StartScene(LevelName); // Test the scene transition and fading.
        // }

        if (paintDone)
        {
            bedLocked = false;
        }
    }

   void OnTriggerStay(Collider other)
{
    if (other.CompareTag("MainCamera"))
    {
        if (bedLocked)
        {
            lockedtext2.SetActive(true);
        }
        else{
            inticon.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                inticon.SetActive(false);
                interact.Play();
                if (sceneFader != null) // Check for null reference
                {
                    sceneFader.StartScene(LevelName);
                }
            }
        }
    }
}


    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
        }

        lockedtext2.SetActive(false);
    }


}
