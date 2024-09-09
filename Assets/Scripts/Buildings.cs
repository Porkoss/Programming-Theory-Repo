using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    // Start is called before the first frame update
    public float woodCost;
    public float moneyCost;
    public float shelterCost;
    private Resources resources;

    void Start()
    {
        resources=GameObject.Find("Resources").GetComponent<Resources>();
    }
    public virtual void upgrade(){
        resources.Buying(woodCost,moneyCost,shelterCost);
        woodCost*=2;
        moneyCost*=2;
    }
}
