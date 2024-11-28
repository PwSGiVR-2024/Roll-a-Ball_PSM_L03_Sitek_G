using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UIElements;
using UnityEngine.SocialPlatforms.Impl;

public class CollectScore : MonoBehaviour
{
    
    public TMP_Text scoreText;
    public TMP_Text LVL_Pass;
    public MovementController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (player?.score == 9)
        {
            LVL_Pass.text = "Przeszedles pierwszy poziom! Przytrzymaj spacje aby skoczyc.";
        }
    }
   
}
