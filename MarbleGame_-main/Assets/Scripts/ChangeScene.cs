using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public void Level3 () {
        SceneManager.LoadScene(" Level 3");
    }

    public void Level4() {
        SceneManager.LoadScene("Level 4");
    }

    public void Level7() {
        SceneManager.LoadScene("Level 7");
    }

    public void Level9 () {
        SceneManager.LoadScene("Level 9");
    }

    public void Level10 () {
        SceneManager.LoadScene("Level 10");
    }
}
