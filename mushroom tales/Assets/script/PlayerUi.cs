using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    #region value

    public Image mainItem;

    public Sprite[] itemimages;

    public int imagenumber;

    #endregion

    #region default    


    // Update is called once per frame
    void Update()
    {

    }
    #endregion

    private void itemChange(int input)
    {
        imagenumber = input;
        mainItem.sprite = itemimages[input];

    }

}
