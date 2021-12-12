using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;


    



    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }

    public void SetWeapon(Sprite newWeapon)
    {
        WeaponRenderer.sprite = newWeapon;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
