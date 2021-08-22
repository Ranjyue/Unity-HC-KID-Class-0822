using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    #region 欄位

    [Header("移動速度"), Range(0, 1000)]
    public float speed = 1.5f;
    [Header("旋轉速度"), Range(0, 1000)]
    public float turn = 1.5f;

    #endregion

    private Rigidbody Rig;

    #region 事件

    public void Start()
    {
        Rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Turn();
    }

    private void FixedUpdate()
    {
        Move();
    }

    #endregion

    #region 方法
    private void Move()
    {
        float v = Input.GetAxisRaw("Vertical");
        Rig.AddForce(transform.forward * v * speed * Time.fixedDeltaTime);
    }

    private void Turn()
    {
        float h = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, h * Time.deltaTime * turn, 0);
    }
    #endregion

}
