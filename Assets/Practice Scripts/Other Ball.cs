using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // 충돌 시작
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }

    // 충돌 중
    //private void OnCollisionStay(Collision collision)
    //{

    //}

    // 충돌이 끝날때
    //private void OnCollisionExit(Collision collision)
    //{

    //}

}
