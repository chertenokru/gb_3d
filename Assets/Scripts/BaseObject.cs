using UnityEngine;

/// <summary>
/// Базовый класс для все объектов на сцене, кэширующий ссылки
/// </summary>
public abstract class BaseObject : MonoBehaviour
{
    protected Transform _GOTransform;
    protected GameObject _GOInstance;
    protected string _name;
    protected bool _isVisible;

    protected Vector3 _position;
    protected Vector3 _scale;
    protected Quaternion _rotation;

    protected Material _material;
    protected Color _color;

    protected Rigidbody _rigidbody;

    protected Camera _mainCamera;

    protected Animator _animator;

    #region UnityFunctions
    protected virtual void Awake()
    {
        _GOInstance = gameObject;
        _GOTransform = gameObject.transform;
        _name = gameObject.name;

        _mainCamera = Camera.main;

        if (GetComponent<Rigidbody>())
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        if (GetComponent<Animator>())
        {
            _animator = GetComponent<Animator>();
        }

        if (GetComponent<Renderer>())
        {
            _material = GetComponent<Renderer>().material;
        }

    }
    #endregion

    /// <summary>
    ///  Ссылка на объект
    /// </summary>
    public GameObject InstanceObject
    {
        get { return _GOInstance; }
    }

    /// <summary>
    /// Имя объекта
    /// </summary>
    public string Name
    {
        get { return _name; }
        set
        {
            _name = value;
            InstanceObject.name = _name;
        }
    }

    /// <summary>
    /// Видимость объекта
    /// </summary>
    public bool IsVisible
    {
        get { return _isVisible; }
        set
        {
            _isVisible = value;
            if (_GOInstance.GetComponent<Renderer>())
            {
                _GOInstance.GetComponent<Renderer>().enabled = _isVisible;
            }
        }
    }

    /// <summary>
    /// Позиция объекта
    /// </summary>
    public Vector3 Position
    {
        get
        {
            if (_GOInstance)
            {
                _position = _GOTransform.position;
            }
            return _position;
        }
        set
        {
            _position = value;
            if (_GOInstance)
            {
                _GOTransform.position = _position;
            }
        }
    }


    /// <summary>
    /// Масштаб объекта
    /// </summary>
    public Vector3 Scale
    {
        get
        {
            if (_GOInstance)
            {
                _scale = _GOTransform.localScale;
            }
            return _scale;
        }
        set
        {
            _scale = value;
            if (_GOInstance)
            {
                _GOTransform.localScale = _scale;
            }
        }
    }

    /// <summary>
    /// Вращение объекта 
    /// </summary>
    public Quaternion Rotation
    {
        get
        {
            if (_GOInstance)
            {
                _rotation = _GOTransform.rotation;
            }
            return _rotation;
        }
        set
        {
            _rotation = value;
            if (_GOInstance)
            {
                _GOTransform.rotation = _rotation;
            }
        }
    }

    /// <summary>
    /// Материал объекта
    /// </summary>
    public Material GetMaterial
    {
        get { return _material; }
    }

    /// <summary>
    /// Rigidboby объекта
    /// </summary>
    public Rigidbody GetRigidbody
    {
        get { return _rigidbody; }
    }

    /// <summary>
    /// Аниматор объекта
    /// </summary>
    public Animator GetAnimator
    {
        get { return _animator; }
    }

    /// <summary>
    /// Главная камера
    /// </summary>
    public Camera GetCamera
    {
        get { return _mainCamera; }
    }

    /// <summary>
    /// Число дочерних объектов
    /// </summary>
    public int ChildCount
    {
        get { return _GOTransform.childCount; }

    }
}
