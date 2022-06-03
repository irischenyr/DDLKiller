using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ShowingU
{
    public class ShowUI : MonoBehaviour
    {
        public Text ScoreText;
        public Text m_lifeText;
        public Text scoreText1;  //战绩
        public Text scoreText2;  //战绩
        public Text scoreText3;  //战绩
        public static int finalscore;
        public static int finalm_life;
        // Start is called before the first frame update
        void Start()
        {
            PlayerPrefs.SetInt("YourLife", 10); 
            PlayerPrefs.SetInt("YourScore", 0); 
            PlayerPrefs.SetInt("ScoreText1", 0); 
            PlayerPrefs.SetInt("ScoreText2", 0); 
            PlayerPrefs.SetInt("ScoreText3", 0);     
        }

        // Update is called once per frame
        public void Update()
        {
            ScoreText.text =PlayerPrefs.GetInt("YourScore")+"";
            m_lifeText.text =PlayerPrefs.GetInt("YourLife")+"";
            scoreText1.text = PlayerPrefs.GetInt("ScoreText1")+"";
            scoreText2.text = PlayerPrefs.GetInt("ScoreText2")+"";
            scoreText3.text = PlayerPrefs.GetInt("ScoreText3")+"";
            finalscore = PlayerPrefs.GetInt("YourScore");
            finalm_life = PlayerPrefs.GetInt("YourLife");
        }
    }

}



