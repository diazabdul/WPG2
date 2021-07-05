using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class validation : MonoBehaviour
{
    public bool tester = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goAyu()
    {
        tester = true;
        SceneManager.LoadScene("slider");
    }
    public void goDodi()
    {
        tester = false;
        SceneManager.LoadScene("slider 1");
    }
}
