using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();

    void Start()
    {
      Debug.Log("Start here");
      StartCoroutine (FollowPath());
      Debug.Log("Finish here");  
    }

   IEnumerator FollowPath()
   {
    foreach(WayPoint waypoint in path)
    {
      Debug.Log(waypoint.name);
      yield return new WaitForSeconds(1f);
    }
   }
}
