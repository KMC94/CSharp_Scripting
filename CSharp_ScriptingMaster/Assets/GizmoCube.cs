using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoCube : MonoBehaviour
{
    //디버깅 정보 표출 여부
    public bool DrawGizmos = true;

    public float length = 1;

    private void OnDrawGizmos()
    {

        if (!DrawGizmos)
            return;

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward.normalized * length);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 4.0f);

        Gizmos.color = Color.white;
    }
}
