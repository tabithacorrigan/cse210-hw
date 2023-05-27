public class Shopping {
    
    private string _item;
    private bool _isPurchased;

    public string Item { get => _item; set => _item = value; }
    public bool IsPurchased { get => _isPurchased; set => _isPurchased = value; }

    public Shopping(string item, bool isPurchased) {
        _item = item;
        _isPurchased = isPurchased;
    }

    public void ClearItem() {

        Console.WriteLine("Shopping item cleared");
    }

    public void PurchaseItem() {
        Console.WriteLine("Item purchased");
    }
}