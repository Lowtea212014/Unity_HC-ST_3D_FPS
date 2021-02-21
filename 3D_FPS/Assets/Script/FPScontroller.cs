using UnityEngine;

public class FPScontroller : MonoBehaviour
{
    //頭銜
    [Header("移動"), Range(0, 2000)]
    public float speed;
    [Header("旋轉"), Range(0, 2000)]
    public float turn;

    //欄位
    private Animator ani;
    private Rigidbody rig;
    //取得
    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        OnAnimatorMove();
    }
    ///移動
    private void OnAnimatorMove()
    {

        float v = Input.GetAxis("Vertical"); // W S 上下- 前進1 後退-1
        float h = Input.GetAxis("Horizontal"); //A D 左右
        rig.MovePosition(transform.position + transform.forward * v * speed * Time.deltaTime+transform.right*h*speed*Time.deltaTime);
    }

}
