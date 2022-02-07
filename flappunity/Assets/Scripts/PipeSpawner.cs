using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1f;
    private float _timer = 0f;
    public GameObject pipe;
    public float height;
    
    // Start is called before the first frame update
    void Start()
    {
        var newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTime)
        {
            var newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
