using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ShowingU;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform m_fx;//射中目标后的粒子效果
    public AudioClip shootClip;
    private AudioSource shootAudio; //开枪音效
    public static int m_life = 10;//生命值
    float timer;//射击间隔时间
    
    void Start()
    {
        shootAudio = this.transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //如果生命值为0，什么也不做
        if (ShowUI.finalm_life <= 0) return;

        //鼠标左键射击音效
        if(Input.GetMouseButtonDown(0))
        {
            if (Time.time - timer > 0.1)
            {
                timer = Time.time;
                shootAudio.PlayOneShot(shootClip);
            }
        }
        else return;
    
    }
    private void OnTriggerEnter(Collider other) 
    {
        //m_life--;
        //m_lifeText.text = m_life + "";
        PlayerPrefs.SetInt("YourLife", PlayerPrefs.GetInt("YourLife") - 1);

        if (m_life <= 0)
        {
            Enemy.isMove = false;
            Enemy2.isMove = false;
            Enemy3.isMove = false;
            print("游戏结束！");
        }
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject); //病毒接触玩家之后 ，病毒就消失
        }
    }
}


