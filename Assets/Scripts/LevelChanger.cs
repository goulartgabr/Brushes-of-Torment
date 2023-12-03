using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
   public Animator animator;
   
   private int leveltoLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            FadetoNextLevel();
        }
    } 

    public void FadetoNextLevel (){
        FadeToLevel(SceneManager.GetActiveScene().buildIndex +1);
    }

        public void FadeToLevel (int levelIndex)
        {
            leveltoLoad = levelIndex;
            animator.SetTrigger("FadeOut");
        }
    public void OnFadeComplete () {
        SceneManager.LoadScene(leveltoLoad);

    }
}
