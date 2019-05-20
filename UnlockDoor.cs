using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockDoor : MonoBehaviour {

    

    public bool playerPresent = false;

    public string KeyNeeded = "none";

    private Animator crate;

    public GameObject displayText;
    public GameObject displayKeedNeeded;

  

	void Start ()
    {
        crate = GetComponent<Animator>();
        displayText.SetActive(false);
        displayKeedNeeded.SetActive(false);
    }
	
	
	void Update ()
    {
       
        GameObject thePlayer = GameObject.FindGameObjectWithTag("Player");
        Inventory inv = thePlayer.GetComponent<Inventory>();
        if (playerPresent)
        {
            if (inv.HasKey(KeyNeeded))
            {
                displayText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    DoorUnlocked();
                }

            }
            else
            {
                displayKeedNeeded.SetActive(true);
                displayText.SetActive(false);
            }

        }
    }

 

    public void DoorUnlocked()
    {
        crate.SetBool("OpenCrate", true);
        displayText.SetActive(false);
        displayKeedNeeded.SetActive(false);

    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerPresent = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerPresent = false;
            displayText.SetActive(false);
            displayKeedNeeded.SetActive(false);
        }
    }

    
}
