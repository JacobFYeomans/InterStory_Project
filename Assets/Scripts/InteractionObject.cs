using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionObject : MonoBehaviour
{
    public enum InteractableType
    {
        nothing, //default
        info, //give info abt itself
        pickup, //can be picked up
        dialogue //obj has dialogue
    }

    [Header("Type of interactable")]
    public InteractableType interType;

    [Header("Simple info Message")]
    public string infoMessage;
    private Text infoText;

    public void Start()
    {
        infoText = GameObject.Find("infoText").GetComponent<Text>();
    }

    public void Nothing()
    {
        Debug.LogWarning("Object " + this.gameObject.name + " has no type set.");
    }

    public void InfoMessage()
    {
        infoText.text = infoMessage;
    }


}
