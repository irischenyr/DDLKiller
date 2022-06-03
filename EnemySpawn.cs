using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject m_enemy1; //放入敌人预设
    public GameObject m_enemy2; //放入敌人预设
    public GameObject m_enemy3; //放入敌人预设
    void Start()
    {
        //m_transform = this.transform;
        InvokeRepeating("Create",2,2);
        InvokeRepeating("Create2",5,2);
        InvokeRepeating("Create3",7,2);
    }

    // Update is called once per frame
    void Update()
    {

    }
 
    public void Create()
    {
        Vector3 virusPosition = new Vector3(Random.Range(-61f, 0f),-1f, Random.Range(-10f, 1f));
        GameObject.Instantiate(m_enemy1, virusPosition, Quaternion.identity);
    }

    public void Create2()
    {
        Vector3 virusPosition = new Vector3(Random.Range(-61f, 0f),-1f, Random.Range(-10f, 1f));
        GameObject.Instantiate(m_enemy2, virusPosition, Quaternion.identity);
    }

    public void Create3()
    {
        Vector3 virusPosition = new Vector3(Random.Range(-61f, 0f),-1f, Random.Range(-10f, 1f));
        GameObject.Instantiate(m_enemy3, virusPosition, Quaternion.identity);
    }
}
