#pragma strict
// Created by Daehwan_Kim




public  var handGun      		:int       		      =0;
public  var shotGun				: int				  =0; 
public  var aK47				: int				  =0;
public  var rocketlauncher		: int		  		  =0;

private var obtHandGun : boolean = true;
private var obtShotGun : boolean = false;
private var obtAK : boolean = false;
private var obtRocket : boolean = false;


//public  var Plasma				: int				  =0;

//Object 
private var handGunobject		    : GameObject        = null;
private var shotGunobject			: GameObject 		= null;
private var aK47object				: GameObject		= null;
private var rocketlauncherobject	: GameObject		= null;
private var rocketlauncherobject2	: GameObject		= null;
private var rocketlauncherobject3	: GameObject		= null;

//private var PlasmaObject			  : GameObject		= null;

//Mesh
private var handGunmesh			    : MeshRenderer;
private var shotGunmesh				: MeshRenderer; 
private var aK47mesh				: MeshRenderer;	
private var rocketlaunchermesh		: MeshRenderer;
private var rocketlaunchermesh2     : MeshRenderer;	
//private var PlasmaMesh			  : MeshRenderer;

//Anim
private var handGunanim       	    : Animation;
//private var HandGunShootAnim        : Animation;
private var shotGunanim				: Animation;
//private var ShotGunShootAnim		: Animation;
private var aK47anim				: Animation;
//private var AK47ShootAnim		    : Animation;
private var rocketlauncheranim 		: Animation;
//private var RocketlauncherShootAnim : Animation;
//private var PlasmaAnim		      : Animation;
//private var PlasmaShootAnim         : Animation;





function Start () {
handGunobject        = GameObject.FindGameObjectWithTag("hand");
handGunanim   = handGunobject.GetComponent(Animation);
handGunmesh = handGunobject.GetComponent(MeshRenderer);

shotGunobject        = GameObject.FindGameObjectWithTag("shot");
shotGunmesh = shotGunobject.GetComponent(MeshRenderer);
shotGunanim  = shotGunobject.GetComponent(Animation);

aK47object		     = GameObject.FindGameObjectWithTag("ak");
aK47mesh = aK47object.GetComponent(MeshRenderer);
aK47anim  = aK47object.GetComponent(Animation);

rocketlauncherobject = GameObject.FindGameObjectWithTag("rocket");
rocketlauncherobject2 = GameObject.FindGameObjectWithTag("rocket2");
rocketlauncherobject3 = GameObject.FindGameObjectWithTag("rocket3");
rocketlaunchermesh = rocketlauncherobject2.GetComponent(MeshRenderer);
rocketlaunchermesh2 = rocketlauncherobject3.GetComponent(MeshRenderer);
rocketlauncheranim  = rocketlauncherobject.GetComponent(Animation);


handGun = 1;

shotGunmesh.enabled = false;
aK47mesh.enabled = false;
rocketlaunchermesh.enabled   = false;
rocketlaunchermesh2.enabled   = false;

obtAK = false;
obtRocket = false;
obtShotGun = false;



   
}


