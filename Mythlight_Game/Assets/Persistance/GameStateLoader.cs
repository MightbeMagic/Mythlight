using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is the manager for player saves.
/// All player saves will be loaded, updated, deleted, and created from this class.
/// todo: saveobject class to contain all needed objects for actually saving a file
/// todo: figure out how on earth to manage a savestate of a build.....
///     -need build template sizes. players can edit world files to make custom worlds but buildings will be restricted for the sake of my sanity.
///     -worlds as scenes? and then templates get their buildings loaded in as saves! haha! good job brain!
///     -open source project = anyone can make a world if they try hard enough. i believe in you.
/// todo: build world
/// todo: make character save object.
/// </summary>
public class GameStateLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //pull up general save information


    }

    void CreateSave()
    {

    }

    void DeleteSave()
    {

    }

    void LoadSave()
    {
        //called when a player selects a save
    }

    void OverwriteSave()
    {
        //called when a player explicitly saves
    }
}
