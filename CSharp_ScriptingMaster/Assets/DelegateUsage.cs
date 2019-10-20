using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateUsage : MonoBehaviour
{

    //델리게이트의 형식을 선언한다 - 파라미터, 반환 형식
    public delegate void EventHandler(int param1, int param2);

    //해당 델리게이트 형식의 함수 참조를 담는 배열을 선언한다 - 최대 이벤트 10개
    public EventHandler[] EH = new EventHandler[10];

    private void Awake()
    {
        EH[0] = HandleMyEvent;
        EH[1] = TestEvent;
    }

    void Start()
    {
        foreach(EventHandler e in EH)
        {
            if(e!=null)
            {
                e(0, 0);
            }
        }
    }

    void HandleMyEvent(int param1, int param2)
    {
        Debug.Log("Event Called");
    }

    void TestEvent(int param1, int param2)
    {
        Debug.Log("TestEvent()");
    }
}
