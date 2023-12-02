using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f; //１秒ごとに処理を進める感覚の設定
    float delta = 0; //速度の初期値
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; //1秒以上矢が出たのを確認して矢をまた出す処理
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6,7);  // ランダムで値を決めてくれる
            go.transform.position = new Vector3(px,7,0); //直接座標を指定して移動させている
        }
    }
}
