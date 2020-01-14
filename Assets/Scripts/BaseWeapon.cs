public abstract class NewBehaviourScript : BaseObject
{
    protected Timer _rechargeTimer = new Timer();
    protected bool _fire = true;


    public abstract void Fire();
    

    protected override void Awake()
    {
        base.Awake();

    }


    protected virtual void Update()
    {
        _rechargeTimer.Update();
        if (_rechargeTimer.IsEvent())
        {
            _fire = true;
        }
    }
}
