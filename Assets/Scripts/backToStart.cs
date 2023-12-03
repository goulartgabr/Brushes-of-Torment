using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToStart : MonoBehaviour
{
    public GameObject inticon, bed;
    public AudioSource interact;
    public bool bedLocked = true;
    public GameObject lockedtext2;
    public Animator animator;

    public static bool paintDone = false;
    private int leveltoLoad;

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space)) // Replace with your preferred 
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
                FadetoNextLevel();
                inticon.SetActive(false);
                interact.Play();
                
            }
        }
    }
}
public void FadetoNextLevel (){
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
 public void FadeToLevel (int levelIndex)
        {
            leveltoLoad = levelIndex;
             Debug.Log("Fading to level: " + levelIndex);
            animator.SetTrigger("FadeOut");
        }
    public void OnFadeComplete () {
        Debug.Log("Loading level: " + leveltoLoad);
        SceneManager.LoadScene(leveltoLoad + SceneManager.GetActiveScene().buildIndex - 4);

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
