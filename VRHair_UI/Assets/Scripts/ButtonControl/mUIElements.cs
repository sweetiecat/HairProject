using System.Collections;
using System.Collections.Generic;
using Valve.VR.InteractionSystem;
using UnityEngine;


public class mUIElements : UIElement
{
    public Hand currentHand;
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnHandHoverBegin(Hand currentHand)
    {
        base.OnHandHoverBegin(currentHand);
        Debug.Log("Hover Begin");
    }

    protected override void OnHandHoverEnd(Hand currentHand)
    {
        base.OnHandHoverEnd(currentHand);
        Debug.Log("Hover End");
    }

    protected override void HandHoverUpdate(Hand currentHand)
    {
        base.HandHoverUpdate(currentHand);
        Debug.Log("Hovering");
    }

    public event System.Action buttonClick;
    protected override void OnButtonClick()
    {
        base.OnButtonClick();

        Debug.Log("Click");
        buttonClick.Invoke();
    }
    private void Start()
    {
        buttonClick += OnButtonCilckAdd;
    }


    public void OnButtonCilckAdd()
    {
        Debug.Log("Add");
    }
}
