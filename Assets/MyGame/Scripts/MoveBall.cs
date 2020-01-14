using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    /*public GameObject ballPosTopLeft;
    public GameObject ballPosBottomLeft;
    public GameObject ballPosTopRight;
    public GameObject ballPosBottomRight;*/

    [SerializeField] private GameObject[] ballPositions;
    [SerializeField] private GameObject[] ball;

    public void MoveTheBall()
    {
        Debug.Log(Random.Range(0, 1));
    }


    //public GameObject[] ballPositions;


}

