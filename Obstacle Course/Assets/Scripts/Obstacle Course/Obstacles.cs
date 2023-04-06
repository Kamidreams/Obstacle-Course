using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
       if(gameObject.tag != "Hit")
       {
           if(other.gameObject.CompareTag("Player"))
       {
           Debug.Log("The Player ran into me...");
           gameObject.tag = "Hit";
           LevelManager.Instance.UpdatePlayerHealthCount(1);
       }
       }
   }
}
