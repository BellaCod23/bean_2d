using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour

{
    public GameObject bean;
    public GameObject teddy;
    public GameObject granny;
    public GameObject car;

    public GameObject toggleLeft;

    public GameObject toggleRight;

    public void ToggleBean(bool val)
    {
        bean.SetActive(val);
        toggleLeft.GetComponent<Toggle>().interactable = !val;    
        toggleLeft.GetComponent<Toggle>().interactable = !val;   
        
         }

    public void ToggleTeddy(bool val)
    {
        teddy.SetActive(val);
    }

    public void ToggleGranny(bool val)
    {
        granny.SetActive(val);
    }

    public void ToggleCar(bool val)
    {
        car.SetActive(val);
    }

    public void Flip(int val) {
       bean.transform.localScale = new Vector2(val, 1);

    }

}