using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dedemit : MonoBehaviour {

    [SerializeField]
    private Sprite dedemitDetailSprite;

    [SerializeField]
    private AreYouSurePanel detailPanel;

    [SerializeField]
    private string displayName;
    private IDedemitState state;

	// Use this for initialization
	void Start () {
        setState(new IdleState());
	}
	
	// Update is called once per frame
	void Update () {
        state.doAction(this);

        if (Input.touchCount == 1) {
            transform.Rotate(0, -Input.GetTouch(0).deltaPosition.x * 5f * Time.deltaTime, 0);
        }
	}

    public void setState(IDedemitState state) {
        this.state = state;
    }

    public string getDisplayName() {
        return displayName;
    }

    public Sprite getDetailSprite() {
        return dedemitDetailSprite;
    }
}
