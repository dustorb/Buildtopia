using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPlayNumbers : MonoBehaviour
{
    [Header("NumberColliders")]
    public GameObject number1Collider;
    public GameObject number2Collider;
    public GameObject number3Collider;
    public GameObject number4Collider;
    public GameObject number5Collider;
    public GameObject number6Collider;
    public GameObject number7Collider;
    public GameObject number8Collider;
    public GameObject number9Collider;
    public GameObject number0Collider;

    //1
    public void Num1CantPlay()
    {
        number1Collider.SetActive(false);
    }

    public void Num1CanPlay()
    {
        number1Collider.SetActive(true);
    }
    //2
    public void Num2CantPlay()
    {
        number2Collider.SetActive(false);
    }

    public void Num2CanPlay()
    {
        number2Collider.SetActive(true);
    }

    //3
    public void Num3CantPlay()
    {
        number3Collider.SetActive(false);
    }

    public void Num3CanPlay()
    {
        number3Collider.SetActive(true);
    }

    //4
    public void Num4CantPlay()
    {
        number4Collider.SetActive(false);
    }

    public void Num4CanPlay()
    {
        number4Collider.SetActive(true);
    }

    //5
    public void Num5CantPlay()
    {
        number5Collider.SetActive(false);
    }

    public void Num5CanPlay()
    {
        number5Collider.SetActive(true);
    }

    //6
    public void Num6CantPlay()
    {
        number6Collider.SetActive(false);
    }

    public void Num6CanPlay()
    {
        number6Collider.SetActive(true);
    }

    //7
    public void Num7CantPlay()
    {
        number7Collider.SetActive(false);
    }

    public void Num7CanPlay()
    {
        number7Collider.SetActive(true);
    }

    //8
    public void Num8CantPlay()
    {
        number8Collider.SetActive(false);
    }

    public void Num8CanPlay()
    {
        number8Collider.SetActive(true);
    }

    //9
    public void Num9CantPlay()
    {
        number9Collider.SetActive(false);
    }

    public void Num9CanPlay()
    {
        number9Collider.SetActive(true);
    }

    //0
    public void Num0CantPlay()
    {
        number0Collider.SetActive(false);
    }

    public void Num0CanPlay()
    {
        number0Collider.SetActive(true);
    }
}
