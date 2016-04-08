using UnityEngine;
using System.Collections;

public class CameraTeleport : MonoBehaviour{
    public Camera Camera1;
    public Camera Camera2;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Camera1.enabled = false;

            Camera2.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Camera1.enabled = true;

        Camera2.enabled = false;
    }
}