#pragma strict

public var time = 0;
public var speed = 1;

function Start () {

}

function Update () {
	time = Time.time;
	transform.RotateAround(Vector3(transform.position.x, transform.position.y, transform.position.z), Vector3.up, 50 * Time.deltaTime);
	/*if((time % 2) == 0)
	{
		transform.position.y += speed * Time.deltaTime;
	}
	else if((time % 2) != 0)
	{
		transform.position.y -= speed * Time.deltaTime;
	}*/
	
}