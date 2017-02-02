using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class HologramBehaviors : MonoBehaviour, IFocusable, IInputClickHandler
{
    [SerializeField]
    public bool IsRotating = false;

    [SerializeField]
    public Color FocusedColor = Color.red;

    private Color OriginalColor;

    // Use this for initialization
    void Start()
    {
        this.OriginalColor = gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRotating)
            gameObject.transform.Rotate(1, 1, 1);
    }

    public void OnFocusEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = FocusedColor;
    }

    public void OnFocusExit()
    {
        gameObject.GetComponent<Renderer>().material.color = OriginalColor;
    }

    public void OnInputClicked(InputEventData eventData)
    {
        IsRotating = !IsRotating;
    }

}
