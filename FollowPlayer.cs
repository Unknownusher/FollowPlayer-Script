using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField] PlayerMovement Player;

    private void Update() {

        //caclulate the direction of the player
        Vector3 playerDirection = Vector3.Normalize(Player.transform.position - transform.position);

        Quaternion targetRotation = Quaternion.LookRotation(playerDirection);
        transform.rotation = Quaternion.Euler(0f, targetRotation.eulerAngles.y, 0f);

    }

}
