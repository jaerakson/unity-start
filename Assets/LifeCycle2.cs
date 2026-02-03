using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
// 초기화 게임오브텍트 생성할때 , 최초 실행행
    void Awake()  
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

// 활성하는 초기화  물리영역 사이이 존재한다
    void OnEnable()
    {
        Debug.Log("플레이어 로그인했습니다.");
    }

    //물리 연산 하기전에 실행 되는 함수 업데이트 고정된 실행 주기로 cpu 부하가 많다
    void FixedUpdate()  
    {
        Debug.Log("이동~");
    }
// 게임로직 컴퓨터 환경에 따라 실행주기가 떨어질수있음 
    void Update()
    {
        Debug.Log("몬스터 사냥!");
    }

    // 모든  끝난 후 마지막 업데이트 케릭터를 따라가는 카메라를 따라 가든가 아니면 로직의 후처리
    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }

    // 비할성화 영역 
    void OnDisable()
    {
        Debug.Log("플레이어 로그아웃 되었습니다.");
    }
 

    //해체 영역 게임 오브젝트가 삭제 될때 오브잭트가 삭제 되기전에 뭔가 남기고 삭제 된다는 그런 의미
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터가 해체되었습니다.");
    }

    

}
