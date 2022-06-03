using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ShowingU;

public class ShowTime : MonoBehaviour
{
// Start is called before the first frame update
    public int TotalTime = 20;//总时间
    public Text TimeText;//在UI里显示时间
    public Image winimage_juanwang;
    public Image winimage_timecontroller;
    public Image winimage_moyu;
    public Image winimage_tuoyan;
    public Image winimage_fanjuan;
    private int mumite;//分
    private int second;//秒
    private int finalscore2; //stringtoint
    private int finalm_life;


    void Start()
    {
        StartCoroutine(startTime());
    }

    public IEnumerator startTime()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (TotalTime >= 0)
        {
            yield return waitForSeconds;
            TotalTime--;
            TimeText.text = "Time:" + TotalTime;

            if (TotalTime <= 0)
            {                
                Debug.Log("游戏时间到！");
                Enemy.isMove = false;
                Enemy2.isMove = false;
                Enemy3.isMove = false;
                
                if (ShowUI.finalscore >= 30 || ShowUI.finalm_life == 8)
                {
                    winimage_juanwang.enabled = true;
                }

                if (ShowUI.finalscore >= 24 || (ShowUI.finalm_life >= 6 && ShowUI.finalm_life < 8))
                {
                    winimage_timecontroller.enabled = true;
                }

                if (ShowUI.finalscore >= 20 || (ShowUI.finalm_life >= 4 && ShowUI.finalm_life < 6))
                {
                    winimage_moyu.enabled = true;
                }

                if (ShowUI.finalscore >= 10 || (ShowUI.finalm_life >= 2 && ShowUI.finalm_life < 4))
                {
                    winimage_tuoyan.enabled = true;
                }

                if (ShowUI.finalscore <= 10 || ShowUI.finalm_life == 0)
                {
                    winimage_fanjuan.enabled = true;
                }
                
            }
            mumite = TotalTime / 60; //输出显示分
            second = TotalTime % 60; //输出显示秒
            string length = mumite.ToString();
            //如果秒大于10的时候，就输出格式为 00：00
            if (second >= 10)
            {
                TimeText.text = "0" + mumite + ":" + second;
            }
            //如果秒小于10的时候，就输出格式为 00：00
            else
                TimeText.text = "00:00";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

