using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public static ObjectTracker Instance;
    public List<GameObject> trackedObjects = new List<GameObject>();
    public float totalDestructionTime = 2f;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void DestroyNow()
    {
        StartCoroutine(DestroyOverTime());
    }

    public void AddToTracked(GameObject objectToAdd)
    {
        trackedObjects.Add(objectToAdd);
    }

    IEnumerator DestroyOverTime()
    {
        //Debug.Log("boom!");
        float timeBetweenSpawns = totalDestructionTime / trackedObjects.Count;
        foreach (GameObject go in trackedObjects)
        {
            Destroy(go);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
        trackedObjects.Clear();
    }
}
