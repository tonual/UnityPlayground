using UnityEngine;
using System.Collections;
using System;

public abstract class Action : MonoBehaviour
{
	public virtual bool ExecuteAction(GameObject other)
	{
        
		return true;
	}
}
