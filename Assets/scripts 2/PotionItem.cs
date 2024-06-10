using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : Item, IUseableItem
{
    public void Drink(Player user)
    {
        Debug.Log("������ �ȳ�");
    }

    public void UseItem(Player user)
    {
        Drink(user);
    }

    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("�׸��� �پ��� ������ �߰���");
    }
}
