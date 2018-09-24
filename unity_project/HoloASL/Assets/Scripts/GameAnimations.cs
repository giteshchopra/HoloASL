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

    public void PlayAnimation()
    {
        // wordAnimation["AlpF"].wrapMode = WrapMode.Once;
        wordAnimation.Play("AlpF");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
