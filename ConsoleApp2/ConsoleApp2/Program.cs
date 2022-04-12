class VendingMachine
{
    int cola;
    int water;
    int tea;
    void VendingMachine(int cola, int water, int tea) {
        this.cola = cola;
        this.water = water;
        this.tea = tea;
    }
    void buyCola(int amount) {
        if (this.cola > amount)
        {
            this.cola -= amount;
        }
        else
        {
            Console.WriteLine("Can’t sale this amount");
        }
    }
    void buyWater(int amount) {
        if (this.water > amount)
        {
            this.water -= amount;
        }
        else
        {
            Console.WriteLine("Can’t sale this amount");
        }
    }
    void buyTea(int amount) {
        if (this.Tea > amount)
        {
            this.Tea -= amount;
        }
        else
        {
            Console.WriteLine("Can’t sale this amount");
        }
    }
    void showStock() {
        Console.WriteLine("Product on this machine,");
        Console.WriteLine("Cola:" + this.cola);
        Console.WriteLine("Cola:" + this.water);
        Console.WriteLine("Cola:" + this.tea);
    }
    void increaseStock(int cola, int water, int tea) {
        this.cola += cola;
        this.water += water;
        this.tea += tea;
    }
}
