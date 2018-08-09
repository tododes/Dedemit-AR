using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class AreYouSurePanel : MonoBehaviour, ITrackObserver {

    private RectTransform rect;

    [SerializeField]
    private int Index;

    [SerializeField]
    private Vector3 IncrementFactor;

    private Image image;

	void Awake ()
    {
        image = GetComponent<Image>();
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

    public void OnTrackUpdate(TrackController controller){
        image.sprite = controller.getCurrentDedemit().getDetailSprite();
    }
}
