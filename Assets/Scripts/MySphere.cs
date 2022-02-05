using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySphere : MyShape // Inheritance.
{
    void Awake()
    {
        msg = "I am a Sphere.";
        _gameManager = FindObjectOfType<GameManager>();
    }
    
    public override void LogMsg() // Polymorphism and Abstraction
    {
        _gameManager.LogMsg(this);
    }

}
