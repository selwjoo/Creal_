using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Item mainHand;

    public Item offHand;
    // Start is called before the first frame update
    void Start()
    {
        new SwordItem()
        {
            damage = 10,
        }.EquipItem(this);

        // mainHand.Attack(this, null); �ϸ� ������ ����.
        //(mainHand is SwordItem){(mainHand as SwordItem).Attack(this, null);}  is as 

        IUseableItem useable = (IUseableItem)mainHand;
        if (useable != null)
        {
            useable.UseItem(this);
        }

        new FoodItem()
        {
            nutrition = 5, // !!
        }
        .EquipItem(this); // !! �ٹٲ� �԰��� 

        // offHand.Eat(this);
        //if(mainHand is FoodItem){(mainHand as FoodItem).Eat(this);}


       // �� /| 
      //  �� ��
      //   '' 
       //  ^ 
    }

}
