using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    #region value
    public GameObject itemBoxUi;

    public Image[] box;

    public Image passivebox;

    public int[] boxint;

    public int passiveint;

    public Sprite[] Sprites;


    public float maxHp;
    public float Hp;

    public RectTransform Hpbar;

    public float maxSp;
    public float Sp;

    public RectTransform Spbar;

    #endregion

    #region default    


    // Update is called once per frame
    void Update()
    {
        UiboxUpdate();
        HpUpdate();
    }
    #endregion

    public void UiboxUpdate()
    {
        for(int index =0; index < 3; index++)
        {
            box[index].sprite = Sprites[boxint[index]];
        }

        passivebox.sprite = Sprites[passiveint];

    }

    public void HpUpdate()
    {
        Vector2 vector2 = new Vector2(350 * (Hp / maxHp), 60);
        Hpbar.sizeDelta = vector2;

        Vector2 vector22 = new Vector2(300 * (Sp / maxSp), 15);
        Spbar.sizeDelta = vector22;
    }

    public void HpChange(float input)
    {
        Hp += input;

    }

}
