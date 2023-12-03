using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitGallery : MonoBehaviour
{
    public AudioSource interact;
    public Animator animator;

    private int leveltoLoad;


   void OnTriggerStay(Collider other)
{
    if (other.CompareTag("MainCamera"))
    {
                FadetoNextLevel();
                interact.Play();
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
        SceneManager.LoadScene(leveltoLoad + SceneManager.GetActiveScene().buildIndex +1);

    }
}



 
