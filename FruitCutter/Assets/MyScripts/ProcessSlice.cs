using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessSlice : MonoBehaviour
{
    public GameObject fruitSliceParticleSystem;
    public ParticleSystem fruitSliceBigSmoke;
    public ParticleSystem fruitSliceGlowSmoke;
    public ParticleSystem fruitSliceEmberTrail;
    public string colorOfFruit;

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
        GameObject fruitParticle = Instantiate(fruitSliceParticleSystem, this.gameObject.transform);

        if (colorOfFruit == "Red")
        {
            ParticleSystem.MainModule psmain = fruitParticle.transform.GetChild(2).gameObject.GetComponent<ParticleSystem>().main;
            psmain.startColor = Color.red;
        }
        
    }
}
