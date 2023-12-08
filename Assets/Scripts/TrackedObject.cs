using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedObject : MonoBehaviour
{
    public GameObject destroyFX;

    private void OnDestroy()
    {
        if(gameObject.scene.isLoaded)
        {
            Instantiate(destroyFX, transform.position, transform.rotation);
        }
    }

    public void AddSelfToList()
    {
        SocketSpawner.Instance.AddToTrackedObjects(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
