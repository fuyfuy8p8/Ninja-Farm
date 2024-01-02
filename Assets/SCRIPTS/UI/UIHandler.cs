using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    private int _numberScenStart = 1;  
    private int _numberScenMenu = 0;
    public void LoadGameLevel()
    {
        SceneManager.LoadScene(_numberScenStart);
    }

    public void LoadMenuLevel()
    {
        SceneManager.LoadScene(_numberScenMenu);
        
    }
}
