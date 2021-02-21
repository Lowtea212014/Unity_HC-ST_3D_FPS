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



}
