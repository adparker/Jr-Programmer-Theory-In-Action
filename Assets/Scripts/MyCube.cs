using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCube : MyShape // Inheritance. 
{
    void Awake()
    {
        msg = "I am a Cube.";
        _gameManager = FindObjectOfType<GameManager>();
    }
    public override void LogMsg() // Polymorphism and Abstraction
    {
        _gameManager.LogMsg(this);
    }

 }
