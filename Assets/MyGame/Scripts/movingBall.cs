using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingBall : MonoBehaviour
{
	public GameObject ball;
    [SerializeField] private GameObject[] ballPositions;

 
   private int RandomNumber(){
       return Random.Range(0,4);
   }

    public void secondNumber(){
    ball.transform.position = ballPositions[RandomNumber()].transform.position;

}
}

