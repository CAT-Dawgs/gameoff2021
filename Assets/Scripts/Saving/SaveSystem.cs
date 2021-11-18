using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

// public class SaveSystem
// {
//     public static void SavePlayer(Player player)
//     {
//         //formatter to encrypt the save data files, because why not
//         BinaryFormatter formatter = new BinaryFormatter();
//         //path it saves to
//         string path = Application.persistentDataPath + "/player.game";
//         //creates file
//         FileStream stream = new FileStream(path, FoleMode.Create);
//         //creates instance of class "SaveData"
//         SaveData data = new SaveData(player);
//         formatter .Serialize(stream,data);
//         stream.Close();

//     }
//     public static SaveData LoadPlayer()
//     {
//         string path = Application.persistentDataPath + "/player.cs";
//         //checks if save data already exists
//         if (File.Exists(path))
//         {
//             BinaryFormatter formatter = new BinaryFormatter();
//             FileStream stream = new FileStream(path, FileMode.Open);
//             //decrypts the encrypted save data so its readable as savedata
//             SaveData data = formatter.Deserialize(stream) as SaveData;
//             //idk what it does, just prevents errors
//             stream.Close();
//         }else
//         {
//             //there is no save data to load
//             Debig.LogError("Save File Not Found in " + path);
//             return null;
//         }
//     }
//}

//these Shall work eventually
