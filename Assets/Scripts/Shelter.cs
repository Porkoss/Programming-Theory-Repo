using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shelter : Buildings
{
    // Start is called before the first frame update
    // INHERITANCE
    
    public TextMeshProUGUI textMeshProUGUI;

    
    protected override void Upgraded()
    {
        // POLYMORPHISM
        resources.maxShelter+=1;
        resources.currentShelter+=1;
        level+=1;
        Debug.Log("Upgraded");
        
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.SetText("LumberJackHouse, level "+level +"      "+"cost"+" g:"+moneyCost+" w:"+woodCost);
    }
}
