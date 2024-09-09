using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LumberJackHouse : Buildings 
{
    // INHERITANCE
    // Start is called before the first frame update
    private float woodProduction=0;
    public TextMeshProUGUI textMeshProUGUI;
    protected override void Upgraded()
    {
        // POLYMORPHISM
        woodProduction+=1;
        level+=1;
        Debug.Log("Upgraded");
        
    }


    void Start () {
    
        StartCoroutine(woodGain());
    }

    IEnumerator woodGain(){
        while(true){
            yield return new WaitForSeconds(1);
            resources.wood+=woodProduction;
        }
    }

    void FixedUpdate(){
        textMeshProUGUI.SetText("LumberJackHouse, level "+level +" +" + woodProduction +"wood/s"+"      "+"cost"+" g:"+moneyCost+" w:"+woodCost);
    }
}
