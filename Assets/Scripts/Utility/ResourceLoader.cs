using System;
using UnityEngine;

namespace Utility
{
    public class ResourceLoader
    {
        internal static GameObject LoadPrefab(ResourcePath viewPath)
        {
            return Resources.Load<GameObject>(viewPath.Path);
        }        
        internal static Sprite LoadSprite(ResourcePath viewPath)
        {
            return Resources.Load<Sprite>(viewPath.Path);
        }
    }
}
