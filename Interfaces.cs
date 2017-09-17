interface Iitem
{
    string name { get; set; }
    int goldValue { get; set; }
    
    void Equip ();
    void Sell ();
}

interface Idamageable
{
    int durability { get; set; }
    
    void TakeDamage (int _amount);
}

interface IpartOfQuest
{
    void TurnIn ();
}