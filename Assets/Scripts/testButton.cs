using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SayHi()
    {
        Debug.Log("Hi!");
    }

    public void SaySomething(string phrase)
    {
        Debug.Log(phrase);
    }

    public void Repeat(int num)
    {
        for(int i = 0; i < num; ++i)
        {
            Debug.Log("Hey! Listen!");
        }
    }
}
