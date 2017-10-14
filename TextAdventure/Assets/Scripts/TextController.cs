using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, lock_0, sheets_0, cell_mirror, lock_1, freedom};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.cell){
			state_cell();
		}
		else if (myState == States.sheets_0)	{state_sheets_0();}
		else if (myState == States.mirror)		{state_mirror();}
		else if (myState == States.lock_0)		{state_lock_0();}
		else if (myState == States.cell_mirror)	{state_cell_mirror();}
		else if (myState == States.lock_1)		{state_lock_1();}
		else if (myState == States.freedom)		{state_freedom();}
	}
	
	void state_cell () {
		text.text = "You wake up and find yourself in a prison cell. Confused and afraid you lay there for a moment. All is still and quiet. " + 
				"You fear the worst and you know you somehow need to escape. " + 
				"You look around your cell and see some dirty sheets next to you on the bed, a mirror " +
				"on the wall, and a door that is locked from the outside. " + 
				" \"There must be a way out of here, I don't know how much time I have until whoever locked me in here returns.\"\n\n" + 
				"Press S to look at the Sheets, L to look at the Lock, or M to look at the Mirror."; 
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_0;}
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror;}
	}
	
	void state_sheets_0 () {
		text.text = "You can't believe you had these filthy sheets covering you while you slept for who knows how long. " + 
				"You notice that at one point they were probably white. " +
				"Now they are a filthy yellow and brown color. You notice a large red stain, " + 
				" \"Is that from me? Was I bleeding at some point?\"\n\n" +
				"You look all over your body to see if there are any traces of cuts or incisions and thankfully you don't find any. " + 
				"For a moment you relax, until you realize that means someone else must've been in this cell before you. " + 
				"Terror sets in as you realize you need to get out of this cell and you need to do it now.\n\n" + 
				"Press R to Return to exploring your cell."; 
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	
	void state_mirror () {
			text.text = "You walk over to the mirror and notice something strange about your face. You wipe the mirror clean to get a clearer look " + 
				"and you realize that you don't even recognize yourself. You stare, without blinking, at this face. Your face. Is it your face? Why don't you recognize " + 
				"it? You begin to shake with anger and confusion. At first you were only scared about who put you in this cell and why but now you start to doubt what " + 
				"is real and what is not." +
				" \"What the hell is going on? Did they drug me? Is this really what I look like? What the fuck is going on??\"\n\n" +
				"Suddenly everything starts to get hazy. You hear a crash and that brings everything back to focus. " + 
				"You notice that the mirror is shattered and your hand is in pain. " + 
				"You stand there silently, confused, warm blood dripping from your hand.\n\n" + 
				"You notice there is a large shard on the floor.\n\n" +
				"Press T to Take the shard, or press R to Return to exploring your cell."; 
		if (Input.GetKeyDown(KeyCode.T)) 		{myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}
	}
	
	void state_cell_mirror () {
		text.text = "You begin to think very dark thoughts while staring into the broken shard. " +
					"Maybe this will be my only escape. If I'm not alive when they come back then I would'nt be much use to them. If that's even why I am here. " +
					"You slowly start to bring the shard to your arm. " + 
					"A thought stops you. You look towards the lock.\n\n" +
					"Press L to view Lock" ;
		if (Input.GetKeyDown(KeyCode.L)) 	{myState = States.lock_1;}
	}
	
	void state_lock_0 () {
			text.text = "You walk to the door and lean down to inspect the lock. It's a lock with keypad. You don't know the security code. " + 
				"You wish you could see if there are dirty fingerprints to give some clue what the code is.\n\n" + 
				"Press R to Return to exploring your cell."; ; 
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	
	void state_lock_1 () {
			text.text = "You carefully put the mirror through the bars, and turn it around so you can see the lock. " + 
				"There are no fingerprints, but you can tell there are 4 keys that are more worn out than the others. " +
				"You try different combinations using the keys that are worn down but nothing happens. " +  
				"A sinking feeling sets in as you begin to fear that you'll never be able to get the right code. " + 
				"You decide to try one more time. You randomly press the worn down buttons again, and hear a click.\n\n" + 
				"Press O to Open, or R to Return to exploring your cell.";  
		if (Input.GetKeyDown(KeyCode.O))			{myState = States.freedom;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	
	void state_freedom () {
		text.text = "You have escaped from the prison cell but you quickly realize that this is not a prison.\n\n" +
				"Press P to Play again";
		if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.cell;}
	}
}
/* Part 2 will hopefully be soon! There is a lot more to this story. */