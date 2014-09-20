using UnityEngine;
using System.Collections;

public class SwitchWorld : MonoBehaviour
{

    private bool _IsLimbo = false;

    private GameObject[] _Limbo;
    private GameObject[] _Real;

    // Use this for initialization
    void Start()
    {
        _Limbo = GameObject.FindGameObjectsWithTag("Limbo");
        _Real = GameObject.FindGameObjectsWithTag("Real");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Switch();
    }

    void OnGUI()
    {

    }

    private void Switch()
    {
        _IsLimbo = !_IsLimbo;

        Debug.Log("Limbo: " + _IsLimbo);

        if (_IsLimbo)
        {
            foreach (GameObject obj in _Limbo)
                obj.SetActive(true);
            foreach (GameObject obj in _Real)
                obj.SetActive(false);
        }

        if (!_IsLimbo)
        {
            foreach (GameObject obj in _Limbo)
                obj.SetActive(false);
            foreach (GameObject obj in _Real)
                obj.SetActive(true);
        }
    }
}
