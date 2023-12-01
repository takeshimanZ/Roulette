// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;
// using UnityEngine.UI; 
// public class GameDirector : MonoBehaviour
// {
//     [SerializeField] GameObject car;
//     public GameObject flag;
//     public GameObject distance;
//     // Start is called before the first frame update
//     void Start()
//     {
//         // this.car = GameObject.Find("car");
//         // this.flag = GameObject.Find("flag");
//         // this.distance = GameObject.Find("distance");
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float length = this.flag.transform.position.x -
//             this.car.transform.position.x;
//         if(length >= 0)
//         {
//             this.distance.GetComponent<Text>().text =
//                 $"Distance:{length:F2}m";
//         }
//         else
//         {
//             this.distance.GetComponent<Text>().text = "GameOver!";
//         }
//     }
// }
