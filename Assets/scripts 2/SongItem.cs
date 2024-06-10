using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongItem : Item, IUseableItem
{
    public void PlaySong(Player user)
    {
        Debug.Log("아름다운 노래가 나온다.");
    }


    public void UseItem(Player user)
    {
        PlaySong(user);
    }

    public override void EquipItem(Player user, bool offhand = true)
    {
        base.EquipItem(user, offhand);

        Debug.Log("노래가 추가됨?");
    }
}
