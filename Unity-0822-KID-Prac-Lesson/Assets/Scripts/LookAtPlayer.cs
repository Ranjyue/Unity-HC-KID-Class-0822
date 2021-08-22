using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private int z;

    public void Update()
    {
        transform.LookAt(target);
        transform.Rotate(x, y, z);
    }


}
