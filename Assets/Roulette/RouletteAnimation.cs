using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RouletteAnimation : MonoBehaviour
{
    // Start is called before the first frame update
     float rotSpeed = 0; //回転速度
    [SerializeField] float addRotSpeed;
    void Start()
    {
             //フレームレートを60に固定する
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
          //マウスが押されたら回転速度を設定する
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 20 ;

        }
        //回転速度分、ルーレットを回転させる
        transform.Rotate(0,0,-this.rotSpeed);

        
    }
    public void ClickButton(){
            this.rotSpeed = addRotSpeed;
        }
}
