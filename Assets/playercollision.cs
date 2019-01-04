using UnityEngine;

public class playercollision : MonoBehaviour {
public PlayerMovement movement; 
void OnCollisionEnter(Collision CollisionInfo){
	if(CollisionInfo.collider.tag == "obstical"){
		movement.enabled = false;
}

}
}