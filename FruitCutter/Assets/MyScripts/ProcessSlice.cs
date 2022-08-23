using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using FirstGearGames.SmoothCameraShaker;

public class ProcessSlice : MonoBehaviour
{
    public GameObject fruitSliceParticleSystem;
    public string colorOfFruit;
    public ShakeData MyShake;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyFruit()
    {
        GameObject fruitParticle = Instantiate(fruitSliceParticleSystem, this.gameObject.transform.GetChild(0).transform);

        CameraShakerHandler.Shake(MyShake);

        //CHANGE LATER
        this.gameObject.SetActive(false);
        //CHANGE LATER

        ParticleSystem.MainModule psmain = fruitParticle.transform.GetChild(2).gameObject.GetComponent<ParticleSystem>().main;

        if (colorOfFruit == "Red")
        {            
            psmain.startColor = Color.red;
        }
        if (colorOfFruit == "Yellow")
        {
            psmain.startColor = Color.yellow;
        }
        if (colorOfFruit == "Pink")
        {
            psmain.startColor = new Color(255, 0, 241, 255);
        }
        if (colorOfFruit == "Purple")
        {
            psmain.startColor = new Color(204, 0, 255, 255);
        }
        if (colorOfFruit == "Brown")
        {
            psmain.startColor = new Color(255, 113, 0, 255);
        }
        if (colorOfFruit == "Orange")
        {
            psmain.startColor = new Color(255, 83, 0, 255);
        }
        if (colorOfFruit == "Green")
        {
            psmain.startColor = Color.green;
        }
    }
}
