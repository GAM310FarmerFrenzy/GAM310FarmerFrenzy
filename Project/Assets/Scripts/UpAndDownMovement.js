#pragma strict

public var time = 0;
public var speed = 1;


function Update () {
	time = Time.time;
	//Un comment the below line for a slow spin clockwise while object floats up and down. Great for pickup items
	//transform.RotateAround(Vector3(transform.position.x, transform.position.y, transform.position.z), Vector3.up, 50 * Time.deltaTime);
	
	if((time % 2) == 0)
	{
		transform.position.y += speed * Time.deltaTime;
	}
	else if((time % 2) != 0)
	{
		transform.position.y -= speed * Time.deltaTime;
	}
}