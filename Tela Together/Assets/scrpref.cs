using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpref : MonoBehaviour
{
	private float G=1;
	private float rmod=0;
	private Vector3 F;
	private Rigidbody rbb;
	private Rigidbody rcb;
	private Rigidbody rxb;
	private float flag=0;
	private List<int> ii=new List<int>();
	private int iii=0;
	public bool exist=true;
	
	

	void OnCollisionEnter(Collision coll)
	
	{ //if ((this.name!="d")&&(coll.gameObject.name!="d")){
		if ((gameObject.name!="d")&& (this.name!="d"))
		{
	//if ((this!=null)&&(coll.gameObject!=null)){
	//if (coll.gameObject.transform.tag!="deleted")
	//{
			Debug.Log("collistion_in"+this.name);
			
		//Destroy(coll.gameObject.GetComponent<scrpref>());
		Debug.Log(this.name+" " + coll.gameObject.name);
		rcb= coll.gameObject.GetComponent<Rigidbody>();
		
		//Debug.Log(int.Parse(coll.gameObject.name));
		//coll.gameObject.enabled =false;
		//ii.Add(int.Parse(coll.gameObject.name));
		this.transform.localScale+=new Vector3(0.1f,0.1f,0.1f);
	  this.rbb.mass=rbb.mass+rcb.mass;
		Debug.Log(coll.gameObject.name+"name");
		Debug.Log(coll.gameObject.ToString());
		
		rcb.detectCollisions=false;
		Destroy(coll.gameObject);
		//Destroy(rcb);
		script.sphere.Remove(coll.gameObject);
		Debug.Log(script.sphere.Count+"list");
		flag=1;
		//this.name="d";
		//this.transform.gameObject.tag = "deleted";
		//this.GetComponent<scrpref>().enabled = false;
		//iii=iii+1;
		//if(this.isDestroyed) {}
	//coll.gameObject.name="deleted";
	 // coll.gameObject.tag="deleted";
	 // Debug.Log(GameObject.Find("Scene"));
	  //Debug.Log(coll.gameObject.activeSelf);
	  Debug.Log(coll+"collistion_out"+this.name);
	  coll.gameObject.name="d";
	} //else {Debug.Log("collistion_inm"+this.name);this.name="n";}
	//}
	Debug.Log(this.name+"aaa");
	  // Physics.IgnoreCollision(this.GetComponent<Collider>(), GetComponent<Collider>());
	}
	
	
	
	
    // Start is called before the first frame update
    void Start()
	
	
    { 
	
	rbb= GetComponent<Rigidbody>();
         F=new Vector3(0,0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
	
	
    { //F=new Vector3(0,0,0);
	//Debug.Log(iii+"i");
	//for (int i=0;i<iii;i++)
//	{
	//	Debug.Log(ii[i]+"list");
	//}
	//Debug.Log(flag+"flag");
		
			 //for (int j=0;j<script.n;j++)
		//{ 
//	Debug.Log(script.sphere[j].activeSelf);
	//}
       // Debug.Log(F);
		//Debug.Log("F");
    
			 foreach (GameObject x in script.sphere)
		{ Debug.Log(script.sphere.Count+"F");
	if ( (this.name!=x.name)&&(this.name!="d")&&(x.name!="d"))   
			{  //Debug.Log(script.sphere[j].name);
		Debug.Log("F_F"+this.name+" " +x.name);
		
		
		//if (!ii.Contains(j)) 
			//Debug.Log("j");
		//Debug.Log(j+" j");
		//Debug.Log(this.gameObject.activeSelf);
	
	//Debug.Log((this.name!=script.sphere[1].name));
	
		rxb= x.GetComponent<Rigidbody>();
		
		rmod=(x.transform.position-this.transform.position).magnitude;
		
		F=F+ G*rxb.mass*rbb.mass*(rxb.transform.position-this.transform.position)/(rmod*rmod*rmod);
			//F=new Vector3(1,1,1);
			
			
			}
			
		}
		if (this.name!="d")
		{
		this.GetComponent<Rigidbody>().AddForce(F,ForceMode.Force);			
		Debug.Log("F_out"+this.name);}
			 
	 
		 
		 
		 
    }
}
