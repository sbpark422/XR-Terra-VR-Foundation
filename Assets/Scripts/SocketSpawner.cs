using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SocketSpawner : MonoBehaviour
{
    public static SocketSpawner Instance;
    public List<GameObject> trackedObjects;
    public Transform  socketTransform;
    public GameObject currentlyHeldPrefab;

    private void Awake()
    {
        if(Instance ==  null)
        {
            Instance = this;
            
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddToTrackedObjects(GameObject objectToAddToList)
    {
        trackedObjects.Add(objectToAddToList);
    }
    public void SpawnPrefab(GameObject prefabToSpawn)
    {

        if(currentlyHeldPrefab != null)
        {
            Destroy(currentlyHeldPrefab);
        }

        Debug.Log("Spawning Prefab Now");

        Vector3 newPosition = new Vector3(socketTransform.position.x, socketTransform.position.y - 0.3f, socketTransform.position.z);
        currentlyHeldPrefab = Instantiate(prefabToSpawn, newPosition, socketTransform.rotation);

        // currentlyHeldPrefab = Instantiate(prefabToSpawn, socketTransform.position, socketTransform.rotation);

    } 

    public void DestroyNow()
    {
        // Debug.Log("Destry everything in the list!");

        // foreach(GameObject go in  trackedObjects)
        // {
        //     Destroy(go);
        // }

        // trackedObjects.Clear();
        
        StartCoroutine(DestroyObjectsOverTime());
    
    }

    IEnumerator DestroyObjectsOverTime()
    {
        Debug.Log("Destry everything in the list!");

        foreach(GameObject go in  trackedObjects)
        {
            DestroyImmediate(go,true);
            yield return new WaitForSeconds(.4f);
        }

        trackedObjects.Clear();
    }

    public void DontDestroyThisObject(SelectExitEventArgs args)
    {
        if(args.interactable.gameObject == currentlyHeldPrefab)
        {
            currentlyHeldPrefab = null;
        }
    }

    public void AssignCuurentHeldPrefabReference(SelectEnterEventArgs args)
    {
        currentlyHeldPrefab = args.interactable.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        //trackedObjects = new List<GameObject>();
    }

}   
