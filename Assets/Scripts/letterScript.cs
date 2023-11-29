using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterScript : MonoBehaviour
{
    public GameObject inticon, letter;
    public AudioSource interact;
    public Canvas letterCanvas;
    public Image letterImage;

    public static bool cardOnScreen;

    private bool isUIVisible = false;

    void Start()
    {
        inticon.SetActive(false);
        letterCanvas.enabled = false;
        cardOnScreen = false;
    }

    void Update()
    {
    
        if (isUIVisible && Input.GetMouseButtonDown(0))
        {
            ToggleLetterCanvas();
            letterCanvas.enabled = true;
        }
    }

    public void ToggleLetterCanvas()
    {
        isUIVisible = !isUIVisible;
        letterCanvas.enabled = isUIVisible;
        Cursor.lockState = isUIVisible ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = isUIVisible;
        cardOnScreen = true;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                letter.SetActive(false);
                inticon.SetActive(false);
                
                interact.Play();
                ToggleLetterCanvas();
                
                
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
        }
    }
}
