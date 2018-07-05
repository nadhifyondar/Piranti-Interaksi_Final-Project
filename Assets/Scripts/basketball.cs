using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basketball : MonoBehaviour {

	public Text score;
	public Text remainingballs;

	private int currentscore = 0;
	private int remainingballs_number = 3;

	private Vector3 InitialPosition;

	void Start()
	{
		InitialPosition = this.transform.position;
		ChangeText ();
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Ring")
			{
			ScoreUpdate ();
			remainingballs_number++;
			}
	}

	public void DecreaseRemainingBalls()
	{
		remainingballs_number--;
		ChangeText ();
	}

	public void ChangeText()
	{
		remainingballs.text = "Remaining Balls: " + remainingballs_number.ToString ();
	}

	private void ScoreUpdate()
	{
		currentscore++;
		score.text = currentscore.ToString ();
	}

	public void ResetPosition()
	{
		this.transform.position = InitialPosition;
	}
}
