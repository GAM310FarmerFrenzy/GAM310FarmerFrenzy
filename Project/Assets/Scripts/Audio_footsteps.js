#pragma strict

static var makeSound : boolean = true;

function Start () {
makeSound = true;
GetComponent.<AudioSource>().volume = 0;

}




function Update () {

if(makeSound == true)
{
	GetComponent.<AudioSource>().mute = false;
	if(Input.GetKey("a") || Input.GetKey("w") || Input.GetKey("d")
	|| Input.GetKey("s") ) 
	{


		GetComponent.<AudioSource>().volume = 1;

	}


	else 
	{
	
		GetComponent.<AudioSource>().volume = 0;


	}
}
else
{
	GetComponent.<AudioSource>().mute = true;
}





}