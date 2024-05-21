using UnityEngine;
using System.Collections;

public class ChaseState : FSMState
{
    private Vector3 destPos; // the player position
    private float curRotSpeed = 1.0f;
    private float curSpeed = 100.0f;

    public ChaseState(Transform[] wp) 
    { 
        stateID = FSMStateID.Chasing;
    }

    public override void CheckTransitionRules(Transform player, Transform npc)
    {
        //Check the distance with player tank
        
        //When the distance is near, transition to attack state
        
        //Base on distance Check if need to switch to Attack or Patrol states
        
    }

    public override void RunState(Transform player, Transform npc)
    {
        //Rotate to the target point

        //Go Forward toward the player 
       
    }
}
