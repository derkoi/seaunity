//============================================================================================================
// Weili Zhi Copy right reserved.
//============================================================================================================
/// Action Base
//============================================================================================================
// Created on 18/7/2012 9:06:52 AM by Weili Zhi
//============================================================================================================
using UnityEngine;
using System.Collections;

public class ActionBase : MonoBehaviour
{
	public bool EnableAction = true;
    public virtual void Init()
    {
    }
	
	void Update()
    {
		if( EnableAction ) OnFrameUpdate();
    }

    protected virtual void OnFrameUpdate()
    {
    }
}