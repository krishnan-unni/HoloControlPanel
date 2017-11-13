using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class GreenLed : MonoBehaviour, IInputClickHandler
{
    public TextMesh result;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        IotController.Instance.SendCommand("<Device Name in the Hub>", "green");
        result.text = "Changing to green";
    }
}
