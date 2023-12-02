using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに等速で落下させる
        transform.Translate(0,-0.1f,0);

        //画面外に出たらオブジェクトを破棄する
        if(transform.position.y < -9.5f){
            Destroy(gameObject);
        }

        // //当たり判定
        // Vector2 p1 = transform.position;
        // Vector2 p2 = this.player.transform.position;
        // Vector2 dir = p1 - p2;
        // float d = dir.magnitude;
        // float r1 = 0.5f; //矢の半径
        // float r2 = 1.0f; //プレイヤーの半径

        // if(d < r1 + r2)
        // {
        //     //監督スクリプトにプレイヤーと衝突したことを伝える
        //     GameObject director  = GameObject.Find("GameDirector");
        //     director.GetComponent<GameDirector>().DecreaseHp();
            
        //     //衝突した場合は矢を消す
        //     Destroy(gameObject);
        // }
    }
     // 他のオブジェクトのコライダーに当たった時実行
    void OnTriggerEnter2D(Collider2D other) {

    // 衝突したオブジェクトがプレイヤーであるかを確認
    if (other.gameObject.name == "player") {
        // 監督スクリプトにプレイヤーと衝突したことを伝える
        GameObject director = GameObject.Find("GameDirectorCat");
        director.GetComponent<GameDirectorCat>().DecreaseHp();

            // 衝突した場合は矢を消す
            Destroy(gameObject);
            }
    }
}
