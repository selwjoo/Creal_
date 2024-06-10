using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : Item, IUseableItem
{
    public void Drink(Player user)
    {
        Debug.Log("포션을 냠냠");
    }

    public void UseItem(Player user)
    {
        Drink(user);
    }

    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("그리고 다양한 포션이 추가됨");
    }
}
