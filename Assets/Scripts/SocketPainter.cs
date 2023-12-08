using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketPainter : MonoBehaviour
{
    public GameObject socketedObject;

    public void RegisterObject(SelectEnterEventArgs args)
    {
        socketedObject = args.interactableObject.transform.gameObject;
    }

    public void ReleaseObject()
    {
        socketedObject = null;
    }

    public void ChangeMaterial(Material newMaterial)
    {
        if (socketedObject != null)
        {
            Renderer[] renderers = socketedObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer rend in renderers)
            {
                rend.material = newMaterial;
            }
        }
    }
}
