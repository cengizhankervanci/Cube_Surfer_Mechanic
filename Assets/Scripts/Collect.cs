using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    GameManager gm;
    Enter enter;
    Vector3 newpos;
    bool test = true;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "firstobj")
        {
            enter = collision.gameObject.GetComponent<Enter>();
            if (enter.entered == false)
            {
                gm.ColletCubes[0] = collision.gameObject;
                gm.count++;
                collision.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                gm.Player1.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
                gm.ColletCubes[0].GetComponent<Move>().enabled = true;
                gm.ColletCubes[0].AddComponent<Swipe>();
                // collision.transform.parent = transform;
            }
            enter.entered = true;
        }

        if (collision.gameObject.tag == "Finish")
        {
            enter = collision.gameObject.GetComponent<Enter>();
            if (enter.entered == false)
            {
                gm.ColletCubes[gm.count] = collision.gameObject;
                newpos += gm.ColletCubes[gm.count].transform.position + Vector3.up;
                gm.ColletCubes[gm.count].AddComponent<Swipe>();
                //collision.transform.parent = transform;
                gm.Player1.transform.position = new Vector3(transform.position.x, newpos.y + 2, transform.position.z);
                gm.ColletCubes[gm.count].transform.position = new Vector3(gm.MainObj.transform.position.x, newpos.y + 1, gm.MainObj.transform.position.z);
                gm.ColletCubes[gm.count].GetComponent<Move>().enabled = true;
                gm.count++;
            }
            enter.entered = true;
        }

        if (collision.gameObject.tag == "wall")
        {
            gm.ColletCubes[gm.change].transform.position = new Vector3(gm.MainObj.transform.position.x, 0, gm.MainObj.transform.position.z);
            gm.MainObj.transform.position = new Vector3(gm.MainObj.transform.position.x, 1, gm.MainObj.transform.position.z);
            gm.ColletCubes[gm.change] = gm.MainObj;
            Invoke("wait", 2f);
            transform.gameObject.GetComponent<Collect>().enabled = false;
        }
    }

    void wait()
    {
        if (test)
        {
            gm.change++;
        }
        test = false;
    }
}
