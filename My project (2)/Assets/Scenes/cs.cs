using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs : MonoBehaviour
{


    string heroName = "spiderman ";
    int heroPower = 10;


    string villainName = "venom ";
    int villainPower = 20;
    float playerSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed(2.5f);
        print(" the hero name is " + heroName + " and the villain name is " + villainName);
        if (heroPower > villainPower)
        {
            print(" and the hero is stronger ");
        }
        else
        {
            print(" and the villain is stronger ");
        }
        
    }


    // Update is called once per frame
    void Update()
    {

    }
    void SetSpeed(float newSpeed)
    {
        print("old player speed is " + playerSpeed);
        playerSpeed = newSpeed;
        print("new player speed is " + playerSpeed);
    }
}