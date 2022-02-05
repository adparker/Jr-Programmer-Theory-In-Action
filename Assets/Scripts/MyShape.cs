using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShape : MonoBehaviour
{
    protected GameManager _gameManager;
    private string _msg;
    public string msg { get; protected set; } // Encapsulation

    void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    public virtual void LogMsg() // Polymorphism and Abstraction
    {
        _gameManager.LogMsg(this);
    }
}
