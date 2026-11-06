using UnityEngine;

public class AnatomyToggle : MonoBehaviour
{
    // 1. Create a reference to the other script
    public HologramEffect hologramScript;

    public void ToggleVisibility()
    {
        Debug.Log("Action Done - Telling the other script to swap materials.");
        
        // 2. Make sure the script is assigned, then trigger the swap
        if(hologramScript != null)
        {
            hologramScript.SwapMaterial();
        }
        else 
        {
            Debug.LogWarning("Hologram script is missing! Please assign it in the Inspector.");
        }
    }
}