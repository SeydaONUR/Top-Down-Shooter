using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Weapons")]
public class ScriptableWeapon : ScriptableObject
{
    //Silahlar icin gerekli ozellikler
    public int ammo;
    public float damage;
    public float range;
    public float waitToShot;
    public float reloadTime;
    public string explanation;

}
