using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    Transform m_transform;
    Player m_player;
    public static bool isMove = true;   //静态变量，可以实现不同的脚本之间传递

    void Start()
    {
        //获取组件
        //m_transform = this.transform;
        //获取主角类实例
        //m_player = GameObject.FindGameObjectWithTag("player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
        {
            //病毒朝着玩家（相机）移动
            this.transform.position = Vector3.MoveTowards(this.transform.position,Camera.main.transform.position, 0.05f);
        }
    }

    //当被销毁时
    public void OnDeath()
    {
        //销毁
        Destroy(this.gameObject);
        //记录消灭病毒的数量，实现Score累加 
        PlayerPrefs.SetInt("YourScore", PlayerPrefs.GetInt("YourScore")+1);
        //战绩的累加
        PlayerPrefs.SetInt("ScoreText1", PlayerPrefs.GetInt("ScoreText1")+1);
    }
}
