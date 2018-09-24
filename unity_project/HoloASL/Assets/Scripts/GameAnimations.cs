using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAnimations : MonoBehaviour {

    /// Static instance of this class
    /// </summary>
    public static GameAnimations Instance;

    internal Animator WordAnimation;

    /// <summary>
    /// Called on Initialization
    /// </summary>
    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {

        //Fetch the Animator from GameObject
        WordAnimation = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        // wordAnimation["AlpF"].wrapMode = WrapMode.Once;
        WordAnimation.Play("AlpF");
        Wait(5);
        WordAnimation.Play("AlpL");
    }
    IEnumerator Wait(float duration)
    {
        //This is a coroutine
        Debug.Log("Start Wait() function. The time is: " + Time.time);
        Debug.Log("Float duration = " + duration);
        yield return new WaitForSecondsRealtime(duration);   //Wait
        Debug.Log("End Wait() function and the time is: " + Time.time);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
