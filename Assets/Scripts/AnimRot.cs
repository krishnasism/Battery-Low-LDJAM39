﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimRot : MonoBehaviour {


	void Update () {
		transform.Rotate(0,0,Time.deltaTime*15f);
	}
}
