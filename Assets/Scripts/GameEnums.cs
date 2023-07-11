using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnums : MonoBehaviour
{
    public enum MovementPattern
    {
       NormalForward,
       BoomerangForward,
       BoomerangSidways,
       ZigZagForward, 
    }

    public enum UnitTypes
    {
        Player,
        Enemy,
        Obstacle,
    }

    
}
