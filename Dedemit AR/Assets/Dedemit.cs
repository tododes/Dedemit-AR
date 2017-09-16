using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dedemit : MonoBehaviour {

    [SerializeField]
    private Sprite dedemitDetailSprite;

    [SerializeField]
    private AreYouSurePanel detailPanel;
    private float angle;
    private float touchTimer;
    public bool touched;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touches.Length > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
            float lastTouchPosition = Input.GetTouch(0).position.y;
            if (Input.GetTouch(0).position.y > lastTouchPosition)
                angle += Input.GetTouch(0).deltaPosition.y * 0.05f;
            else
                angle -= Input.GetTouch(0).deltaPosition.y * 0.05f;
            transform.rotation *= Quaternion.AngleAxis(angle, Vector3.up);
        }

        if (touched){
            touchTimer += Time.deltaTime;
            if(touchTimer > 1.5f)
            {
                touched = false;
                detailPanel.GetComponent<Image>().sprite = dedemitDetailSprite;
                detailPanel.Trigger();
            }
        }
        else
            touchTimer = 0f;
	}

    void OnMouseDown()
    {
        Debug.Log("Down");
        touched = true;
    }

    void OnMouseUp()
    {
        touched = false;
    }
}
