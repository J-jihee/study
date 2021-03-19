using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 순서대로 x,y,z값으로 각 값에 해당하는 만큼 이동
        // transform.Translate(5,0,0);
        // 로그
        // Debug.Log("start");
        //mX = -111;
        mX = -22.24f;
        mY = 1.15f;
        mZ = 9.64f;
    }
    // 변수할당
    public float mX = 0;
    public float mY = 0;
    public float mZ = 0;
    // Update is called once per frame
    void Update()
    {   
        // 유니티에 내장되있는 함수
        Debug.Log("update : "+ mX);
        //mX = 1;
        // transform.Translate(Time.deltaTime * 0.001f,0,0);
        if (mX < -17.996f){
            mX += Time.deltaTime * 0.5f;
            transform.position = new Vector3(mX,mY,mZ);
        }
        else if (mZ < 15){
            mZ += Time.deltaTime * 0.5f;
            transform.position = new Vector3(mX,mY,mZ);
        }
        else if (mX < -10){
            mX += Time.deltaTime * 0.5f;
            transform.position = new Vector3(mX,mY,mZ);
        }
        
        
    }
}
