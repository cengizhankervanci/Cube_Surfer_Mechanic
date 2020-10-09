using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void LateUpdate()
    {
        transform.position += Vector3.forward * 7 * Time.deltaTime;
    }
}
