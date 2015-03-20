using UnityEngine;
using Zenject;

public class TestRunner : MonoBehaviour, ITickable, IInitializable, IFoo
{
    public void Initialize()
    {
        Debug.Log("Hello World");
    }

    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Exiting!");
            Application.Quit();
        }
    }
}