using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    #region value
    /// <summary>
    /// ui�ڽ����� ������ �ִ� �θ� ������Ʈ
    /// </summary>
    public GameObject itemBoxUi;

    /// <summary>
    /// ����� ������ ui������Ʈ�� �̹��� ������Ʈ �迭
    /// </summary>
    public Image[] box;

    /// <summary>
    /// �нú� ������ ui������Ʈ�� �̹��� ������Ʈ
    /// </summary>
    public Image passivebox;

    /// <summary>
    /// ����� �����۵��� ��Ʈ������ �����س��� �迭
    /// </summary>
    public int[] boxint;

    /// <summary>
    /// �нú� �������� ��Ʈ������ ������
    /// </summary>
    public int passiveint;

    /// <summary>
    /// ������ �� ��������Ʈ��
    /// </summary>
    public Sprite[] Sprites;

    /// <summary>
    /// �÷��̾��� �ִ� ü��
    /// </summary>
    public float maxHp;
    /// <summary>
    /// �÷��̾��� ���� ü��
    /// </summary>
    public float Hp;

    /// <summary>
    /// ü�¹ٸ� ��Ÿ���� ui������Ʈ�� ��ƮƮ������ ������Ʈ
    /// </summary>
    public RectTransform Hpbar;

    /// <summary>
    /// �÷��̾��� �ִ� �������Ʈ
    /// </summary>
    public float maxSp;
    /// <summary>
    /// �÷��̾��� ���� �������Ʈ
    /// </summary>
    public float Sp;

    /// <summary>
    /// �������Ʈ�� ��Ÿ���� ui������Ʈ�� ��ƮƮ������ ������Ʈ
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
    /// ui�ڽ��� ������Ʈ �ϴ� �Լ�
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
