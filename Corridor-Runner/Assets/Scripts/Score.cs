using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
   
//    public Transform Player;
//    public Text scoreText;

   public float x = -9.940001f;


//     // Update is called once per frame
//     void Update()
//     {
//       //  Debug.Log(Player.position.z);
//       scoreText.text = (Player.position.z+x).ToString("0");

//     }

public GameObject startPos;
public Text scoreText;
public GameObject scoreTextObj;

private float distance;

void Start()
{
    scoreText = scoreTextObj.GetComponent<Text>();
}

void Update()
{
    distance = (startPos.transform.position.z+x + this.transform.position.z+ x);
    scoreText.text = distance.ToString("0") + "M";
}

}
