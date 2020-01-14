using UnityEngine;

public class FlashLight : BaseObject
{
    private KeyCode control = KeyCode.F;

    [SerializeField]
    private Light _light;
    [SerializeField]
    private float timeout;
    [SerializeField]
    private float currTime;
    private float currReloadTime;


    void Start()
    {

        _light = GetComponentInChildren<Light>();
        timeout = 15;
    }


    void Update()
    {
        if (Input.GetKeyDown(control))
        {

            _light.enabled = !_light.enabled;
        }

        if (_light.enabled)
        {
            currTime += Time.deltaTime;

            if (currTime > timeout)
            {
                currTime = 0;
                _light.enabled = false;
            }
        }
    }
}
