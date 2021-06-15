using UnityEngine;
using Valve.VR.InteractionSystem;



public class MyUIElement : UIElement
{
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnHandHoverBegin(Hand hand)
    {
        base.OnHandHoverBegin(hand);
        Debug.Log("Hover Begin");
    }

    protected override void OnHandHoverEnd(Hand hand)
    {
        base.OnHandHoverEnd(hand);
        Debug.Log("Hover End");
    }

    protected override void HandHoverUpdate(Hand hand)
    {
        base.HandHoverUpdate(hand);
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