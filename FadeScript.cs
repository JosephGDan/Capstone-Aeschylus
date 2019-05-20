using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FadeScript : MonoBehaviour {

    public Animator animator;

    private int levelToLoad;

    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
       
    }


    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
