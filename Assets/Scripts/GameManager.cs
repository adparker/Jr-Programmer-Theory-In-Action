using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private MyShape[] _gameObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameObjects = GameObject.FindObjectsOfType<MyShape>();
        foreach (MyShape shape in _gameObjects)
        {
            shape.LogMsg();
        }
    }

    public void LogMsg(MySphere shape) // Polymorphism and Abstraction
    {
        Debug.Log($"This should be a sphere: {shape.msg}");
    }

    public  void LogMsg(MyCube shape) // Polymorphism and Abstraction
    {
        Debug.Log($"This should be a cube: {shape.msg}");
    }

    public void LogMsg(MyShape shape) // Polymorphism and Abstraction
    {
        Debug.Log($"Unexpected! {shape.msg}");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