function Update () {


 if(handGun ==1)
 {

 	if(Input.GetMouseButtonDown(0))
 	 
 	{
 	
		handGunanim.Play("HandGunShoot");
		
	}

 }
 
 if(shotGun ==1)
 {

 	if(Input.GetMouseButtonDown(0))
 	 
 	{
		shotGunanim.Play("ShotGunShoot");
		
		
	}

 }
 
  if(aK47 ==1)
 {

 	if(Input.GetMouseButtonDown(0))
 	 
 	{
		aK47anim.Play("AK47Shoot");
	
		
	}

 }
 
  if(rocketlauncher ==1)
 {

 	if(Input.GetMouseButtonDown(0))
 	 
 	{
		rocketlauncheranim.Play("RocketlauncherShoot");
		
		
	}

 }



  if(handGun == 2)
   {
     if(Input.GetKeyDown(KeyCode.Alpha1))
       {
          
		   handGun 			= 1;
		   
		   shotGun = 2;				
 		   aK47	   = 2;		
 		   rocketlauncher = 2;
           
           handGunanim.Play("HandGun");  
           handGunmesh.enabled =true;
           
           shotGunmesh.enabled =false;
           aK47mesh.enabled = false;
           rocketlaunchermesh.enabled = false;
           rocketlaunchermesh2.enabled = false;
       }
     }
        
      if(shotGun == 2)
      {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
        	if(obtShotGun == true)
        	{
        		shotGun 			= 1;
		   
		  	 	handGun = 2;				
 		  		aK47	   = 2;		
 		   		rocketlauncher = 2;
           
           		shotGunanim.Play("ShotGun");  
           		shotGunmesh.enabled = true;
           
           		handGunmesh.enabled = false;
           		aK47mesh.enabled = false;
           		rocketlaunchermesh.enabled = false;
           		rocketlaunchermesh2.enabled = false;
           		
        	}
  
        }
      }
      
      if(aK47 == 2)
      {
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
        	if(obtAK == true)
        	{
        		aK47 			= 1;
		   
			    handGun = 2;				
	 		    shotGun	   = 2;		
	 		    rocketlauncher = 2;
	           
	            aK47anim.Play("AK47");  
	            aK47mesh.enabled = true;
	           
	            handGunmesh.enabled = false;
	            shotGunmesh.enabled = false;
	            rocketlaunchermesh.enabled = false;
	            rocketlaunchermesh2.enabled = false;
        	}
           
        }
      }
      
        
      if(rocketlauncher == 2)
      {
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
        	if(obtRocket == true)
        	{
        		rocketlauncher 			= 1;
		   
			   handGun = 2;				
	 		   shotGun	   = 2;		
	 		   aK47 =	2;
	           
	           rocketlauncheranim.Play("Rocketlauncher");  
	           rocketlaunchermesh.enabled = true;
	           rocketlaunchermesh2.enabled = true;
	           
	           handGunmesh.enabled =false;
	           shotGunmesh.enabled = false;
	           aK47mesh.enabled = false;
        	}
          
        }
      }




}



function OnTriggerEnter(other : Collider){
     
 
 
 
 
 
 /*if(other.tag=="HandGunPickup")
	{
	HandGun =   1;
	ShotGun   = 2;
	AK47 = 2;
	Rocketlauncher = 2;
	
	HandGunMesh.enabled =true;
	ShotGunMesh.enabled = false;
	AK47Mesh.enabled = false;
	RocketlauncherMesh.enabled = false;
	
	ShotGunAnim.Play("HandGun");  
	
	Destroy(other.gameObject);
	}*/
 
 
  
 
if(other.tag=="ShotGunPickup")
	{
		
		shotGun =   1;
		handGun   = 2;
		aK47 = 2;
		rocketlauncher = 2;
		
		obtShotGun = true;
		print(obtAK);
		
		shotGunmesh.enabled =true;
		handGunmesh.enabled = false;
		aK47mesh.enabled = false;
		rocketlaunchermesh.enabled = false;
		rocketlaunchermesh2.enabled = false;
		
		shotGunanim.Play("ShotGun");  
		
		Destroy(other.gameObject);
	}
	
if(other.tag=="AK47Pickup")
	{
		aK47 =   1;
		handGun   = 2;
		shotGun = 2;
		rocketlauncher = 2;
		obtAK = true;
		
		
		aK47mesh.enabled =true;
		handGunmesh.enabled = false;
		shotGunmesh.enabled = false;
		rocketlaunchermesh.enabled = false;
		rocketlaunchermesh2.enabled = false;
		
		aK47anim.Play("AK47");  
		
		Destroy(other.gameObject);
	}

if(other.tag=="RocketlauncherPickup")
	{
		rocketlauncher =   1;
		handGun   = 2;
		shotGun = 2;
		aK47 = 2;
		
		obtRocket = true;
		
		rocketlaunchermesh.enabled =true;
		rocketlaunchermesh2.enabled = true;
		handGunmesh.enabled = false;
		shotGunmesh.enabled = false;
		aK47mesh.enabled = false;
		
		rocketlauncheranim.Play("Rocketlauncher");  
		
		Destroy(other.gameObject);
	}
  


  
  
  }		
