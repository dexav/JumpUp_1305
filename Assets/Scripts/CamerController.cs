using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    //Room camera
    [SerializeField] private float speed;
    private float currentPosY;
    private Vector3 velocity = Vector3.zero;

    //Follow Player
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;




    public void Update()
    {
        //roomcamera
       //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, currentPosY, transform.position.z), ref velocity, speed);


        //follow player
        transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.y), Time.deltaTime * cameraSpeed);
       
    }

 //  public void MoveToNewRoom(Transform _newroom)
 //  {
 //      currentPosY = _newroom.position.y;
 //  }

}





