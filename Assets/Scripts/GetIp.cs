using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using TMPro;

public class GetIp : MonoBehaviour
{
     private string path;
    public TextMeshProUGUI txt;

    void Start()
    {
        txt.text = GetLocalIpAdress();
    }

    public string GetLocalIpAdress()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach(var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        return "err";
    }
}
