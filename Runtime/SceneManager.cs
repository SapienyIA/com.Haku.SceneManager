using UnityEngine;
using UnityEngine.SceneManagement;

namespace HAKU.SceneManager
{
    /// <summary>
    /// SceneManager:switch scene & exit game
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        [SerializeField,Range(0.2f,2.5f),Header("音效時間")]
        private float audioduration = 2.0f;
        private string SceneName;
        /// <summary>
        /// change scene by scenename
        /// </summary>
        public void ChangeScene(string name)
        {
            SceneName = name;
            Invoke("DelayChangeScene",audioduration);
        }

        private void DelayChangeScene()
        {
            print("ChangeScene");
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
        }
        /// <summary>
        /// Quit game
        /// </summary>
        public void Quit()
        {
            Invoke("Delayquit",audioduration);
        }
        private void Delayquit()
        {
            print("QuitGame");
            Application.Quit(); 
        }
    }
}
