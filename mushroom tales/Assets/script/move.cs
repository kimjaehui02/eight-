using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{


    #region value
    private Animator Animator;

    private float speed;
    #endregion

    #region default

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
    #endregion


    private void moving()
    {
        // 좌우
        float h = Input.GetAxisRaw("Horizontal");
        // 상하
        float v = Input.GetAxisRaw("Vertical");
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;

        // 오른쪽키와 윗키가 양수이다

        // 오른쪽키는 x좌표이고 hor
        // 윗키는 y좌표이고 ver

        transform.position = curPos + nextPos;


        Animator.SetInteger("Ver", (int)v);
        Animator.SetInteger("Horizontal", (int)h);

        //if(h == 0 && v == 0)
        //{
        //    Animator.SetInteger("speed", 0);
        //}
        //else
        //{
        //    Animator.SetInteger("speed", 1);
        //}



    }



    private void movingAnim()
    {

    }

}
