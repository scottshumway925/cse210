using System.Runtime.CompilerServices;

class ItemRecipe
{
    private bool _requirementsMet = false;
    private Dictionary<string, bool> _requirementList = new Dictionary<string, bool>();
    private string _name;
    private int _sellAmount;
    private string _description;


    public ItemRecipe(string requirementsString, string name, int sellAmount, string description)
    {
        string[] items = requirementsString.Split(",");

        foreach (string item in items)
        {
            if (!_requirementList.ContainsKey(item))
            {
                _requirementList[item] = false;
            }
        }

        _name = name;
        _sellAmount = sellAmount;
        _description = description;
    }

    public int GetSellAmount()
    {
        return _sellAmount;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDefinition()
    {
        return _description;
    }

    public string GetRequirements()
    {
        return string.Join(", ", _requirementList.Keys);
    }

    public bool CheckForRequirements(Inventory inventory)
    {
        foreach (string key in _requirementList.Keys.ToList())
        {
            _requirementList[key] = false;
        }

        HashSet<int> indexesToRemove = new HashSet<int>();

        foreach (String requiredItem in _requirementList.Keys.ToList())
        {
            for (int i = 0; i < inventory.GetInventory().Count(); i++)
            {
                Item invItem = inventory.GetInventory()[i];
                if (!indexesToRemove.Contains(i) && invItem.GetName() == requiredItem)
                {
                    _requirementList[requiredItem] = true;
                    indexesToRemove.Add(i);
                    break;
                }
            }
        }

        _requirementsMet = _requirementList.Values.All(value => value == true);
        if (_requirementsMet)
        {
            foreach (int index in indexesToRemove.OrderByDescending(i => i))
            {
                inventory.RemoveItem(index);
            }
        }
        return _requirementsMet;
    }
}