using UnityEngine;
using UnityEngine.UI;

public class GameDirectorCat : MonoBehaviour
{
    GameObject hpGauge;
    Image hpimage;
    float time;
    public Text timeText;
    public GameObject gameOverText;
    
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        //Gameoverテキストを非表示
        gameOverText.SetActive(false);

    }

    void Update()
    {
        //タイマーの設定
        time += Time.deltaTime;
        timeText.text = $"Time:{time:F2}秒";
    }
    public void  DecreaseHp()
    {
        // HPゲージを減らして、HPが0以下になったらGameOverテキストを表示
        Image hpImage = this.hpGauge.GetComponent<Image>();
        hpImage.fillAmount -= 0.1f;
        if(hpImage.fillAmount <= 0.0f){
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
