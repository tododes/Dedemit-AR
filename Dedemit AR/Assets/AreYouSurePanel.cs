using UnityEngine;
using System.Collections;

public class AreYouSurePanel : MonoBehaviour {

    public static AreYouSurePanel singleton;

    private RectTransform rect;

    [SerializeField]
    private int Index;

    [SerializeField]
    private Vector3 IncrementFactor;

	void Awake ()
    {
        singleton = this;
        rect = GetComponent<RectTransform>();
        Index = 0;
        //IncrementFactor = Vector3.one * 2;
	}

    public void SetIndex(int i)
    {
        Index = i;
    }

	void Update ()
    {
        if (Index == 0 && rect.localScale.x > 0){
            rect.localScale = rect.localScale - IncrementFactor * 1.33f * Time.deltaTime;

        }
        else if(Index == 0 && rect.localScale.x < 0){
            rect.localScale = Vector3.forward; 
        }

        if (Index == 1 && rect.localScale.x < IncrementFactor.x)
        {
            rect.localScale = rect.localScale + IncrementFactor * 1.33f * Time.deltaTime;
            Debug.Log("Inc");
        }
           
    }

    public void No()
    {
        Index = 0;
    }

    public void Yes(string name)
    {
        if (name == "Quit")
            Application.Quit();
        else
            Application.LoadLevel(name);
    }

    public void Trigger()
    {
        Index = 1;
    }
}
