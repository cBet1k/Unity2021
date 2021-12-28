using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script: MonoBehaviour
{ 	private  List<Material> texture=new List<Material>();
    private Material materiall;
	public Material materialll;
	private float G=1;
	private float rmod=0;
	 public int n=8;
	public GameObject prefab;
	static public List<GameObject> sphere=new List<GameObject>();
	static public List<Rigidbody> rb=new List<Rigidbody>();
	private List<Vector3> F=new List<Vector3>();
	private List<Vector3> r=new List<Vector3>();
	private List<float> m=new List<float>();
	private List<Renderer> colour=new List<Renderer>();
	private List<TrailRenderer> tail=new List<TrailRenderer>();
	private Collision colls;

	
	GameObject MakePrefab(int i)
	{
		
		GameObject prefab = GameObject.CreatePrimitive(PrimitiveType.Sphere); // Create basic cube instead of prefab
    prefab.AddComponent<SphereCollider>();
     prefab.AddComponent<Rigidbody>();
	prefab.AddComponent<TrailRenderer>();
	prefab.GetComponent<Rigidbody>().useGravity = false;
	prefab.AddComponent<scrpref>();
	prefab.SetActive(true);
	Material mat= new Material(materialll);
	prefab.GetComponent<Renderer>().material=mat;
	prefab.GetComponent<TrailRenderer>().material=mat;
	prefab.GetComponent<TrailRenderer>().time=Mathf.Infinity;
	prefab.GetComponent<TrailRenderer>().startWidth=0.2f;
	prefab.GetComponent<TrailRenderer>().generateLightingData=true;
	prefab.name=i.ToString();
	
	
		
		return prefab;
	}
	
	
	
	float Random_position(int i)
	{ 
		if (i%2==0) return (-i+2);
		else return (i/2-2);
		
	}
	float Random_velocity(int i)
	{ 
		if (i%2==0) return (-i*2+2);
		else return (i*3-2);
		
	}
	Material Random_colour(int i, Material materialls)
	{ 
	 Material mat= new Material(materialll);
	   switch (i%5)
	   { 
	   case 0: 
	   
	 
		
	  mat.color=new Vector4(0f,0f,0f,1f);
	    return mat;
	   break;
	   
		case 1: 
	   mat.color=new Vector4(0f,0f,1f,1f);
	    return mat;
	   break;
	   case 2: 
	   mat.color=new Vector4(0f,1f,1f,1f);
	    return mat;
	   break;
	   case 3: 
	   mat.color=new Vector4(1f,0f,0f,1f);
	    return mat;
	   break;
	    return mat;
	   case 4: 
	   mat.color=new Vector4(1f,1f,1f,1f);
	    return mat;
	   break;
	   default:
               mat.color=new Vector4(0f,1f,1f);
			    return mat;
              break;
			  
	   }
	}
	
	void Awake()
	{   
	 
	
	
	
		 for (int i=0;i<n;i++)
			 
		 {    
			 sphere.Add(MakePrefab(i));
			 sphere[i].transform.position=new Vector3 (2*i,3*i,2*i);
			 rb.Add(sphere[i].GetComponent<Rigidbody>());
			 colour.Add(sphere[i].GetComponent<Renderer>());
			 
			 colour[i].material=Random_colour(i,materialll);
			 tail.Add(sphere[i].GetComponent<TrailRenderer>());
			 tail[i].material=Random_colour(i,materialll);
			 if (i==0) {rb[i].mass=1;}else
			 {
			 rb[i].mass=i;
			 }
			 m.Add(rb[i].mass);
			
			 
			 r.Add(sphere[i].transform.position);
			 
			
			rb[i].AddForce(new Vector3(2*i,i,i), ForceMode.Impulse);
			
			
			 
		 }
		 
		 for (int i=0;i<n;i++)
			 {
				 
				  for (int j=0;j<n;j++)
				  {
					  if ((i!=j)&&((r[i]-r[j]).magnitude<=1)&&(sphere[i])&&(sphere[j])) {Destroy(sphere[i]); Destroy(sphere[j]);}
				  }					  
				 
			 }
		 
	}
	
	
	
	
    void Start()
	
	
	
	
    { 

   
	
    }
 
   
    void FixedUpdate()
    { 
	
	
    }
}
