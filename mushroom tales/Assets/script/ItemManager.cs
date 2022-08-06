using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    Vector3 vel = Vector3.zero;
    public int itemnumber;
    public GameObject sprite;

    public bool Up;
    private void Start()
    {
        StartCoroutine(floating());
    }


    #region ÄÚ·çÆ¾

    IEnumerator floating()
    {
        Vector3 destination = Vector3.zero;
        if (Up == true)
        {
            destination = new Vector3(0, 0.2f, 0);
            Up = false;

        }
        else
        {
            destination = new Vector3(0, -0.2f, 0);
            Up = true;
        }
        while (Vector3.Distance(sprite.transform.localPosition, destination) > 0.15f)
        {

            sprite.transform.localPosition = Vector3.Lerp(sprite.transform.localPosition, destination, 0.8f * Time.deltaTime);

            yield return null;
        }



        StartCoroutine(floating());

    }
    #endregion
}

