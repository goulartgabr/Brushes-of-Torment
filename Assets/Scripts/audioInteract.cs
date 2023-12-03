using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class audioInteract : MonoBehaviour
{

    public GameObject inticon;
    public AudioSource interactPrefab; // The audio source prefab to create new instances
    private List<AudioSource> activeSounds = new List<AudioSource>();

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                // Create a new instance of the audio source and play it
                AudioSource newInteract = Instantiate(interactPrefab, transform.position, Quaternion.identity);
                newInteract.Play();
                
                // Add the new audio source to the list of active sounds
                activeSounds.Add(newInteract);
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
