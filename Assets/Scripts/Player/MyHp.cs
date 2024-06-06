using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHp : MonoBehaviour, IHpBarInterface
{
    public int currentHP = 100;

    public int HP()
    {
        return this.currentHP;
    }
    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            //
        }
    }
    public void Healing(int HpHealing)
    {
        currentHP += HpHealing;
    }

}
