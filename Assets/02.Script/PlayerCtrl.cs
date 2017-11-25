using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {
    private float h = 0.0f;
    private float v = 0.0f;

    public Transform tr;
    public float moveSpeed = 10.0f; //유니티화면에서 변수변경 가능
    //마우스 카메라 회전 속도 
    public float rotSpeed = 1000.0f;

    // Use this for initialization
    void Start () {
        tr = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Debug.Log("H = " + h.ToString());
        Debug.Log("V = " + v.ToString());
        //전후좌우 이동 방향 벡터계산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        //Translate(이동방향 * 델타타임*변위값*속도,기준좌표)
        tr.Translate(moveDir * Time.deltaTime * moveSpeed, Space.Self); //셀프는 동서남북 신경안쓰고 움직임

        //마우스 화면 회전
        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
    }
}
