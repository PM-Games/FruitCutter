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
        Debug.DrawRay(camera.ScreenPointToRay(Input.mousePosition), Color.red);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Has Clicked mouse button");
            Debug.Log(Input.mousePosition);

            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider == true)
                {
                    Debug.Log("You should have hit something with a collider");
                }
                Debug.Log("Raycast position is: " + Input.mousePosition);
                hit.collider.gameObject.GetComponent<ProcessSlice>().DestroyFruit();
            }
        }
    }
}
