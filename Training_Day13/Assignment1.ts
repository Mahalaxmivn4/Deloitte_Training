class Product
{
    public ProductId:number = 0;
    public ProductName:string  = "";
    public UnitPrice:number=0;
    public Quantity:number=0;

    constructor(ProductId:number=0)
    {
        this.ProductId=ProductId;
    }

    public getTotal(Price:number, Qty:number): number
    {
        let total:number = 0;
  
        total = Price * Qty;   
        return total;
    }
    public showDetails():void
    {
        console.log("Product Id : " + this.ProductId);
        console.log("Product Name : " + this.ProductName);
        console.log("UnitPrice : " + this.UnitPrice);
        console.log("Quantity : " + this.Quantity);
        console.log("TotalAmount : " + this.getTotal(this.UnitPrice,this.Quantity));
    }
}


let ptObj1:Product = new Product();
ptObj1.ProductId = 54654;
ptObj1.ProductName = "iphone";
ptObj1.UnitPrice=250000;
ptObj1.Quantity=12;
ptObj1.getTotal(ptObj1.UnitPrice,ptObj1.Quantity);
ptObj1.showDetails();

console.log();

let ptObj2:Product = new Product();
ptObj2.ProductId = 546345;
ptObj2.ProductName = "monitor";
ptObj2.UnitPrice=850000;
ptObj2.Quantity=5;
ptObj2.getTotal(ptObj2.UnitPrice,ptObj2.Quantity);
ptObj2.showDetails();

console.log();

let ptObj3:Product = new Product();
ptObj3.ProductId = 546190;
ptObj3.ProductName = "ear pods";
ptObj3.UnitPrice=8000;
ptObj3.Quantity=18;
ptObj3.getTotal(ptObj3.UnitPrice,ptObj3.Quantity);
ptObj3.showDetails();

console.log();



