using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOxygen : MonoBehaviour {

    public OxygenTimer timeStart;

    
    public AudioSource noiseMaker;
    public AudioClip gaspingman;


    void Start ()
    {

        noiseMaker = GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OxygenLose")
        {
            timeStart.timerIsActive = true;
            noiseMaker.PlayOneShot(gaspingman, 1.0f);
        }
        if (other.tag == "OxygenGain")
        {
            timeStart.timerIsActive = false;
            noiseMaker.Stop();

        }
    }

}
