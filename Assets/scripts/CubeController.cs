using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {   if (GameController.ActiveCube != null) // null means that there is no value assigned to the variable
        {
            GameController.ActiveCube.GetComponent<Renderer>().material.color = Color.white;//what is currently the active cube is turned white
        }
        gameObject.GetComponent< Renderer > ().material.color = Color.red;
        GameController.ActiveCube = gameObject; //the variable ActiveCube is now assigned to the cube that was just clicked
    }
}
