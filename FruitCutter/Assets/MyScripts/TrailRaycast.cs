using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrailRaycast : MonoBehaviour
{
    Camera camera;

    int scoreAmount;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("FreePlayPlayerScore", scoreAmount);

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Has Clicked mouse button");
            Debug.Log(Input.mousePosition);
            

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider == true)
                {
                    Debug.Log("You should have hit something with a collider");
                    scoreAmount++;
                    TMP_Text scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
                    scoreText.text = scoreAmount.ToString();
                }
                Debug.Log("Raycast position is: " + Input.mousePosition);
                hit.collider.gameObject.GetComponent<ProcessSlice>()?.DestroyFruit();
            }
        }
    }
}
