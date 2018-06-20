using UnityEngine;
using System.Collections;

public class GazePointer : MonoBehaviou
{
  GameObject hitObject;
  RaycastHit hit;
  public Reticle reticle;

	// Update is called once per frame
  void Update ()
  {
       if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
       {
            reticle.SetPosition(hit);
            hitObject = hit.transform.gameObject;
            Interactable interactable = hitObject.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.targetted = true;
            }
        } else
        {
            reticle.SetPosition();
        }
  }
}
