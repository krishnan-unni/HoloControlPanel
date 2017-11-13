using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class RedLed : MonoBehaviour, IInputClickHandler
{
    public TextMesh result;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        IotController.Instance.SendCommand("<Device Name in the Hub>", "red");
        result.text = "Changing to red";
    }
}