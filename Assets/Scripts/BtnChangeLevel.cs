using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnChangeLevel : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>(); //Grabs the button component
        button.onClick.AddListener(ButtonClicked); //Adds a listner on the button
    }

    public void ButtonClicked()
    {
        int SceneInt= SceneManager.GetActiveScene().buildIndex;
        LevelManager.Instace.LoadScene(SceneInt +1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
