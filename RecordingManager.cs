using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class RecordingManager : MonoBehaviour
{
    public AudioSource soundManager;

    //these are all the voice recordings
    [Header("Audio")]
    public AudioClip nahlaTakeOne;
    public AudioClip nahlaTakeTwo;
    public AudioClip nahlaTakeThree;
    public AudioClip drClarkeTakeOne;
    public AudioClip drClarkeTakeTwo;
    public AudioClip drClarkeTakeThree;
    public AudioClip juanLaugh;
    public AudioClip juanTakeTwo;
    public AudioClip veronicaTakeOne;
    public AudioClip veronicaTakeTwo;
    public AudioClip randalTakeOne;
    public AudioClip randalTakeTwo;
    public AudioClip randalTakeThree;
    public AudioClip masonTakeOnly;

    //these are the objects attached to the voice recordings for pick-ups
    [Header("Game Objects")]
    public GameObject recorderNahla1;
    public GameObject recorderNahla2;
    public GameObject recorderNahla3;
    public GameObject recorderClarke1;
    public GameObject recorderClarke2;
    public GameObject recorderClarke3;
    public GameObject recorderJuanLaugh;
    public GameObject recorderJuan2;
    public GameObject recorderVeronica1;
    public GameObject recorderVeroncia2;
    public GameObject recorderRandalOne;
    public GameObject recorderRandalTwo;
    public GameObject recorderRandalThree;
    public GameObject recorderMason;
   

    //these are the gameobjects for the UI for specific characters
    [Header("Subtitles")]
    public GameObject nahla1Words;
    public GameObject nahla2Words;
    public GameObject nahla3Words;
    public GameObject clarke1Words;
    public GameObject clarke2Words;
    public GameObject clarke3Words;
    public GameObject juan1Words;
    public GameObject juan2Words;
    public GameObject veronica1Words;
    public GameObject veronica2Words;
    public GameObject randal1Words;
    public GameObject randal2Words;
    public GameObject randal3Words;
    public GameObject masonWords;

    //Tracking of what logs the player has collected
    [Header("Found")]
    public bool nahlaOne;
    public bool nahlaTwo;
    public bool nahlaThree;
    public bool drClarkeOne;
    public bool drClarkeTwo;
    public bool drClarkeThree;
    public bool juanOne;
    public bool juanTwo;
    public bool veronicaOne;
    public bool veronicaTwo;
    public bool randalOne;
    public bool randalTwo;
    public bool randalThree;
    public bool masonOnly;
    public GameObject[] replayButtons;

    public bool playerWithin;
    bool soundPlay;
    void Start()
    {
        soundManager = GetComponent<AudioSource>();
        soundPlay = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "StopPlaying")
        {
            StopPlaying();
        }
        if (other.tag == "Nahla1")
        {
            playerWithin = true;
            soundManager.PlayOneShot(nahlaTakeOne, 7.0f);
            Destroy(recorderNahla1);
            StartCoroutine(NahlaOne());
            nahlaOne = true;
            replayButtons[0].transform.GetChild(0).GetComponent<Text>().text = "Nahla Cyro";

        }
        if (other.tag == "Nahla2")
        {
            playerWithin = true;
            soundManager.PlayOneShot(nahlaTakeTwo, 7.0f);
            Destroy(recorderNahla2);
            StartCoroutine(NahlaTwo());
            nahlaTwo = true;
            replayButtons[1].transform.GetChild(0).GetComponent<Text>().text = "Nahla Clinic";
        }
        if (other.tag == "Nahla3")
        {
            playerWithin = true;
            soundManager.PlayOneShot(nahlaTakeThree, 7.0f);
            Destroy(recorderNahla3);
            StartCoroutine(NahlaThree());
            nahlaThree = true;
            replayButtons[2].transform.GetChild(0).GetComponent<Text>().text = "Nahla Three";

        }
        if (other.tag == "DrClarke1")
        {
            playerWithin = true;
            soundManager.PlayOneShot(drClarkeTakeOne, 5.0f);
            Destroy(recorderClarke1);
            StartCoroutine(DrClarkeOne());
            drClarkeOne = true;
            replayButtons[3].transform.GetChild(0).GetComponent<Text>().text = "Dr.Clarke Room";
        }
        if (other.tag == "DrClarke2")
        {
            playerWithin = true;
            soundManager.PlayOneShot(drClarkeTakeTwo, 7.0f);
            Destroy(recorderClarke2);
            StartCoroutine(DrClarkeTwo());
            drClarkeTwo = true;
            replayButtons[4].transform.GetChild(0).GetComponent<Text>().text = "Dr.Clarke Engine";
        }
        if (other.tag == "DrClarke3")
        {
            playerWithin = true;
            soundManager.PlayOneShot(drClarkeTakeThree, 7.0f);
            Destroy(recorderClarke3);
            StartCoroutine(DrClarkeThree());
            drClarkeThree = true;
            replayButtons[5].transform.GetChild(0).GetComponent<Text>().text = "Dr.Clarke Top";
        }
        if (other.tag == "Juan1")
        {
            playerWithin = true;
            soundManager.PlayOneShot(juanLaugh, 5.0f);
            Destroy(recorderJuanLaugh);
            StartCoroutine(JuanOne());
            juanOne = true;
            replayButtons[6].transform.GetChild(0).GetComponent<Text>().text = "Juan Terminal";
        }
        if (other.tag == "Juan2")
        {
            playerWithin = true;
            soundManager.PlayOneShot(juanTakeTwo, 5.0f);
            Destroy(recorderJuan2);
            StartCoroutine(JuanTwo());
            juanTwo = true;
            replayButtons[7].transform.GetChild(0).GetComponent<Text>().text = "Juan Lower Term";
        }
        if (other.tag == "Veronica1")
        {
            playerWithin = true;
            soundManager.PlayOneShot(veronicaTakeOne, 2.0f);
            Destroy(recorderVeronica1);
            StartCoroutine(VeronicaOne());
            veronicaOne = true;
            replayButtons[8].transform.GetChild(0).GetComponent<Text>().text = "Veronica Room";
        }
        if (other.tag == "Veronica2")
        {
            playerWithin = true;
            soundManager.PlayOneShot(veronicaTakeTwo, 2.5f);
            Destroy(recorderVeroncia2);
            StartCoroutine(VeronicaTwo());
            veronicaTwo = true;
            replayButtons[9].transform.GetChild(0).GetComponent<Text>().text = "Veronica Dead";
        }
        if (other.tag == "Randal1")
        {
            playerWithin = true;
            soundManager.PlayOneShot(randalTakeOne, 2.5f);
            Destroy(recorderRandalOne);
            StartCoroutine(RandalOne());
            replayButtons[10].transform.GetChild(0).GetComponent<Text>().text = "Randal Room";
        }

        if (other.tag == "Randal2")
        {
            playerWithin = true;
            soundManager.PlayOneShot(randalTakeTwo, 2.5f);
            Destroy(recorderRandalTwo);
            StartCoroutine(RandalTwo());
            replayButtons[11].transform.GetChild(0).GetComponent<Text>().text = "Randal Room 2";
        }

        if (other.tag == "Randal3")
        {
            playerWithin = true;
            soundManager.PlayOneShot(randalTakeThree, 2.5f);
            Destroy(recorderRandalThree);
            StartCoroutine(RandalThree());
            replayButtons[12].transform.GetChild(0).GetComponent<Text>().text = "Randal Upper";
        }

        if (other.tag == "Mason1")
        {
            playerWithin = true;
            soundManager.PlayOneShot(masonTakeOnly, 2.5f);
            Destroy(recorderMason);
            StartCoroutine(MasonOne());
            replayButtons[13].transform.GetChild(0).GetComponent<Text>().text = "Mason";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerWithin = false;
        }
    }

    //adding subtitles to all of the recordings is below based on the length of the clip. 
    private IEnumerator NahlaOne()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(2);
        nahla1Words.SetActive(true);
        yield return new WaitForSeconds(27);
        nahla1Words.SetActive(false);
    }

    private IEnumerator NahlaTwo()
    {
        nahla1Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(1);
        nahla2Words.SetActive(true);
        yield return new WaitForSeconds(27);
        nahla2Words.SetActive(false);
    }

    private IEnumerator NahlaThree()
    {
        nahla2Words.SetActive(false);
        nahla1Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        nahla3Words.SetActive(true);
        yield return new WaitForSeconds(20);
        nahla3Words.SetActive(false);
    }

    private IEnumerator DrClarkeOne()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        nahla1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        clarke1Words.SetActive(true);
        yield return new WaitForSeconds(29);
        clarke1Words.SetActive(false);
    }

    private IEnumerator DrClarkeTwo()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        nahla1Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        clarke2Words.SetActive(true);
        yield return new WaitForSeconds(16);
        clarke2Words.SetActive(false);
    }

    private IEnumerator DrClarkeThree()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        nahla1Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        clarke3Words.SetActive(true);
        yield return new WaitForSeconds(17);
        clarke3Words.SetActive(false);
    }

    private IEnumerator JuanOne()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        nahla1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        juan1Words.SetActive(true);
        yield return new WaitForSeconds(31);
        juan1Words.SetActive(false);
    }

    private IEnumerator JuanTwo()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        nahla1Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        juan2Words.SetActive(true);
        yield return new WaitForSeconds(26);
        juan2Words.SetActive(false);
    }
    private IEnumerator VeronicaOne()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        nahla1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        veronica1Words.SetActive(true);
        yield return new WaitForSeconds(31);
        veronica1Words.SetActive(false);
    }

    private IEnumerator VeronicaTwo()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        nahla1Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        veronica2Words.SetActive(true);
        yield return new WaitForSeconds(20);
        veronica2Words.SetActive(false);
    }

    private IEnumerator RandalOne()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        nahla1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        randal1Words.SetActive(true);
        yield return new WaitForSeconds(13);
        randal1Words.SetActive(false);
    }

    private IEnumerator RandalTwo()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        nahla1Words.SetActive(false);
        randal1Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        randal2Words.SetActive(true);
        yield return new WaitForSeconds(14);
        randal2Words.SetActive(false);
    }

    private IEnumerator RandalThree()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        nahla1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal1Words.SetActive(false);
        masonWords.SetActive(false);
        yield return new WaitForSeconds(0);
        randal3Words.SetActive(true);
        yield return new WaitForSeconds(12);
        randal3Words.SetActive(false);
    }

    private IEnumerator MasonOne()
    {
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        nahla1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        yield return new WaitForSeconds(0);
        masonWords.SetActive(true);
        yield return new WaitForSeconds(28);
        masonWords.SetActive(false);
    }

    public void StopPlaying()
    {
        soundManager.Stop();
        nahla1Words.SetActive(false);
        nahla2Words.SetActive(false);
        nahla3Words.SetActive(false);
        clarke1Words.SetActive(false);
        clarke2Words.SetActive(false);
        clarke3Words.SetActive(false);
        juan1Words.SetActive(false);
        juan2Words.SetActive(false);
        veronica1Words.SetActive(false);
        veronica2Words.SetActive(false);
        randal1Words.SetActive(false);
        randal2Words.SetActive(false);
        randal3Words.SetActive(false);
        masonWords.SetActive(false);
    }
}
