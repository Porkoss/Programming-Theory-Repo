using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    // Start is called before the first frame update
    protected int level=0;
    public float woodCost=0;
    public float moneyCost=0;
    public float shelterCost=0;
    [SerializeField]protected Resources resources;

    public TextMeshProUGUI poorMessage;

    void Awake()
    {
        resources=GameObject.Find("Resources").GetComponent<Resources>();
    }
    public virtual void Upgrade(){
        bool isBuying = resources.Buying(woodCost,moneyCost,shelterCost);
        if(isBuying ==true ){
            woodCost+=10;
            moneyCost+=10;
            Upgraded();
        }
        else{
            poorMessage.gameObject.SetActive(true);
            StartCoroutine(PoorMessageOff());
        }

    }

    IEnumerator PoorMessageOff(){
        yield return new WaitForSeconds(2);
        poorMessage.gameObject.SetActive(false);
    }
    protected virtual void Upgraded(){

    }

    void OnMouseDown()
    {
        Upgrade();// ABSTRACTION
        
    }

    void OnMouseOver()
    {

    }
}
