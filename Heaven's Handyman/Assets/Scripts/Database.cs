using UnityEngine;
using System.Collections;
using MySql.Data.MySqlClient;
using System;

public class Database : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;

        myConnectionString = "server=50.62.209.198;uid=Nenekiri_351;" +
            "pwd=Database351;database=Score;";

        try
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }
        catch (Exception ex)
        {
            print(ex.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
