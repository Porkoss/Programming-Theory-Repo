using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdventurerGuild : Buildings
{
    // INHERITANCE
    // Start is called before the first frame update
    private float goldProduction=0;
    public TextMeshProUGUI textMeshProUGUI;
    
    protected override void Upgraded()
    {
        // INHERITANCE
        goldProduction+=1;
        level+=1;
        Debug.Log("Upgraded");
        
    }


    void Start () {
    
        StartCoroutine(goldGain());
    }

    IEnumerator goldGain(){
        while(true){
            yield return new WaitForSeconds(1);
            resources.money+=goldProduction;
        }
    }

    void FixedUpdate(){
        textMeshProUGUI.SetText("AdventurerGuild, level "+level +" +" + goldProduction +"gold/s"+"      "+"cost"+" g:"+moneyCost+" w:"+woodCost);
    }
}
