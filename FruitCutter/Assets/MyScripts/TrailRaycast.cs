using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailRaycast : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camera.ScreenToWorldPoint(Input.mousePosition), Vector3.forward, Color.red);
        if (Input.GetKey(KeyCode.Mouse0))
        {            
            Debug.Log("Has Clicked mouse button");
            float mousePosX = Input.mousePosition.x;
            float mousePosY = Input.mousePosition.y;
            Debug.Log("X: " + mousePosX);
            Debug.Log("Y: " + mousePosY);
            
            if (Physics.Raycast(camera.ScreenToWorldPoint(Input.mousePosition), Vector3.forward, out RaycastHit hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider == true)
                {
                    Debug.Log("You should have hit something with a collider");
                }
                Debug.Log("Raycast position is: " + new Vector3(mousePosX, mousePosY, -2f));
                // CREATE NEW SCRIPT TO HANDLE THIS:
                // hit.collider.gameObject.GetComponent<>
            }
        }
    }
}
