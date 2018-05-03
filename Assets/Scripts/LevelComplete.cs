using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {
	public void LoadNextLevel(){
		/* Inicia el siguiente nivel acorde al indice en el build
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); */
		Debug.Log ("Siguiente Nivel!");
	}
}
