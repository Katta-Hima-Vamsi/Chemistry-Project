using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	[SerializeField]
	string hoverOverSound = "ButtonHover";

	[SerializeField]
	string pressButtonSound = "ButtonPress";

	AudioManager audioManager;

	void Start ()
	{
		audioManager = AudioManager.instance;
		if (audioManager == null)
		{
			Debug.LogError("No audiomanager found!");
		}
	}

	public void StartGame ()
	{
		audioManager.PlaySound(pressButtonSound);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void MainMenu ()
	{
		audioManager.PlaySound(pressButtonSound);

		SceneManager.LoadScene(0);
	}

	public void NextIndexedScene ()
	{
		audioManager.PlaySound(pressButtonSound);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{
		audioManager.PlaySound(pressButtonSound);

		Debug.Log("WE QUIT THE GAME!");
		Application.Quit();
	}

	public void Question1 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(1);
	}

	public void Platformer1 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(2);
	}

	public void Question2 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(4);
	}

	public void Platformer2 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(5);
	}


	public void Question3 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(7);
	}

	public void Platformer3 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(8);
	}


	public void Question4 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(10);
	}

		public void Platformer4 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(11);
	}


	public void Question5 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(13);
	}

		public void Platformer5 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(14);
	}
	
	public void Question6 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(16);
	}

		public void Platformer6 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(17);
	}

	public void Question7 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(19);
	}

	public void Platformer7 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(20);
	}

	public void Question8 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(22);
	}

	public void Platformer8 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(23);
	}

	public void Question9 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(25);
	}

		public void Platformer9 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(26);
	}
	
	public void Question10 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(28);
	}

	public void Platformer10 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(29);
	}

	public void Question11 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(31);
	}

	public void Platformer11 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(32);
	}

	public void Question12 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(34);
	}

	public void Platformer12 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(35);
	}

	public void Question13 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(37);
	}

	public void Platformer13 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(38);
	}

	public void Question14 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(40);
	}

		public void Platformer14 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(41);
	}

	public void Question15 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(43);
	}

		public void Platformer15 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(44);
	}

	public void Question16 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(46);
	}

		public void Platformer16 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(47);
	}

	public void Question17 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(49);
	}

		public void Platformer17 ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(50);
	}

		public void EndScreen ()
	{
		audioManager.PlaySound(pressButtonSound);
		
		SceneManager.LoadScene(52);
	}

	public void OnMouseOver ()
	{
		audioManager.PlaySound(hoverOverSound);
	}

}
