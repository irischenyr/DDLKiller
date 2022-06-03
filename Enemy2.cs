using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy2 : MonoBehaviour
{
    Transform m_transform;
    Player m_player;
    public static bool isMove = true;   //静态变量，可以实现不同的脚本之间传递
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
        {
            //病毒朝着玩家（相机）移动
            this.transform.position = Vector3.MoveTowards(this.transform.position,Camera.main.transform.position, 0.1f);
        }
    }
    public void OnDeath()
    {
        //销毁
        Destroy(this.gameObject);
        PlayerPrefs.SetInt("YourScore", PlayerPrefs.GetInt("YourScore")+5);
        //战绩的累加
        PlayerPrefs.SetInt("ScoreText2", PlayerPrefs.GetInt("ScoreText2")+1);
    }
}
