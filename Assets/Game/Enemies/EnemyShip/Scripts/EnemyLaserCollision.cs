﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserCollision : MonoBehaviour
{
    public GameObject laser;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            Destroy(laser);
        }
    }
}
