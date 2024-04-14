using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {
        // 속력 바꾸기
        // rigid.velocity = Vector3.forward;


        // 힘 가하기 
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw(
            "Horizontal"),
            0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        // 회전력
        //rigid.AddTorque(Vector3.back);
    }

    // 콜라이더 충돌로 발생하는 이벤트
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
