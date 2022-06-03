using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cameraToLookAt;
    public SelectXYZ selectXYZ = SelectXYZ.None;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //若cameraToLookAt为空，则自动选择主摄像机
        if (cameraToLookAt == null)
            cameraToLookAt = Camera.main;
            
        Vector3 vector3 = cameraToLookAt.transform.position - transform.position;
        switch (selectXYZ)
        {
            case SelectXYZ.x:
                vector3.y = vector3.z = 0.0f;
                break;
            case SelectXYZ.y:
                vector3.x = vector3.z = 0.0f;
                break;
            case SelectXYZ.z:
                vector3.x = vector3.y = 0.0f;
                break;
            case SelectXYZ.None:
                vector3.x = vector3.y = vector3.z = 0.0f;
                break;
        }
        transform.LookAt(cameraToLookAt.transform.position - vector3);
    }
}

public enum SelectXYZ
{
    x,
    y,
    z,
    None
}
