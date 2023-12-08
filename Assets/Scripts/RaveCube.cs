using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaveCube : MonoBehaviour
{
    public bool  checkBox;
    public MeshRenderer otherRenderer;
    public float pastParameter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    Color GenerateRandomColor(){
        return Random.ColorHSV();
    }

    //new function
    void ChangeColor(){
        Debug.Log("Changing color now");
        otherRenderer.material.color = GenerateRandomColor();
    }

    void MoveUp(float amount){
        
        transform.position += Vector3.up * amount;

    }

    // Update is called once per frame
    void Update()
    {
        if(checkBox){
            Debug.Log("Checked the box");
            checkBox = false;
            ChangeColor();
            MoveUp(pastParameter);
        }
    }
}
