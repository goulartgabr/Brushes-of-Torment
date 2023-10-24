using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class artChoice : MonoBehaviour
{
    public GameObject artOptionOne,
        artOptionTwo,
        artChosenOne,
        artChosenTwo,
        inttext,
        lockedtext;

    public bool unlocked,
        locked,
        choosing;

    public AudioSource interact;

    public static bool brushfound;

    void Start()
    {
        choosing = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (choosing == false)
        {
            if (other.CompareTag("MainCamera"))
            {
                if (unlocked == false)
                {
                    if (locked == false)
                    {
                        inttext.SetActive(true);

                        if (gameObject == artOptionOne)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                artOptionOne.SetActive(false);
                                artOptionTwo.SetActive(false);
                                artChosenOne.SetActive(true);
                                inttext.SetActive(false);
                                choosing = true;
                                interact.Play();
                                sleepTrigger.paintDone = true;
                            }
                        }

                        if (gameObject == artOptionTwo)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                artOptionOne.SetActive(false);
                                artOptionTwo.SetActive(false);
                                artChosenTwo.SetActive(true);
                                inttext.SetActive(false);
                                choosing = true;
                                interact.Play();
                                sleepTrigger.paintDone = true;
                            }
                        }

                        
                    }
                    if (locked == true)
                    {
                        lockedtext.SetActive(true);
                    }
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            lockedtext.SetActive(false);
        }
    }

    void Update()
    {
        if (brushfound == true)
        {
            locked = false;
        }
    }
}
