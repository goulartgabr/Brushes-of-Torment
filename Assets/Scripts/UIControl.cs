using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public Canvas letterCanvas;
    public Canvas letter1ZoomCanvas; // Reference to the Letter1Zoom canvas

    private void Start()
    {
        // Make sure the button starts hidden
        letterCanvas.enabled = false;
    }

    public void OnButtonClick()
    {
        if (letterCanvas != null)
        {
            // Toggle the visibility of the UI canvas when the button is clicked.
            letterCanvas.enabled = !letterCanvas.enabled;
            letterCanvas.gameObject.SetActive(false);
            letterScript.cardOnScreen = false;
            Debug.Log("Changing letterCanvas state -> " + letterCanvas.enabled);

            // Toggle the cursor lock and visibility, just like in your original script.
            Cursor.lockState = letterCanvas.enabled ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = letterCanvas.enabled;

            // Additionally, toggle the visibility of the Letter1Zoom canvas
            if (letter1ZoomCanvas != null)
            {
                letter1ZoomCanvas.enabled = !letterCanvas.enabled;
            }

            easelPaint.letterfound = true;
        }
    }
}
