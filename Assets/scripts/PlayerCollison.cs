using UnityEngine;

public class PlayerCollison : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisonInfo) {
        if (collisonInfo.collider.tag == "Obstacle" ) {
            movement.enabled = false;
        }
    }
}
