class NonConsumableItem : Item
{
    private int maxDailyUses;

    public NonConsumableItem(string name, string description, int sellPrice, int useTimeCost)
        : base(name, description, sellPrice, useTimeCost)
    {

    }

    public override void UseItem()
    {

    }

    public override int ApplyEffects()
    {
        return base.ApplyEffects();
    }
}