using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnLocation;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Cube Triggered by " + other.name);
        
        if(other.CompareTag("Player"))
        {
            Debug.Log("Instantiating Friend");
            GameObject prefabSpawn = Instantiate(prefabToSpawn, spawnLocation.position, spawnLocation.rotation);
            prefabSpawn.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        }
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
