using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAnimations : MonoBehaviour {

    /// Static instance of this class
    /// </summary>
    public static GameAnimations Instance;

    internal Animator wordAnimation;

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
        wordAnimation = GetComponent<Animator>();
    }

    public void PlayAnimation(string text)
    {
        string[] words = text.Split(' ');
        var wordToAnimMap = new Dictionary<string, string>(StringComparer.CurrentCultureIgnoreCase)
        {
            { "hello", "AlpF"},
            { "hi", "AlpL" }
        };
        foreach (string word in words)
        {
            if (wordToAnimMap.ContainsKey(word))
            {
                string animName = wordToAnimMap[word];
                wordAnimation.Play(animName);
            }
        }
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
