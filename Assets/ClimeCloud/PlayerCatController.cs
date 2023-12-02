using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadSceneを使うために必要
public class PlayerCatController : MonoBehaviour
{

    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ジャンプする
        if(Input.GetKeyDown(KeyCode.Space) &&
            this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //左右移動
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //プレイヤーの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        //スピード制限
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //動く方向に応じて反転
        if(key != 0)
        {
            transform.localScale = new Vector3(key,1,1);
        }

        //プレイヤーの速度に応じてアニメーション速度を変える
        this.animator.speed = speedx / 2.0f;
        }
        //ゴールに到達
        void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("ゴール");
            SceneManager.LoadScene("ClearScene");
        }
}
