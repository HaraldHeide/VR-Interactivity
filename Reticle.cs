using UnityEngine;
using System.Collections;

public class Reticle : MonoBehaviour 
{
    [SerializeField]
    private float defaultDistance = 3f;
    public Transform reticleImageTransform;
    public Transform trackedPointer;
    
    private Vector3 originalScale;

    void Start()
    {
        originalScale = reticleImageTransform.localScale;
    }

	public void SetPosition()
    {
        reticleImageTransform.position = trackedPointer.position + trackedPointer.forward * defaultDistance;
        reticleImageTransform.localScale = originalScale;
    }

    public void SetPosition(RaycastHit hit)
    {
        reticleImageTransform.position = hit.point;
        reticleImageTransform.localScale = originalScale * hit.distance;
    }
}
