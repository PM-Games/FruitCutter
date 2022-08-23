using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrailRaycast : MonoBehaviour
{
    Camera camera;
    TMP_Text score;

    int scoreAmount;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        score = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
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
                    score.text = scoreAmount.ToString();
                }
                Debug.Log("Raycast position is: " + Input.mousePosition);
                hit.collider.gameObject.GetComponent<ProcessSlice>()?.DestroyFruit();
            }
        }
    }
}
