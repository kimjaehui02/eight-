using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Animator Animator;

    private float speed;

    private void Awake()
    {
        Animator = gameObject.GetComponent<Animator>();
    }

    private void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        moving();


    }

    private void moving()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;

        transform.position = curPos + nextPos;

        Debug.Log(v);

        Animator.SetInteger("Ver", (int)v);



    }

    private void movingAnim()
    {

    }

}
