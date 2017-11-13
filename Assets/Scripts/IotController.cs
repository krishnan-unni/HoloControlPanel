using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using HoloToolkit.Unity;

#if NETFX_CORE
using Microsoft.Azure.Devices;
#endif

public class IotController : Singleton<IotController>
{
#if NETFX_CORE
    ServiceClient service;
#endif

    static string connectionUri = "<Iot Hub's service primary Connection string>";

    // Use this for initialization
    void Start()
    {
#if NETFX_CORE
        service = ServiceClient.CreateFromConnectionString(connectionUri, TransportType.Amqp);
        if(service != null)
            Debug.Log("Connected to IoT Hub");
        else
            Debug.Log("IoT Hub connection failed");
#endif
    }

#if NETFX_CORE
    public void SendCommand(string deviceName, string command)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(command);
        Message message = new Message(bytes);
        service.SendAsync(deviceName, message);
    }
#else
    public void SendCommand(string deviceName, string command)
    {
    }
#endif
}
