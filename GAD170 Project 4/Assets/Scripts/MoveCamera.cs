using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform playerHead;
    public GameObject player;
    public Camera Cam;
    public GameObject Gun;
    void Update()
    {
        transform.position = playerHead.transform.position;
    }
}