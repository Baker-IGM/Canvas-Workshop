using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHealth(float value)
    {
        healthSlider.value -= value;
    }
}
