using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject PlayerCat;
    // Start is called before the first frame update
    void Start()
    {
        this.PlayerCat = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.PlayerCat.transform.position;
        transform.position = new Vector3(
            transform.position.x,playerPos.y,transform.position.z
        );
    }
}
