using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Start()
    {
        //Vector3 vec = new Vector3(0, 0, 0);

        //transform.Translate(vec);

    }

    void Update()
    {
        // w,a,s,d 나 방향키로 오브젝트 이동하기
        // deltaTim을 곱하면 프레임이 크든 작든 동일한 프레임으로 나간다.
        //Vector3 vec = new Vector3(
        //    Input.GetAxisRaw("Horizontal") * Time.deltaTime,
        //    Input.GetAxisRaw("Vertical")* Time.deltaTime, 
        //    0);

        //transform.Translate(vec);

        // 1. MoveTowards 문법 (현재위치, 이동위치, 속도) 단순 등속 이동
        //transform.position =
        //    Vector3.MoveTowards(transform.position, target, 2f);


        // 2. SmoothDamp 문법 (현재위치, 이동위치, 참조 속도,속도) 미끄러지듯 감속
        //Vector3 velo = Vector3.zero;

        //transform.position =
        //    Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);


        // 3. Lerp (선형 보간 이동) 
        //transform.position =
        //    Vector3.Lerp(transform.position, target, 0.05f);

        // 4. SLerp (구면 선형 보간) 호를 그리며 이동
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }

    //void Awake()
    //{
    //    Debug.Log("플레이어 데이터가 준비되었습니다.");
    //}

    //void OnEnable()
    //{
    //    Debug.Log("플레이어가 로그인했습니다.");
    //}

    //void Start()
    //{
    //    Debug.Log("플레이어 데이터를 불러옵니다.");
    //}

    //void FixedUpdate()
    //{
    //    Debug.Log("이동~");
    //}

    //void Update()
    //{
    //if (Input.anyKeyDown)
    //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");

    //if (Input.GetKeyDown(KeyCode.Return))
    //    Debug.Log("아이템을 구입하였습니다.");

    //if (Input.GetKey(KeyCode.LeftArrow))
    //    Debug.Log("왼쪽으로 이동중.");

    //if (Input.GetKeyUp(KeyCode.RightArrow))
    //    Debug.Log("오른쪽 이동을 멈추었습니다.");

    //if (Input.GetMouseButtonDown(0))
    //    Debug.Log("미사일 발사!");

    //if (Input.GetMouseButton(1))
    //    Debug.Log("차징중..");

    //if (Input.GetMouseButtonUp(1))
    //    Debug.Log("차징 미사일 발사!");

    //if (Input.GetButton("Horizontal"))
    //{
    //    Debug.Log("횡 이동 중..." 
    //        + Input.GetAxisRaw("Horizontal"));
    //}

    //if (Input.GetButton("Vertical"))
    //{
    //    Debug.Log("종 이동 중..."
    //        + Input.GetAxisRaw("Vertical"));
    //}
    //}

    //void LateUpdate()
    //{
    //    Debug.Log("경험치 획득.");
    //}

    //void OnDisable()
    //{
    //    Debug.Log("플레이어가 로그아웃 하였습니다.");
    //}

    //void OnDestroy()
    //{
    //    Debug.Log("플레이어 데이터를 해제하였습니다.");
    //}
}
