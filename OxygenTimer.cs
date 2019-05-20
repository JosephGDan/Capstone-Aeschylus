using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OxygenTimer : MonoBehaviour
{

   
   
    public bool timerIsActive = true;
    public Slider OxygenBar;

    public float currentOxygen = 50;
    private float maxOxygen = 50;

    private float scrollBar = 8.0f;

    public int oxyFast = 2;

    private int levelToLoad;

    public Animator animator;

    

    private void Awake()
    {
        OxygenBar = GetComponent<Slider>();
        
    }

    void Start()
    {
        timerIsActive = false;
       
        

    }


    void Update()
    {
        

        if (timerIsActive == true)
        {

            currentOxygen -= (Time.deltaTime * oxyFast);
            OxygenBar.value = currentOxygen;
            
            print(currentOxygen);

            if (currentOxygen <= 0)
            {
                currentOxygen = 0;
                FadeToLevel(2);
                timerIsActive = false;
            }
        }

        if (timerIsActive == false)
        {
            if (currentOxygen < maxOxygen)
            {
                currentOxygen += Time.deltaTime * scrollBar;
                OxygenBar.value = currentOxygen;
                print(currentOxygen);
            }
            
        }
       
        
    }


    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
        SceneManager.LoadScene(levelIndex);
    }

}
