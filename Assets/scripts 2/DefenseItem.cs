using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseItem : Item, IUseableItem
{
    public void Defense(Player user, Transform enemy)
    {
        Debug.Log("대충 방어함");
    }


    public void UseItem(Player user)
    {
        Defense(user,null);
    }

    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("그리고 방어기구 기능이 추가됨");
    }
}
