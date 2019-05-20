using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipTakeOff : MonoBehaviour
{
    public Animator shipCockPit;
    public GameObject cockPit;

    public Animator shiptakeFlight;
    public GameObject shipOut;

    public GameObject enableCockpitCam;
    public GameObject disablePlayer;

    void Start()
    {
        shipCockPit = cockPit.GetComponent<Animator>();

        shiptakeFlight = shipOut.GetComponent<Animator>();

        enableCockpitCam.SetActive(false); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            disablePlayer.SetActive(false);
            enableCockpitCam.SetActive(true);
            ShipApproved();
            ShipLeaveHanger();
            StartCoroutine(WaitForTakeOff());
        }
    }

    public void ShipApproved()
    {
        shipCockPit.SetBool("CloseCockPit", true);
        
    }

    public void ShipLeaveHanger()
    {
        shiptakeFlight.SetBool("ShipWillLeave", true);
    }

    IEnumerator WaitForTakeOff()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }


}
