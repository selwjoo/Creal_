using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongItem : Item, IUseableItem
{
    public void PlaySong(Player user)
    {
        Debug.Log("�Ƹ��ٿ� �뷡�� ���´�.");
    }


    public void UseItem(Player user)
    {
        PlaySong(user);
    }

    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("�뷡�� �߰���?");
    }
}
