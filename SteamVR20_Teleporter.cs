using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SteamVR20_Teleporter : MonoBehaviour
{
    public GameObject m_Pointer;
    public SteamVR_Action_Boolean m_TeleportAction;

    private SteamVR_Behaviour_Pose m_Pose = null;
    private bool m_HasPosition = false;

    private void Awake()
    {
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();
    }

    private void Update()
    {
        // Pointer
        m_HasPosition = UpdatePointer();
        m_Pointer.SetActive(m_HasPosition);
        //Teleport
        if (m_TeleportAction.GetStateUp(m_Pose.inputSource))
            TryTeleport();          
    }

    private void TryTeleport()
    {
        
    }


    private IEnumerator MoveRig(Transform cameraRig, Vector3 Translation)
    {
        yield return null;
    }

    private bool UpdatePointer()
    {
        // Ray from the controller
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        // If it's a hit
        if(Physics.Raycast(ray, out hit))
        {
            m_Pointer.transform.position = hit.point;
            return true;
        }
        // If not a hit

        return false;
    }
