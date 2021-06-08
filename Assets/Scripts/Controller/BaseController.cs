using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public abstract class BaseController : IDisposable
{
    private List<BaseController> _baseControllers;
    private List<GameObject> _gameObjects;
    private bool _isDisposable;

    public void Dispose()
    { 
        if(!_isDisposable)
        {
            _isDisposable = true;

            if(_baseControllers != null)
            {
                foreach(BaseController controller in _baseControllers)
                {
                    controller?.Dispose();
                }
                _baseControllers.Clear();
            }

            if(_gameObjects != null)
            {
                foreach (GameObject gameObject in _gameObjects)
                {
                    Object.Destroy(gameObject);
                }
                _gameObjects.Clear();
            }
        }
        OnDispose();
    }

    protected void AddController(BaseController baseController)
    {
        if(_baseControllers == null)
        {
            _baseControllers = new List<BaseController>();
        }
        _baseControllers.Add(baseController);
    }
    protected void AddGameObject(GameObject gameObject)
    {
        if(_gameObjects == null)
        {
            _gameObjects = new List<GameObject>();
        }
        _gameObjects.Add(gameObject);
    }

    protected virtual void OnDispose()
    {
    }
}
