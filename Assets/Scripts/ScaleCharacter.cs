using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCharacter : MonoBehaviour
{
    public Vector3 setScale = new Vector3(1,2,3);
    public Transform otherTransform;

    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = setScale;
        otherTransform.localScale = setScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
