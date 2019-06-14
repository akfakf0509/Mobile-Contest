using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour
{
    Animator animator;
    public GameObject Player;       // 플레이어.
    public Transform Stick;        // 조이스틱.
    public float speed = 5f;      // 플레이어 속도.

    private Vector2 StickFirstPos; // 조이스틱의 처음 위치.
    private Vector2 JoyVec;        // 조이스틱의 벡터 (방향)
    private Vector2 PlayerVec;     // 플레이어의 벡터 (방향)
    private float Radius;          // 조이스틱 배경의 반지름.
    private bool MoveFlag;         // 플레이어 움직임 스위치.

    void Awake()
    {
        animator = Player.GetComponent<Animator>();
    }

    void Start()
    {
        Radius = GetComponent<RectTransform>().sizeDelta.x * 0.5f;
        StickFirstPos = Stick.transform.position;

        // 캔버스 크기에 대한 반지름 조절.
        float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
        Radius *= Can;

        MoveFlag = false;
    }

    void Update()
    {
        Vector3 moveVelocity = new Vector3();
        if (MoveFlag && Time.timeScale == 1)
        {
            if (JoyVec.x < 0)
            {
                Player.transform.localScale = new Vector3(0.22f, 0.22f, 1);
                animator.SetBool("Move", true);
                moveVelocity = Vector3.left;
            }
            else
            {
                Player.transform.localScale = new Vector3(-0.22f, 0.22f, 1);
                animator.SetBool("Move", true);
                moveVelocity = Vector3.right;
            }
            //            PlayerVec = new Vector2(JoyVec.x, 0);
            //            Player.transform.Translate(PlayerVec * Time.deltaTime * speed);
            Player.transform.position += moveVelocity * speed * Time.deltaTime;
        }
        else
            animator.SetBool("Move", false);
    }

    public void Drag(BaseEventData _Data)
    {
        PointerEventData Data = _Data as PointerEventData;
        Vector2 Pos = Data.position;

        // 조이스틱을 이동시킬 방향을 구함.( 상하좌우 )
        JoyVec = (Pos - StickFirstPos).normalized;

        // 조이스틱의 처음 위치와 현재 내가 터치하고 있는 위치의 거리를 구한다.
        float Dis = Vector2.Distance(Pos, StickFirstPos);

        Vector2 StickPos = Stick.position;

        //거리가 반지름보다 작으면 조이스틱을 현재 터치하고 있는 곳으로 이동.
        if (Dis < Radius)
            StickPos = StickFirstPos + JoyVec * Dis;
        // 거리가 반지름보다 커지면 조이스틱을 반지름의 크기만큼만 이동.
        else
            StickPos = StickFirstPos + JoyVec * Radius;

        if (Time.timeScale == 1)
        {
            Stick.position = new Vector2(StickPos.x, StickFirstPos.y);
        }
        
        MoveFlag = true;
    }

    public void DragEnd()
    {
        Stick.position = StickFirstPos; // 스틱을 원래의 위치로.
        JoyVec = Vector3.zero;          // 방향을 0으로.
        MoveFlag = false;
    }
}
