using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OakMoveScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.45f;

    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
