using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour 
{
    private Color startColor;
    public bool targetted = false;
    private Material material;

    void Start ()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
    }

    void Update ()
    {
	      if (targetted)
        {
            Target();
            targetted = false;
        } else
        {
            Untarget();
        }
    }

    public void Target ()
    {
        material.color = Color.green;
    }
    
    public void Untarget()
    {
        material.color = startColor;
    }
}
