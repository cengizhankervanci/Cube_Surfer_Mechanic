using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject MainObj;
    public  GameObject[] ColletCubes;
    GameStatus gameStatus = GameStatus.initilaze;
    public int count;
    public int change=0;
    GameObject cubes;

    public bool deneme { set; get; } = false;

    public Vector3 newpos { set; get; }
    void Start()
    {
        cubes = GameObject.Find("Cubes");
        ColletCubes = new GameObject[cubes.transform.childCount];
    }

    void Update()
    { 
        switch (gameStatus)
        {
            case GameStatus.initilaze:
                Player1.transform.position += Vector3.forward * 7 * Time.deltaTime;
                MainObj.transform.position += Vector3.forward * 7 * Time.deltaTime;
                break;
            case GameStatus.start:      
                break;
            case GameStatus.stay:
                break;
            case GameStatus.finish:
                break;
            case GameStatus.next:
                break;
            default:
                break;
        }
    }
}
