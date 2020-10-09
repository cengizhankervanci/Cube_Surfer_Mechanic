using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            collision.gameObject.GetComponent<Move>().enabled = false;
        }

        if (collision.gameObject.tag == "firstobj")
        {
            collision.gameObject.GetComponent<Move>().enabled = false;
        }
    }
}

