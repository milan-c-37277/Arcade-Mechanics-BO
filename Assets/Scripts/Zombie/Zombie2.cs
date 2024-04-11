using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie2 : MonoBehaviour
{
    public ZombieHand zombieHand;

    public int zomieDamage;

    private void Start()
    {
        zombieHand.damage = zomieDamage;
    }
}
