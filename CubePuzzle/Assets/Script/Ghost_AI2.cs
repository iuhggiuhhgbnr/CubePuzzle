using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Ghost_AI2 : MonoBehaviour
{
    public string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "Ghost_Config.csv");
    public Transform follow;
    protected string File_open;
    [SerializeField]
    protected int ghost_num = 1;
    [SerializeField]
    protected float speed =0.3f;

    void Start()
    {
        ReadFile();
        
    }
    void Awake()
    {
        File_open = "Ghost_Config.csv";
    }

    void ReadFile()
    {
        StreamReader input = null;
        
        string path = "Assets/StreamingAsset";
        //string path = Path.Combine(Application.streamingAssetsPath, "Ghost_Config.csv");

        //string path = Application.dataPath + "Assets/StreamingAsset";
        //string path = Application.dataPath + "/StreamingAssets";
        //string path = System.IO.Path.Combine(Application.streamingAssetsPath, "Ghost_Config.csv");
        try
        {
            input = File.OpenText(Path.Combine(path, File_open));
            Debug.Log("File is open");
            string name = input.ReadLine();
            string values = input.ReadLine();
            while (values != null) { AssignData(values); values = input.ReadLine(); }
        }
        catch (Exception ex) { Debug.Log(ex.Message); }
        finally
        {
            if (input != null) input.Close();
        }
    }

    void AssignData(string values)
    {
        Debug.Log(values);
        string[] data = values.Split(',');
        if (ghost_num == int.Parse(data[0]))
        {
            transform.name = data[1];
            Ghost_name.ghostname = name;
            speed = float.Parse(data[2]);

        }
    }
    void Update()
    {
        transform.LookAt(follow);
        transform.position = Vector3.Lerp(transform.position, follow.position, speed * Time.deltaTime);
    }

}
