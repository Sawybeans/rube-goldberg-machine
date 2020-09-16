using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class StartCamera : MonoBehaviour
{
    Camera camera1;
    Camera camera2;
    Camera camera3;
    Camera camera4;
    Camera camera5;
    Camera camera6;
    Camera camera7;

    public void OnTriggerStay2D(Collider2D other)
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;
    }
}


