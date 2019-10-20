using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #if SHOW_DEBUG_MESSAGES
                Debug.Log("TEST DEBUG MESSAGES");
        #endif

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MyFunc()
    {
        print("Hello");
    }

    public void OnSave()
    {
        print("저장되었읍니다.");
    }
}
