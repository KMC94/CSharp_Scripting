using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPath : MonoBehaviour
{

    public GameObject enemy = null;

    public LayerMask lm;


    void Start()
    {
        
    }

    void Update()
    {
        if(Physics.Linecast(transform.position, enemy.transform.position, lm))
        {
            Debug.Log("Path clear");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, enemy.transform.position);
    }
}
