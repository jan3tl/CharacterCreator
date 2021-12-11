using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;
    public GameObject MagicRenderer;
    public ParticleSystem Bacteria;
    public ParticleSystem Cryokinesis;
    public ParticleSystem Pyrokinesis;
    public ParticleSystem Hydrokinesis;
    



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
        //this.MagicRenderer.gameObject.SetActive(false);
        this.Cryokinesis.Stop(true);
        this.Hydrokinesis.Stop(true);
        this.Pyrokinesis.Stop(true);
        this.Bacteria.Stop(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
