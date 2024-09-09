using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    // Start is called before the first frame update
    public float wood;
    public float money;
    public float currentShelter;
    public float maxShelter;

    public bool Buying(float woodcost,float moneycost,float shelterCost){
        if(wood>=woodcost && moneycost>=moneycost && currentShelter>=shelterCost){
            wood-=woodcost;
            money-=moneycost;
            currentShelter-=shelterCost;
            return true;
        }
        else(
            return false;
        )
    }
}
