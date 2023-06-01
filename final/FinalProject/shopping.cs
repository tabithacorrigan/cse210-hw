public class Shopping {
    
    private string _itemName;
    private bool _isPurchased;

    public string ItemName { get => _itemName; set => _itemName = value; }
    public bool IsPurchased { get => _isPurchased; set => _isPurchased = value; }

    public Shopping(string itemName, bool isPurchased) {
        _itemName = itemName;
        _isPurchased = isPurchased;
    }

    public Shopping() {
        
    }

    public void PurchaseItem() {
        this.IsPurchased = true;
    }

    public void NewItem(string name) {

        this.ItemName = name;
        this.IsPurchased = false;

    }

    public string GetItem() {

        string retVal = "";

        string purchasedValue = this.IsPurchased?"X":" ";
        retVal = ($"{this.ItemName} [{purchasedValue}]");


        return retVal;

    }
}