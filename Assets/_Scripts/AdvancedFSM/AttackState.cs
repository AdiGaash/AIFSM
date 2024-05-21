using UnityEngine;
using System.Collections;

public class AttackState : FSMState
{
    private Vector3 destPos;
    private Transform[] waypoints;
    private float curRotSpeed = 1.0f;
    private float curSpeed = 100.0f;

    public AttackState(Transform[] wp) 
    { 
        waypoints = wp;
        stateID = FSMStateID.Attacking;
        curRotSpeed = 1.0f;
        curSpeed = 100.0f;

        //find next Waypoint position
        FindNextPoint();
    }

    public override void CheckTransitionRules(Transform player, Transform npc)
    {
        //Check the distance with the player tank
        
        //Base on distance Check if need to switch to Chase or Patrol states
    }

    public override void RunState(Transform player, Transform npc)
    {
        //Set the target position as the player position
        
        //Turn the turret towards the player
      
        //Shoot bullet towards the player
       
    }

    /// <summary>
    /// Find the next semi-random patrol point
    /// </summary>
    public void FindNextPoint() {
        //Debug.Log("Finding next point");
        int rndIndex = Random.Range(0, waypoints.Length);
        Vector3 rndPosition = Vector3.zero;
        destPos = waypoints[rndIndex].position + rndPosition;
    }
}
