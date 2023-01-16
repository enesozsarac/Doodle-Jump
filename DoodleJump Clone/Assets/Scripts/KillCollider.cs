using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCollider : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) 
   {
        if (other.transform.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
   }
}
