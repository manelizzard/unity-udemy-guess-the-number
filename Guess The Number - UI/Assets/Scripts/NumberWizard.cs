using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Script controlling the Number Wizard algorithm.
/// A very basic IA trying to guess the number thought by the user.
/// </summary>
public class NumberWizard : MonoBehaviour {

	int max;
	int min;

	public Text guess;

	// Use this for initialization
	void Start () {
		// - Initialize variables
		max = 1000;
		min = 1;

		// - Gather UI Text to be updated as user plays
		guess = gameObject.GetComponent<Text> ();
		guess.text = 500 + "";

		max = max + 1;
	}

	/// <summary>
	/// Handle the user answer for Higher and Lower buttons.
	/// </summary>
	/// <param name="answer">The user answer as a string. "higher" for indicating the number is above the guessing try, "lower" otherwise.</param>
	public void UserAnswer(string answer) {

		// - Update limits depending on user information
		if (answer.Equals ("higher")) {
			min = int.Parse(guess.text);
		} else if (answer.Equals ("lower")) {
			max = int.Parse(guess.text);
		}

		int nextGuess = (max + min) / 2;

		// - User win check. The IA could not guess the number.
		if (nextGuess == int.Parse (guess.text)) {
			Application.LoadLevel ("win");
		} else {
			// - If there are other possible guesses, try it
			guess.text = nextGuess + "";
		}
	}
}