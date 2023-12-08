using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public static HelloWorld Instance;
    public Rigidbody rb;
    int numberOfFrames;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {

        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        numberOfFrames = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log("Frame: " + numberOfFrames);
        numberOfFrames = numberOfFrames + 1;
    }
}
