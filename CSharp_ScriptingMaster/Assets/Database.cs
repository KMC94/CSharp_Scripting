using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyNumber = 11;

        MyNumber = 7;

        MyNumber = 3;

        SendMessage("MyFunc", SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int iMyNumber = 0;
    
    [SerializeField]
    public int MyNumber
    {
        get
        {
            return iMyNumber;
        }
        set
        {
            if(value >= 1 && value <= 10)
            {
                iMyNumber = value;

                NumberChanged(); 
            }
        }
    }

    private void NumberChanged()
    {
        print("Changed to : " + iMyNumber.ToString());
    }
}
