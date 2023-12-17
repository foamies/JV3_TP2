using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStarter : MonoBehaviour
{
    public int cubeToKnock = 1; // the number of objects (cube) that have to touch the trigger to play the animation
public Animator animatorLift; //The animator component that holds the animation I want to play
private int COF = 0; // the variable that counts the objects (cubes) that touch the trigger
		

	void Start () {
		animatorLift.enabled = true;
		animatorLift.SetBool("AnimationStart", false); //when you have animations in your game, there's a tab next to "Scene", "Game" and "Asset Store" named "Animator". There
	}

	void OnTriggerEnter (Collider Cube) {
		if (Cube.gameObject.tag == "joueur") {
			AnimStart(); // each time an object with the cube tag touch the trigger, it adds 1 to COF
		}
	}
	
	void AnimStart() {
		animatorLift.SetBool("AnimationStart", true); // a function that sets the value of the boolean you created in you animator window to true when it's called
	}
}
