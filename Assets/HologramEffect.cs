using UnityEngine;

public class HologramEffect : MonoBehaviour
{
    public Material hologramMaterial;
    
    private Material originalMaterial;
    private MeshRenderer meshRenderer;
    private bool isHologram = false;

    void Start()
    {
        // Get the renderer from the 3D model this script is attached to
        meshRenderer = GetComponent<MeshRenderer>();
        
        if (meshRenderer != null)
        {
            // Save the normal flesh material so we can revert back to it
            originalMaterial = meshRenderer.material;
        }
    }

    // The other script will call this function
    public void SwapMaterial()
    {
        if (meshRenderer == null) return;

        isHologram = !isHologram; // Toggle the state
        
        // Apply the correct material based on the state
        meshRenderer.material = isHologram ? hologramMaterial : originalMaterial;
    }
}