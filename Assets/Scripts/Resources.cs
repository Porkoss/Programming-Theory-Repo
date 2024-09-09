using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Resources : MonoBehaviour
{
    // Start is called before the first frame update
    private float m_wood=50;
    // ENCAPSULATION
    public float wood{
        get { return m_wood; }
        set{   if(value < 0.0f){
            Debug.LogError("Cannot have negative wood");}
        else {
            m_wood=value;}}
    }
    private float m_money=50;
    public float money{
        get { return m_money; }
        set{   if(value < 0.0f){
            Debug.LogError("Cannot have negative money");}
        else {
            m_money=value;}}
    }
    public float m_shelter=0;
    public float currentShelter{
        get { return m_shelter; }
        set{   if(value < 0.0f){
            Debug.LogError("Cannot have negative shelter");}
            else if (value > maxShelter){
                Debug.LogError("Cannot have more shelter than Max shelter");
            }
        else {
            m_shelter=value;}}
    }
    public float maxShelter=0;

    public TextMeshProUGUI woodText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI ShelterText;

    public bool Buying(float woodcost,float moneycost,float shelterCost){
        if(wood>=woodcost && money>=moneycost && currentShelter>=shelterCost){
            wood-=woodcost;
            money-=moneycost;
            currentShelter-=shelterCost;
            return true;
        }
        else{
            return false;
        }
    }

    void Update(){
        woodText.SetText("Wood: "+wood);
        ShelterText.SetText("Current :"+currentShelter + "/"+maxShelter);
        moneyText.SetText("Gold: "+money);
    }
}
