using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;


public class LoadScene : MonoBehaviour {

	
	Public Manager manager;	
	
	void Start ( )
	{
		counter = manager.GetComponent<bossCounter>();
	}
	void OnTriggerExit (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				Vector3 relativePos = transform.InverseTransformPoint(col.transform.position);
				if (relativePos.z > 0)
				{
					if (counter >= 5)
					{
						LoadBossScene();
					}
				}
				else
				{
					LoadScene();
					counter++;
				}
				
			}
	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(LevelScene);
	}		
	
	public void LoadBossScene(string bossScene)
	{
		SceneManager.LoadScene(BossScene);
	}	
		



	}
