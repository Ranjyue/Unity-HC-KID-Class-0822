using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dragon : MonoBehaviour
{
    #region 欄位
    //  方法1：public Transform playerObj;
    //  方法1：protected NavMeshAgent mascotMesh;

    //  方法2：[Header("移動速度"), Range(0, 1000)]
    //  方法2：public float speed = 1.5f;

    //  方法2：private Transform target;


    public Transform player;
    public float moveSpeed = 5f;

    private Rigidbody rig;
    private Vector2 movement;

    #endregion

    #region 事件
    private void Start()
    {
        //  方法1：mascotMesh = GetComponent<NavMeshAgent>();
        //  方法2：target = GameObject.Find("跟隨座標").transform;

        rig = this.GetComponent<Rigidbody>();

    }

    private void Update()
    {
        //  方法1：mascotMesh.SetDestination(playerObj.position);
        //  方法2：Follow();

        Vector3 direction = player.position - transform.position;
        //Debug.Log(direction);
        float angle1 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // rig.rotation = angle1;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }


    #endregion

    #region 方法
    /** 方法2
    //private void Follow()
    //{
        //Vector3 posTarget = target.position;
        //Vector3 posPet = transform.position;

        //transform.position = Vector3.Lerp(posPet, posTarget, 0.5f*speed*Time.deltaTime);

        //posTarget.y = transform.position.y;
        //transform.LookAt(posTarget);
    //}
    */

    private void moveCharacter(Vector2 direction)
    {
        rig.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    #endregion

}
