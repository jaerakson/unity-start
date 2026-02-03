using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레어가 아무 키를 눌렸습니다.");
        //if (Input.anyKey)  Down , stay , up
        //    Debug.Log("플레어가 아무 키를 누르고 있습니다다.");

        // 키보드버튼 입력 getkey   Down , stay , up
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");
    }
}
