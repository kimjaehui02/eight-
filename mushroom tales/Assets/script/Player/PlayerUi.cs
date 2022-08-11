using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    #region value
    /// <summary>
    /// ui박스들을 가지고 있는 부모 오브젝트
    /// </summary>
    public GameObject itemBoxUi;

    /// <summary>
    /// 사용형 아이템 ui오브젝트의 이미지 컴포넌트 배열
    /// </summary>
    public Image[] box;

    /// <summary>
    /// 패시브 아이템 ui오브젝트의 이미지 컴포넌트
    /// </summary>
    public Image passivebox;

    /// <summary>
    /// 사용형 아이템들을 인트형으로 저장해놓은 배열
    /// </summary>
    public int[] boxint;

    /// <summary>
    /// 패시브 아이템을 인트형으로 저장함
    /// </summary>
    public int passiveint;

    /// <summary>
    /// 가져다 쓸 스프라이트들
    /// </summary>
    public Sprite[] Sprites;

    /// <summary>
    /// 플레이어의 최대 체력
    /// </summary>
    public float maxHp;
    /// <summary>
    /// 플레이어의 현재 체력
    /// </summary>
    public float Hp;

    /// <summary>
    /// 체력바를 나타내는 ui오브젝트의 렉트트랜스폼 컴포넌트
    /// </summary>
    public RectTransform Hpbar;

    /// <summary>
    /// 플레이어의 최대 기술포인트
    /// </summary>
    public float maxSp;
    /// <summary>
    /// 플레이어의 현재 기술포인트
    /// </summary>
    public float Sp;

    /// <summary>
    /// 기술포인트를 나타내는 ui오브젝트의 랙트트랜스폼 컴포넌트
    /// </summary>
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

    /// <summary>
    /// ui박스를 업데이트 하는 함수
    /// </summary>
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
