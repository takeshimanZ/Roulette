using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 回転速度
    [SerializeField] float addRotSpeed;

    void Start()
    {
        // フレームレートを60に固定する
        Application.targetFrameRate = 60;
    }

    void Update()
    {


        // ルーレットを回転させる
        transform.Rotate(0, 0, -this.rotSpeed);

        // ルーレットを減速させる
        this.rotSpeed *= 0.96f;
    }

    // ボタンがクリックされたときに呼ばれるメソッド
    public void ClickButton()
    {
        this.rotSpeed = addRotSpeed;
    }
}
