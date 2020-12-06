using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private GameObject[] Screens;
    [SerializeField]
    private GameObject winText;
    // [SerializeField]
    //  private GameObject tryAgainText;
    [SerializeField]
    private GameObject Next;

    // [SerializeField]
    // private GameObject Done;



    private bool winTextActiveState;
    public static bool lastScreen;
 //   private bool remaining = false;
    //  [SerializeField]
    //  private GameObject Quit;


    GameObject activeScreen;
    //  [SerializeField]
    //  private AudioSource WellDone;
    //  [SerializeField]
    //  private GameObject LevelEndPanel;

    private bool soundBool;
    public static bool soundEnabled = true;
    private GameObject[] temp;
    private AudioSource[] audiosource;

    void Awake()
    {
      //  Debug.Log("Within GameControl Awake Method");
        soundBool = SoundControl.soundOn;
        temp = GameObject.FindGameObjectsWithTag("Audio");
        audiosource = new AudioSource[temp.Length];
        for (int i = 0; i < audiosource.Length; i++)
        {
            audiosource[i] = temp[i].GetComponent<AudioSource>();
            
        }


        if (soundBool == true)
         
        {
           // tempBool = soundBool;
       //     Debug.Log("soundBool is True");
            foreach (AudioSource audio in audiosource)
            {
                audio.enabled = true;
                soundEnabled = true;
            }
        }
        else if(soundBool == false)
        {
         //   tempBool = soundBool;
        //   Debug.Log("soundBool is false");
            foreach (AudioSource audio in audiosource)
            {
                audio.enabled = false;
                soundEnabled = false;

            }
        }
    }

    // Use this for initialization
    void Start()
    {
        /*  var index = transform.name;
          Debug.Log("Sibling name: " + index);*/
    }

    // Update is called once per frame
    void Update()
    {

        /* for (var i = 0; i < Screens.Length; i++)
         {
             var activeState = Screens[i].activeInHierarchy;

             if (activeState == true)
             {
                 Transform[] allChildren = Screens[i].GetComponentsInChildren<Transform>();
                 foreach (Transform child in allChildren)
                 {
                     if (transform.tag != "fixed")
                     {
                         remaining = true;
                     }
                 }
             }
         }*/
        //  Debug.Log(Puzzle.count);

        /*if (Puzzle.count == 0)
        {

            winText.SetActive(true);
            Next.SetActive(true);
            Puzzle.count = 12;



        }*/
        /*
                    if (remaining == false)
                    {
                        winText.SetActive(true);
                        Next.SetActive(true);
                    }

            }*/
    }

    public void OnNext()
    {
        for (var i = 0; i < Screens.Length; i++)
        {
            var activeState = Screens[i].activeInHierarchy;
         //   Debug.Log("Screen: " + Screens[i].name + " " + activeState);
            // Debug.Log("Next Screen to set active: " + Screens[i + 1].name);
        //    Debug.Log("i: " + i);

            if (activeState == true)
            {

                Screens[i].SetActive(false);
                var j = i + 1;
             //   Debug.Log("Value of J:" + j);


                if (j < Screens.Length)
                {
                    if (j == Screens.Length - 1)
                    {
                        lastScreen = true;
                    }

                    Screens[j].SetActive(true);
                    activeState = Screens[j].activeInHierarchy;
                    winText.SetActive(false);
                    Next.SetActive(false);
                    //  Done.SetActive(true);
                    //   Debug.Log("Screen: " + Screens[j].name + " " + activeState);
                    break;
                }



            }
        }
    }

    



    /*


    public void OnDone()
    {
       for (var i = 0; i < Screens.Length; i++)
         {
            
             var activeState = Screens[i].activeInHierarchy;

            
         //   Debug.Log("Screen: " + Screens[i].name + " " + activeState);
         //   Debug.Log("Next Screen to set active: " + Screens[i + 1].name);

            if (activeState == true)
             {
                Debug.Log("Active screen: " + Screens[i].name);
                activeScreen = Screens[i];
                Debug.Log("i: " + i);
              
                //GameObject pieces = GameObject.FindWithTag("Pieces");
                GameObject pieces = GameObject.Find("Pieces");
                    
                    
                Debug.Log("Parent: " + pieces.transform.parent.name);
                Debug.Log("Pieces tag: " + pieces.name);

                Transform[] allChildren = pieces.GetComponentsInChildren<Transform>();
                foreach(Transform child in allChildren)
                {
                    Debug.Log("child tag: " + child.tag);
                    if (child.tag != "Fixed" && child.name !="Pieces")
                    {
                      //  Debug.Log("Not Fixed child name: " + child.name);
                     //   Debug.Log("Not Fixed child tag: " + child.tag);
                        remaining = true;
                    }
                }


                
             }
            
        }


       if(remaining == true) 
        {
            tryAgainText.SetActive(true);
            remaining = false;
            Debug.Log("try again");

        }
        else {
            
            winText.SetActive(true);
            Next.SetActive(true);
            Done.SetActive(false);
            Debug.Log("Well Done");
            WellDone.Play();
         //   activeScreen.SetActive(false);
            
          /*  if(lastScreen == true)
            {
               // Next.SetActive(false);
                Debug.Log("Restart");
                SceneManager.LoadScene("Restart", LoadSceneMode.Single);

            }
            //remaining = true;
        }
    
    }*/





}
