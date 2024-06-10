using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaeSpawnItem : Item, IUseableItem
{
    public void Spawn(Player user, Vector2 pos)
    {
        Debug.Log("���� Ȳ�°� ��ȯ");
    }


    public void UseItem(Player user)
    {
        Spawn(user, transform.position);
    }

    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("�׸��� Ȳ�°� �нż�");
    }
}
